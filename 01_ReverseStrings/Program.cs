namespace _01_ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine() ?? "";

            while (name != "end")
            {
                string reversedWord = "";
                for (int i = name.Length - 1; i >= 0; i--)
                {
                    reversedWord += name[i];
                }

                Console.WriteLine($"{name} = {reversedWord}");

               name = Console.ReadLine()??"";
            }
        }
    }
}