using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexLibrary
{
    public class Toolbox
    {
        public static List<double> ListMultiplication(List<double> ListOne, List<double> ListTwo)
        {
            List<double> result = new List<double>();
            int count = 0;

            foreach (var item in ListOne)
            {
                result.Add(item * ListTwo[count]);
                count++;
                continue;
            }
            return result;
        }
    }
}
