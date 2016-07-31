using System;

namespace Progression
{
    public abstract class BProgression
    {
        protected long current;

        public BProgression()
            : this(0)
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

        public void PrintProgression(int n)
        {
            Console.Write(NextValue());
            for (int i = 1; i < n; i++)
            {
                Console.Write(" " + NextValue());
            }
            Console.WriteLine();
        }

        protected abstract void Advance();
    }
}
