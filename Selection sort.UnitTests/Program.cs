using System;

namespace Selection_sort
{
    class Program
    {
        public static void Sort(int[] v, bool asc = true)
        {
            int l = v.Length;
            for (int i = 0; i < l - 1; ++i)
            {
                int indexToSwap = i;
                for (int j = i + 1; j < l; ++j)
                    if (v[indexToSwap] > v[j] && asc || v[indexToSwap] < v[j] && !asc)
                        indexToSwap = j;
                int aux = v[indexToSwap];
                v[indexToSwap] = v[i];
                v[i] = aux;
            }
        }
    }
}
