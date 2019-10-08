using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymetricMatrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matrix = new int[, ] { { 1, 0, 1 },
                                          { 0, 2, 2 },
                                          { 1, 2, 5 }
            };

            Console.WriteLine(IsSymetric(matrix));
            Console.ReadLine();
        }

        public static bool IsSymetric(int[,] inputMatrix)
        {
          
            for (int i = 0; i < inputMatrix.GetLength(0)-1; i++)        // -1 due to the index bounds
            {
                if (inputMatrix[i, (i + 1)] != inputMatrix[(i + 1), i])
                {
                    return false;
                }
            }
            return true;
        }
    }

}
