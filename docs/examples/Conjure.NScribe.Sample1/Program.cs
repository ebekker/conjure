using System;

namespace Conjure.NScribe.Sample1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before Generated Code");
            HelloFrom("Generated Code");
            GoodByeTo("Generated Code");
            Console.WriteLine("After Generated Code");
        }

        static partial void HelloFrom(string name);
        static partial void GoodByeTo(string name);
    }
}
