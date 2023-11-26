using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.YagodinVA.Sprint5.Task5.V10.Lib
{
    public class DataService : ISprint5Task5V10
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    int number;
                    if (int.TryParse(line, out number) && Convert.ToDouble(line) % 2 == 0)
                    {
                        res += Convert.ToDouble(line);
                    }
                }
            }
            return res;
        }
    }
}
