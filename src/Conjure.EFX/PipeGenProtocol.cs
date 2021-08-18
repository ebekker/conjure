using System.Text;

namespace Conjure.EFX
{
    public static class PipeGenProtocol
    {
        public const string VersLine = "VERS:0.1.0";
        public const string ProfileLine = "PROFILE:";
        public const string FileLine = "FILE:";
        public const string BodyLine = "BODY:";
        public const string EndLine = "END";
        public const string AckLine = "ACK";

        public static void StartSession(this StreamWriter writer, StreamReader reader)
        {
            Console.WriteLine("Starting Session");
            writer.WriteLine(VersLine);
            writer.Flush();

            if (!string.Equals(reader.ReadLine(), AckLine))
                throw new Exception("did not receive ACK");
        }

        public static void StartProfile(this StreamWriter writer, StreamReader reader, string profile)
        {
            Console.WriteLine($"Starting profile: {profile}");
            writer.WriteLine(ProfileLine + profile);
            writer.Flush();

            if (!string.Equals(reader.ReadLine(), AckLine))
                throw new Exception("did not receive ACK");
        }

        public static void AddFile(this StreamWriter writer, StreamReader reader, string path, string content)
        {
            Console.WriteLine($"Adding File: {path}, {content.Length}");
            var b64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(content));
            writer.WriteLine(FileLine + content.Length + ":" + path);
            writer.WriteLine(BodyLine + b64);
            writer.Flush();

            if (!string.Equals(reader.ReadLine(), AckLine))
                throw new Exception("did not receive ACK");
        }

        public static void EndSession(this StreamWriter writer, StreamReader reader)
        {
            Console.WriteLine("Ending Session");
            writer.WriteLine(EndLine);
            writer.Flush();

            if (!string.Equals(reader.ReadLine(), AckLine))
                throw new Exception("did not receive ACK");
        }

        public static void ReadProfileFiles(this StreamReader reader, StreamWriter writer,
            Action<string, string, string> handler)
        {
            string profile = null;
            string path = null;
            int size = -1;

            var line = reader.ReadLine();
            while (line != EndLine)
            {
                var start = line.Substring(0, 30);
                Console.WriteLine("Got line starting with: " + start);

                if (line.StartsWith(ProfileLine))
                {
                    profile = line.Substring(ProfileLine.Length);
                    path = null;
                    size = -1;
                    writer.WriteLine(AckLine);
                    writer.Flush();
                }
                else if (line.StartsWith(FileLine))
                {
                    var file = line.Substring(FileLine.Length).Split(new[] {':'},  2);
                    path = file[0];
                    size = int.Parse(file[1]);
                }
                else if (line.StartsWith(BodyLine))
                {
                    var b64 = line.Substring(BodyLine.Length);
                    var body = Encoding.UTF8.GetString(Convert.FromBase64String(b64));
                    if (body.Length != size)
                    {
                        throw new Exception("content length does not match expected");
                    }

                    handler(profile, path, body);

                    writer.WriteLine(AckLine);
                    writer.Flush();

                    path = null;
                    size = -1;
                }
                else
                {
                    throw new Exception("protocol violation, unexpected: " + line);
                }

                line = reader.ReadLine();
            }
        }

        public static void ReadSession(this StreamReader reader, StreamWriter writer)
        {
            var vers = reader.ReadLine();
            if (vers != VersLine)
            {
                throw new Exception("Incompatible version found");
            }
            writer.WriteLine(AckLine);
            writer.Flush();
            Console.WriteLine("Got Session: " + vers);
        }
    }
}