using System.Text;

namespace _02_RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ");
            StringBuilder output = new();

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                for (int j = 0; j < currentWord.Length; j++)
                {
                    output.Append(currentWord);
                }
            }

            Console.WriteLine(output);

        }
    }
}