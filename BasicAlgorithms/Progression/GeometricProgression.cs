using System;
using System.Collections.Generic;
using System.Linq;
namespace Progression
{
    public class GeometricProgression : BProgression
    {
        protected long nbase;

        public GeometricProgression()
            : this(2, 1)
        {
        }
        public GeometricProgression(long b)
            : this(b, 1)
        {
        }
        public GeometricProgression(long b, long start)
            : base(start)
        {
            nbase = b;
        }

        protected override void Advance()
        {
            current *= nbase;
        }
    }
}
