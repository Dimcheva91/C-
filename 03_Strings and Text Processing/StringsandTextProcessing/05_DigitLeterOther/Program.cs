using System;
using System.Text;

namespace _05_DigitLeterOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine() ?? "";
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder others = new StringBuilder();

            foreach (var index in input)
            {
                if (char.IsDigit(index))
                {
                    digits.Append(index);
                }
                else if (char.IsLetter(index))
                {
                    letters.Append(index);
                }
                else
                {
                    others.Append(index);
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}