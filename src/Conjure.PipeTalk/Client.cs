using System.IO.Pipes;

namespace Conjure.PipeTalk
{
    /// <summary>
    /// Implements the client end of the
    /// <see cref="Protocol"><i>Pipe Talk</i> protocol</see>.
    /// </summary>
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