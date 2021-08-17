using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Text;

namespace Conjure.PipeTalk
{
    public class Server : Protocol
    {
        private NamedPipeServerStream _serverStream;

        public Server(string name)
            : base()
        {
            Name = name;
            _serverStream = new NamedPipeServerStream(name, PipeDirection.InOut, 1);
            Init(_serverStream);
        }

        public void WaitForConnection() => _serverStream.WaitForConnection();

        public string Name { get; }

        public override void Dispose()
        {
            base.Dispose();
            _serverStream?.Dispose();
            _serverStream = null;

        }
    }
}