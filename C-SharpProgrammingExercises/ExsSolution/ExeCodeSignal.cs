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
    }
}
