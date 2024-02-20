namespace _03_Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine() ?? "";
            string text = Console.ReadLine() ?? "";

            while (text.Contains(wordToRemove))
            {
                //int indexOfWord = text.IndexOf(wordToRemove);
                //text = text.Remove(indexOfWord, wordToRemove.Length);

                 text = text.Replace(wordToRemove, "");
            }

            Console.WriteLine(text);
        }
    }
}