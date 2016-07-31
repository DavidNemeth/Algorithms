using System;

namespace Progression
{
    public class BProgression
    {
        protected long current = 0;

        public BProgression()
        {
        }

        public BProgression(long start)
        {
            current = start;
        }

        public long NextValue()
        {
            long ret = current;
            Advance();
            return ret;
        }

        protected virtual void Advance()
        {
            current++;
        }

        public void PrintProgression(int n)
        {
            Console.Write(NextValue());
            for (int i = 1; i < n; i++)
            {
                Console.Write(" " + NextValue());
            }
            Console.WriteLine();
        }
    }
}
