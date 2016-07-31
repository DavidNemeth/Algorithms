namespace Progression
{
    public class ArithmeticProgression : BProgression
    {
        protected long increment;

        public ArithmeticProgression()
            : this(1, 0)
        {
        }
        public ArithmeticProgression(long stepsize)
            : this(stepsize, 0)
        {
        }
        public ArithmeticProgression(long stepsize, long start)
            : base(start)
        {
            increment = stepsize;
        }

        protected override void Advance()
        {
            current += increment;
        }
    }
}
