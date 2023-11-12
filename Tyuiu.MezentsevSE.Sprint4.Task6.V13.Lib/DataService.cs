using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MezentsevSE.Sprint4.Task6.V13.Lib
{
    public class DataService : ISprint4Task6V0

    {
        public int Calculate(string[] array)
        {
            string[] mass = Array.FindAll(array, c => c.Length > 4);
            return mass.Length;
        }
    }
}
