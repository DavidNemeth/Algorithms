namespace QuickFind
{
    public class QuickFind
    {
        private int[] id;
        private int[] sz;

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
            //check if p and q are connected
            return Root(p) == Root(q);
        }

        public void QuickUnion(int p, int q)
        {
            //Compare the sizes and link the root of the smaller tree, to the bigger tree in each case.
            int i = Root(p);
            int j = Root(q);
            if (i == j)
            {
                return;
            }
            if (sz[i] < sz[j])
            {
                id[i] = j;
                sz[j] += sz[i];
            }
            else
            {
                id[j] = i;
                sz[i] += sz[j];
            }
        }

        private int Root(int i)
        {
            //Find the root of the item
            while (i != id[i])
            {
                id[i] = id[id[i]];
                i = id[i];
            }
            return i;
        }
    }
}