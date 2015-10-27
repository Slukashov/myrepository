using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace palidrom
{
    class Program
    {
        public static bool Palyndrom(int _number)
        {kdsjfhskjdfhksdjfhjksdhfjkj
            int next = 0;
            int pal = _number;
            while (pal != 0)
            {
                next = (next*10) + (pal%10);
                pal /= 10;
            }
            if (_number == next)
                return true;
            else return false;
        }

        static void Main(string[] args)
        {
            List<int> masInts = new List<int>();
            for (int i = 100; i < 999; i++)
            {
                for (int j = 999; j >= i+1; j--)
                {
                    if (Palyndrom(i*j))
                        masInts.Add(i * j); 
                }
            }
            masInts.Sort();
            Console.WriteLine(masInts[masInts.Count-1]);
        }
    }
}
