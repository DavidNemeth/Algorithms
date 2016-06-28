

namespace StackAPI
{
    public class FixedCapacityStackOfStrings
    {
        private string[] s;
        private int N = 0;

        public FixedCapacityStackOfStrings(int capacity)
        {
            s = new string[capacity];
        }

        public bool isEmpty()
        {
            return N == 0;
        }

        public void Push(string item)
        {
            s[N++] = item;
        }

        public string pop()
        {
            return s[--N];
        }
    }
}
