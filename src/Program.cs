using System;

namespace satire
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = args[0].Substring(0, int.Parse(args[1]));
            var second = args[0].Substring(int.Parse(args[1]));

            Console.WriteLine(first);
            Console.WriteLine(second);

        }
    }
}
