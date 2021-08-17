using System;

namespace Conjure.PipeTalk
{
    public static class OutProcGenProtocol
    {
        public const string VersTag = "VERS";
        public const string Version = "0.1.0";

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
            _client.Dispose();
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

        public void ReadProfiles(Action<string, string, string> handler)
        {
            string profile = null;
            string path = null;
            int size = -1;

            _client.Read(out var tag, out var args);
            while (tag != null && tag != OutProcGenProtocol.EndTag)
            {
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



    //    public static void StartSession(this StreamWriter writer, StreamReader reader)
    //    {
    //        Console.WriteLine("Starting Session");
    //        writer.WriteLine(VersLine);
    //        writer.Flush();

    //        if (!string.Equals(reader.ReadLine(), AckLine))
    //            throw new Exception("did not receive ACK");
    //    }

    //    public static void StartProfile(this StreamWriter writer, StreamReader reader, string profile)
    //    {
    //        Console.WriteLine($"Starting profile: {profile}");
    //        writer.WriteLine(ProfileLine + profile);
    //        writer.Flush();

    //        if (!string.Equals(reader.ReadLine(), AckLine))
    //            throw new Exception("did not receive ACK");
    //    }

    //    public static void AddFile(this StreamWriter writer, StreamReader reader, string path, string content)
    //    {
    //        Console.WriteLine($"Adding File: {path}, {content.Length}");
    //        var b64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(content));
    //        writer.WriteLine(FileLine + content.Length + ":" + path);
    //        writer.WriteLine(BodyLine + b64);
    //        writer.Flush();

    //        if (!string.Equals(reader.ReadLine(), AckLine))
    //            throw new Exception("did not receive ACK");
    //    }

    //    public static void EndSession(this StreamWriter writer, StreamReader reader)
    //    {
    //        Console.WriteLine("Ending Session");
    //        writer.WriteLine(EndLine);
    //        writer.Flush();

    //        if (!string.Equals(reader.ReadLine(), AckLine))
    //            throw new Exception("did not receive ACK");
    //    }

    //    public static void ReadProfileFiles(this StreamReader reader, StreamWriter writer,
    //        Action<string, string, string> handler)
    //    {
    //        string profile = null;
    //        string path = null;
    //        int size = -1;

    //        var line = reader.ReadLine();
    //        while (line != EndLine)
    //        {
    //            var start = line.Substring(0, 30);
    //            Console.WriteLine("Got line starting with: " + start);

    //            if (line.StartsWith(ProfileLine))
    //            {
    //                profile = line.Substring(ProfileLine.Length);
    //                path = null;
    //                size = -1;
    //                writer.WriteLine(AckLine);
    //                writer.Flush();
    //            }
    //            else if (line.StartsWith(FileLine))
    //            {
    //                var file = line.Substring(FileLine.Length).Split(new[] {':'},  2);
    //                path = file[0];
    //                size = int.Parse(file[1]);
    //            }
    //            else if (line.StartsWith(BodyLine))
    //            {
    //                var b64 = line.Substring(BodyLine.Length);
    //                var body = Encoding.UTF8.GetString(Convert.FromBase64String(b64));
    //                if (body.Length != size)
    //                {
    //                    throw new Exception("content length does not match expected");
    //                }

    //                handler(profile, path, body);

    //                writer.WriteLine(AckLine);
    //                writer.Flush();

    //                path = null;
    //                size = -1;
    //            }
    //            else
    //            {
    //                throw new Exception("protocol violation, unexpected: " + line);
    //            }

    //            line = reader.ReadLine();
    //        }
    //    }

    //    public static void ReadSession(this StreamReader reader, StreamWriter writer)
    //    {
    //        var vers = reader.ReadLine();
    //        if (vers != VersLine)
    //        {
    //            throw new Exception("Incompatible version found");
    //        }
    //        writer.WriteLine(AckLine);
    //        writer.Flush();
    //        Console.WriteLine("Got Session: " + vers);
    //    }
    //}
}