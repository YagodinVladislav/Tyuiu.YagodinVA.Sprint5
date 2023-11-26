using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.YagodinVA.Sprint5.Task7.V8.Lib
{
    public class DataService : ISprint5Task7V8
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = @"C:\DataSprint5\OutPutDataFileTask7V8.txt";
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            if (fileExists) File.Delete(pathSaveFile);
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                string new_str = "";
                string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (Char.IsUpper(line[i]) && alphabet.Contains(line[i]))
                        {
                            new_str += Char.ToLower(line[i]);
                        }
                        else
                        {
                            new_str += line[i];
                        }
                    }
                    File.WriteAllText(pathSaveFile, new_str);
                }
            }
            return pathSaveFile;
        }
    }
}
