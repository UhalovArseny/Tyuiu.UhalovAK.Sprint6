using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.UhalovAK.Sprint6.Task6.V14.Lib
{
    public class DataService : ISprint6Task6V14
    {
        public string CollectTextFromFile(string path)
        {
            StringBuilder resStr = new StringBuilder(); 
            using (StreamReader streamreader = new StreamReader(path))
            {
                string line;
                while ((line = streamreader.ReadLine()) != null)
                {
                    string[] array = line.Split(' ');
                    foreach (var word in array) 
                    {
                        if (word.Contains("z"))
                        {
                            resStr.Append(" ").Append(word); 
                        }
                    }
                }
            }

            return resStr.ToString().Trim();
        }
    }
}