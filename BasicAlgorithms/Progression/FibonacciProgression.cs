using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progression
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
