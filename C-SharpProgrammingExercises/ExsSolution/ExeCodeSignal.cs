using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExsSolution
{
    class ExeCodeSignal
    {
        public static int[][] Revers(int[][] matric)
        {
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
    }
}
