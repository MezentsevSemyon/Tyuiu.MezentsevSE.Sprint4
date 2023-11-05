using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MezentsevSE.Sprint4.Task0.V26.Lib
{
    public class DataService : ISprint4Task0V26
    {
        public int GetSumOddArrEl(int[] array)
        {
            int i;
            int count = 0;
            for (i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 != 0)
                {
                    count += array[i];
                }
            }
            return count;
        }
    }
}
