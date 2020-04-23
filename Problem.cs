using System;
using System.Collections.Generic;
using System.Text;

namespace TargetProject
{
    public class Problem
    {
        // Problema este ca se dau 3 numere si un string, numarul z trebuie sa fie un numar perfect iar x si y trebuie sa fie mai mari ca zero
        // Se calculeaza produsul lui x si y dupa care se afla cel mai mare divizor prim al numarului urmand sa se aplice instructiunea primita ca parametru intre z si numarul care reiese
        public float function(int x, int y, int z, String instruction)
        {
            int s = 1;
            int prod = 1;
            for (int i = 2; i <= z / 2; i++)
            {
                if (z % i == 0)
                {
                    s += i;
                }
            }

            if (x > 0 && y > 0)
            {
                prod = x * y;
            }
            else
            {
                //Console.WriteLine("X si Y trebuie sa fie mai mari ca 0.");
                return -2;
            }

            for (int i = 2; i <= prod / 2; i++)
            {
                if (prod % i == 0)
                {
                    prod = prod / i;
                    i = 1;
                }
            }

            if (s == z && prod > 1)
            {
                switch (instruction)
                {
                    case "add":
                        return z + prod;
                    case "subtract":
                        return z - prod;
                    case "multiply":
                        return z * prod;
                    case "divide":
                        return z / prod;
                    default:
                        Console.WriteLine("Instructiune incorecta.");
                        return -1;
                }
            }
            Console.WriteLine("Eroare.");
            return -1;
        }
    }
}
