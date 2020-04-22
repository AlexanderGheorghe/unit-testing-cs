﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = { 13, 1, 626, 21, 555, 23 };
            Sort(v, true);
            foreach (var n in v)
                Console.WriteLine(n.ToString());
            Sort(v, false);
            foreach (var n in v)
                Console.WriteLine(n.ToString());
        }

        static void Sort(int[] v, bool asc)
        {
            int l = v.Length;
            for (int i = 0; i < l-1; ++i)
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