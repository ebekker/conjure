using System;

namespace Conjure.EFX.Sample1
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            HelloFrom("Hello World!");
        }

        static partial void HelloFrom(string name);
        static partial void GoodByeTo(string name);
    }
}
