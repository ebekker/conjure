using System.IO.Pipes;

namespace Conjure.PipeTalk
{
    public class Client : Protocol
    {
        private NamedPipeClientStream _clientStream;

        public Client(string name)
            : base()
        {
            Name = name;
            _clientStream = new NamedPipeClientStream(".", name, PipeDirection.InOut);
            Init(_clientStream);
        }

        public void Connect() => _clientStream.Connect();

        public string Name { get; }

        public override void Dispose()
        {
            base.Dispose();
            _clientStream?.Dispose();
            _clientStream = null;

        }
    }
}