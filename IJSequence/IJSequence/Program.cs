using System;

namespace IJSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 7;
            int count = 14;
            int beginningSequence = -2;

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{beginningSequence += number} ");
            }
        }
    }
}
