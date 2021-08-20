using System;

namespace Conjure.PipeTalk
{
    /// <summary>
    /// Defines the rules and semantics of the "Out-of-Process Generator"
    /// communication protocol for a source generator implemented as a
    /// conventional in-process source generator component communicating
    /// with an out-of-process worker process.
    /// </summary>
    public static class OutProcGenProtocol
    {
        public const string VersTag = "VERS";
        public const string Version = "0.1.0";

        public const string ErrorTag = "ERROR";
        public const string ErrorBodyTag = "ERRBODY";

        public const string ProfileTag = "PROFILE";
        public const string FileTag = "FILE";
        public const string BodyTag = "BODY";
        public const string EndTag = "END";

        public static OutProcGenServer CreateServer(string pipeName)
        {
            return new OutProcGenServer(pipeName);
        }

        public static OutProcGenClient CreateClient(string pipeName)
        {
            return new OutProcGenClient(pipeName);
        }
    }

    /// <summary>
    /// Implements the client end of the
    /// <see cref="OutProcGenProtocol"
    /// ><i>Out-of-Process Generator</i> protocol</see>.
    /// </summary>
    public class OutProcGenClient : IDisposable
    {
        private Client _client;
        private Action _endSession;

        internal OutProcGenClient(string name)
        {
            _client = new Client(name);
        }

        public void Dispose()
        {
            _client?.Dispose();
            _client = null;
        }

        public void Connect()
        {
            _client.Connect();
        }

        public void BeginSession(Action endSession = null)
        {
            _client.Read(out var tag, out var args, minArgs: 1);

            if (tag != OutProcGenProtocol.VersTag)
                throw new Exception($"protocol violation, expected version tag, got [{tag}]");

            if (args.Count != 1 || args[0] != OutProcGenProtocol.Version)
                throw new Exception($"protocol version violation, found invalid version info: [{string.Join(",", args)}]");

            _endSession = endSession;
        }

        public void ReadProfiles(Action<string, string, string> handler, Action<string, string, string> error = null)
        {
            string profile = null;
            string path = null;
            int size = -1;

            _client.Read(out var tag, out var args);
            while (tag != null && tag != OutProcGenProtocol.EndTag)
            {
                if (tag == OutProcGenProtocol.ErrorBodyTag)
                {
                    var code = args[0];
                    var mesg = args[1];
                    var body = default(string);

                    _client.Read(out tag, out args);
                    if (tag == OutProcGenProtocol.ErrorBodyTag)
                    {
                        _client.DecodeB64(args, out body);
                        _client.Read(out tag, out args);
                    }

                    if (error == null)
                    {
                        throw new Exception(mesg);
                    }
                    else
                    {
                        error(code, mesg, body);
                    }
                }
                if (tag == OutProcGenProtocol.ProfileTag)
                {
                    if (args.Count != 1)
                        throw new Exception("protocol violation, Profile record does not match expected arguments");

                    profile = args[0];
                    path = null;
                    size = -1;
                }
                else if (tag == OutProcGenProtocol.FileTag)
                {
                    if (args.Count != 2)
                        throw new Exception("protocol violation, File record does not match expected arguments");

                    size = int.Parse(args[0]);
                    path = args[1];

                    _client.ReadB64(out tag, out var data);
                    if (tag != OutProcGenProtocol.BodyTag)
                        throw new Exception("protocol violation, File record missing subsequent Body record");

                    if (data.Length != size)
                        throw new Exception("protocol violation, Body record data length does not match expected");

                    handler(profile, path, data);
                }
                else
                {
                    throw new Exception($"protocol violation, unexpected record with tag [{tag}]");
                }

                _client.Read(out tag, out args);
            }
        }
    }

    /// <summary>
    /// Implements the server end of the
    /// <see cref="OutProcGenProtocol"
    /// ><i>Out-of-Process Generator</i> protocol</see>.
    /// </summary>
    public class OutProcGenServer : IDisposable
    {
        private Server _server;

        internal OutProcGenServer(string name)
        {
            _server = new Server(name);
        }

        public void Dispose()
        {
            _server?.Dispose();
            _server = null;
        }

        public void WaitForConnection()
        {
            _server.WaitForConnection();
        }

        public void Fail(string code, string message, string body = null)
        {
            _server.Write(OutProcGenProtocol.ErrorTag, code, message);
            if (body != null)
                _server.WriteB64(OutProcGenProtocol.ErrorBodyTag, body);
        }

        public void BeginSession()
        {
            _server.Write(OutProcGenProtocol.VersTag, OutProcGenProtocol.Version);
        }

        public void StartProfile(string profile)
        {
            _server.Write(OutProcGenProtocol.ProfileTag, profile);
        }

        public void AddFile(string path, string content)
        {
            _server.Write(OutProcGenProtocol.FileTag, content.Length.ToString(), path);
            _server.WriteB64(OutProcGenProtocol.BodyTag, content);
        }

        public void EndSession()
        {
            _server.Write(OutProcGenProtocol.EndTag);
        }
    }
}