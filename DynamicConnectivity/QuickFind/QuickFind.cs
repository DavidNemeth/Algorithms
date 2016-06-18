namespace QuickFind
{
    public class QuickFind
    {
        private int[] id;

        public QuickFind(int n)
        {
            id = new int[n];
            for (int i = 0; i < n; i++)
            {
                id[i] = i;
            }
        }

        public bool Connected(int p, int q)
        {
            return id[p] == id[q];
        }        

        public void Union(int p, int q)
        {
            int i = Root(p);
            int j = Root(q);
            id[i] = j;
        }

        private int Root(int i)
        {
            while (i != id[i])
            {
                i = id[i];
            }
            return i;
        }
    }
}