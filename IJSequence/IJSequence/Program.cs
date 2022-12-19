using System;

namespace IJSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 100;
            int beginSequence = 5;
            int sequenceStep = 7;

            for (int i = beginSequence; i < count; i += sequenceStep)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
