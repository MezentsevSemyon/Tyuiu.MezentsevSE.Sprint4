using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MezentsevSE.Sprint4.Task4.V4.Lib
{
    public class DataService : ISprint4Task4V4
    {
        public int[,] Calculate(int[,] matrix)
        {
            int res;
            int rows = matrix.GetUpperBound(0) + 1;
            int col = matrix.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i, j] % 2 != 1)
                    {

                        matrix[i, j] = 1;
                        
                        
                    }
                }
            }
            return  matrix;
        }
    }
}
