using System;
using System.Threading;

namespace Conjure.PipeTalk.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestRawProto(args);
            TestOPGProto(args);
        }

        static void TestOPGProto(string[] args)
        {
            if (args.Length == 1)
            {
                if (args[0] == "s")
                {
                    DoOPGServer();
                    return;
                }
                else if (args[0] == "c")
                {
                    DoOPGClient();
                    return;
                }
            }

            Console.WriteLine("missing arg 's' or 'c'");
        }

        static void DoOPGClient()
        {
            using var client = OutProcGenProtocol.CreateClient("foo");
            Console.WriteLine("Client created");

            client.Connect();
            Console.WriteLine("Client connected");

            client.BeginSession();
            client.ReadProfiles((profile, path, content) =>
            {
                Console.WriteLine($"Got Profile [{profile}] path [{path}]:");
                Console.WriteLine($"  Body: [{content}]");
            });
        }

        static void DoOPGServer()
        {
            using var server = OutProcGenProtocol.CreateServer("foo");
            Console.WriteLine("Server created");

            server.WaitForConnection();
            Console.WriteLine("Server connected");

            server.BeginSession();

            server.StartProfile("p1");
            server.AddFile("p1_f1", "This is file 1 of profile 1");
            server.AddFile("p1_f2", "This is file 2 of profile 1");

            server.StartProfile("p2");
            server.AddFile("p2_f1", "This is file 1 of profile 2");
            server.AddFile("p2_f2", "This is file 2 of profile 2");

            server.EndSession();
        }

        static void TestRawProto(string[] args)
        {
            if (args.Length == 1)
            {
                if (args[0] == "s")
                {
                    DoRawServer();
                    return;
                }
                else if (args[0] == "c")
                {
                    DoRawClient();
                    return;
                }
            }

            Console.WriteLine("missing arg 's' or 'c'");
        }

        static void DoRawServer()
        {
            using var server = new Server("foo");
            Console.WriteLine("Server created");

            server.WaitForConnection();
            Console.WriteLine("Server connected");

            server.Write("VERS", "0.1.0");
            server.Write("PROFILE", "foobar");
            server.Write("FILE", 1400.ToString(), "file1.cs");
            server.Write("BODY", "body1");
            server.Write("END");
        }

        static void DoRawClient()
        {
            using var client = new Client("foo");
            Console.WriteLine("Client created");

            client.Connect();
            Console.WriteLine("Client connected");

            client.Read(out var key, out var args);
            while (key != null && key != "END")
            {
                if (args.Count > 0)
                {
                    Console.WriteLine("Got: " + key + " with:");
                    foreach (var arg in args)
                        Console.WriteLine("  * " + arg);
                }

                client.Read(out key, out args);
            }
            if (key == null)
                Console.WriteLine("Missing Key");
            else
                Console.WriteLine("Got END, bye");
        }
    }
}
