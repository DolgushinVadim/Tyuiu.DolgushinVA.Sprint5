using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.DolgushinVA.Sprint5.Task5.V19.Lib
{
    public class DataService : ISprint5Task5V19
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            double min = 100000;
            double max = -100000;
            double n;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    n = Convert.ToDouble(line);
                    if ((n < 10) && (n > -10) && (n % 1 == 0))
                    {
                        if (n > max)
                        {
                            max = n;
                        }
                        if (n < min)
                        {
                            min = n;
                        }
                    }
                }
                res = Math.Round((max - min), 3);
            }
            return res;
        }
    }

}
