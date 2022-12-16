using System;

namespace IJSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 100;

            for (int i = 5; i < count; i += 7)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
