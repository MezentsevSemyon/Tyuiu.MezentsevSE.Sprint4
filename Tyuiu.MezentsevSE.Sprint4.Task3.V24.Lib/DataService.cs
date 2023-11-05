using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MezentsevSE.Sprint4.Task3.V24.Lib
{
    public class DataService : ISprint4Task3V24
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int colu = array.Length / rows;

            int res = 100;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colu; j++)
                {
                    if (j == 1)
                    {
                        if (array[i, j] < res)
                        {
                            res = array[i, j];
                        }
                    }
                }
            }
            return res;
        }
    }
}
