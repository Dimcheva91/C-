using System.Linq;

namespace _04_TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWord = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (string word in bannedWord)
            {
                if (text.Contains(word))
                {
                    text = text.Replace(word, new string('*', bannedWord.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}