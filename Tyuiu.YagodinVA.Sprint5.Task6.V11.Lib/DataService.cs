using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.YagodinVA.Sprint5.Task6.V11.Lib
{
    public class DataService : ISprint5Task6V11
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = new string(line.Where(c => !char.IsPunctuation(c)).ToArray());
                    string[] subs = line.Split(' ');
                    foreach (string element in subs)
                    {
                        if (element.Length == 6)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
