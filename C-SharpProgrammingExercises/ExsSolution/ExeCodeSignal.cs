using System.Collections.Generic;
using System.Linq;
namespace ExsSolution
{
    class ExeCodeSignal
    {
        public static int[][] Revers(int[][] matric)
        {
            //     Exercises 1
            //    You are given an n x n 2D matrix that represents an image.
            //    Rotate the image by 90 degrees(clockwise).
            if (matric.LongCount() == 1) return matric;
            int leng = matric.Length;
            int[][] @new = new int[leng][];
            int i = 1;
            int j = 0;
            foreach (var t in matric)
            {
                matric.Aggregate(new int[leng], (a, b) => { a[leng - i++] = b[j]; return a; }, k => { i = 1; return @new[j++] = k; });
            }

            return @new;
        }
        //     Exercises 2
        //    Ratiorg got statues of different sizes as a present from CodeMaster for his birthday, 
        //    each statue having an non-negative integer size. Since he likes to make things perfect, 
        //    he wants to arrange them from smallest to largest so that each statue will be bigger than the previous one exactly by 1. 
        //    He may need some additional statues to be able to accomplish that. 
        //    Help him figure out the minimum number of additional statues needed.

        public static int MakeArrayConsecutive2(int[] statues)
        {
            int count = 0;
            int min = statues.Min();
            int max = statues.Max();
            while (max != min)
            {
                min++;
                if (!statues.Contains(min)) count++;

            }
            return count;
        }
        //     Exercises 3
        // Given a sequence of integers as an array, determine 
        // whether it is possible to obtain a strictly increasing sequence
        // by removing no more than one element from the array.

        //Note: sequence a0, a1, ..., an is considered to be a strictly
        //increasing if a0<a1< ... < an.Sequence containing only one 
        //element is also considered to be strictly increasing.

        public static bool Issort(int[] a)
        {
            bool s = false;

            bool IsSorted(int[] b)
            {
                bool x = true;
                b.Aggregate((d, c) => { x = x && d < c; return c; });
                return x;
            }

            for (int i = 0; i < a.Length; i++)
            {
                List<int> temp = a.ToList();
                temp.RemoveAt(i);
                s = s || IsSorted(temp.ToArray());

            }

            return s;
        }
    }
}
