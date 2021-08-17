using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Conjure.PipeTalk
{
    /// <summary>
    /// Implements a super-simple protocol for exchange of information.
    /// </summary>
    /// <remarks>
    /// The protocol is a simple, string-based, line-oriented, exchange of
    /// messages.  Each message is either a lone name <i>tag</i> on a line
    /// or a name tag followed by one ore more string arguments.  The tag
    /// and any subsequent arguments are all separated by the null character
    /// so it is <i>assumed</i> that a null character will not be part of
    /// the payload (either tag or args).  To pass along any binary data
    /// or null-embedded strings, the args are expected to be escaped, such
    /// as with Base64 encoding.
    /// </remarks>
    public abstract class Protocol : IDisposable
    {
        public const char Separator = (char)0;
        private readonly static char[] SeparatorArray = new[] { Separator, };

        private Stream _stream;
        private StreamWriter _writer;
        private StreamReader _reader;

        protected Protocol()
        { }

        protected void Init(Stream stream)
        {
            _stream = stream;
            _writer = new StreamWriter(stream);
            _reader = new StreamReader(stream);
        }

        public void Write(string tag)
        {
            _writer.WriteLine(tag);
            _writer.Flush();
        }

        public void Write(string tag, params string[] args)
        {
            _writer.Write(tag);
            foreach (var arg in args)
            {
                _writer.Write(Separator);
                _writer.Write(arg);
            }
            _writer.WriteLine();
            _writer.Flush();
        }

        public void WriteB64(string tag, string data)
        {
            var b64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(data));

            _writer.Write(tag);
            _writer.Write(Separator);
            _writer.WriteLine(b64);
        }

        public void Read(out string tag)
        {
            tag = _reader.ReadLine();
        }

        public void Read(out string tag, out List<string> args,
            int? minArgs = null, int? maxArgs = null)
        {
            var line = _reader.ReadLine();
            if (line == null)
            {
                tag = null;
                args = null;
                return;
            }

            var segs = maxArgs != null
                ? line.Split(SeparatorArray, maxArgs.Value)
                : line.Split(SeparatorArray);

            if (segs.Length < 1)
            {
                throw new Exception("protocol violation, missing tag");
            }
            
            tag = segs[0];

            if (minArgs.HasValue && segs.Length <= minArgs.Value)
            {
                throw new Exception($"protocol violation, too few arguments received for tag [{tag}]");
            }

            args = new List<string>(segs);
            args.RemoveAt(0);
        }

        public void ReadB64(out string tag, out string data)
        {
            var line = _reader.ReadLine();
            if (line == null)
            {
                tag = null;
                data = null;
                return;
            }

            var segs = line.Split(SeparatorArray, 2);

            if (segs.Length < 1)
            {
                throw new Exception("protocol violation, missing tag");
            }

            tag = segs[0];

            if (segs.Length < 2)
            {
                throw new Exception($"protocol violation, missing Base64-encoded data argument for tag [{tag}]");
            }

            data = Encoding.UTF8.GetString(Convert.FromBase64String(segs[1]));
        }

        public virtual void Dispose()
        {
            _writer?.Dispose();
            _writer = null;
            _reader?.Dispose();
            _reader = null;
        }
    }
}
