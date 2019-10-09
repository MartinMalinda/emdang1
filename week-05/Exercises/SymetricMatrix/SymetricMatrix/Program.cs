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

            int[,] matrix2 = new int[,] { { 1, 0, 1, 2 },
                                          { 0, 2, 2, 3 },
                                          { 1, 2, 5, 4 },
                                          { 2, 2, 5, 3 }
            };

            Console.WriteLine(IsSymetric(matrix2));
            Console.ReadLine();
        }

        public static bool IsSymetric(int[,] inputMatrix)
        {
          
            for (int i = 1; i < inputMatrix.GetLength(0); i++)        // -1 due to the index bounds
            {
                if (inputMatrix[0, i] != inputMatrix[i, 0])
                {
                    return false;
                }
            }
            return true;
        }
    }

}
