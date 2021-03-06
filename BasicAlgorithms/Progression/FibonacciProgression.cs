﻿namespace Progression
{
    public class FibonacciProgression : BProgression
    {
        protected long prev;
        public FibonacciProgression()
            :this(0,1)
        {
        }
        public FibonacciProgression(long first, long second)
            :base(first)
        {
            prev = second - first;
        }

        protected override void Advance()
        {
            long temp = prev;
            prev = current;
            current += temp;
        }
    }
}
