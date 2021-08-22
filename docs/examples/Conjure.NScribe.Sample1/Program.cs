using System;

namespace Conjure.NScribe.Sample1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            HelloFrom("Generated Code");
            GoodByeTo("Generated Code");
        }

        static partial void HelloFrom(string name);
        static partial void GoodByeTo(string name);
    }
}
