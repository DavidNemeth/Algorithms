namespace QuickFind
{
    public class QuickFind
    {
        private int[] id;
        private int[] numberOfItem;

        public QuickFind(int n)
        {
            id = new int[n];
            for (int i = 0; i < n; i++)
            {
                id[i] = i;
            }
        }

        public bool Find(int p, int q)
        {
            return Root(p) == Root(q);
        }

        public void Union(int p, int q)
        {
            int i = Root(p);
            int j = Root(q);
            if (i == j)
            {
                return;
            }
            if (numberOfItem[i] < numberOfItem[j])
            {
                id[i] = j;
                numberOfItem[j] += numberOfItem[i];
            }
            else
            {
                id[j] = i;
                numberOfItem[i] += numberOfItem[j];
            }
        }

        private int Root(int i)
        {
            while (i != id[i])
            {
                id[i] = id[id[i]];
                i = id[i];
            }
            return i;
        }
    }
}