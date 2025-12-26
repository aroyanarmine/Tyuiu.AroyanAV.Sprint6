using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AroyanAV.Sprint6.Task6.V29.Lib
{
    public class DataService : ISprint6Task6V29
    {
        public string CollectTextFromFile(string path)
        {
            string text = File.ReadAllText(path);

            string[] words = text.Split(
                new char[] { ' ', '\n', '\r', '\t' },
                StringSplitOptions.RemoveEmptyEntries);

            StringBuilder result = new StringBuilder();

            foreach (string word in words)
            {
                if (word.Contains('i'))
                {
                    result.Append(word);
                    result.Append(' ');
                }
            }

            return result.ToString().TrimEnd();
        }
    }
}