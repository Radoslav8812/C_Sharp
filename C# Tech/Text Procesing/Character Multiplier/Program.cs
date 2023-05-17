using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ");

            for (int i = 0; i < input.Length; i++)
            {
                var currentText = input[i];

                bool isValidLength = true;
                bool isCaseValid = true;

                if (currentText.Length < 3 || currentText.Length > 16)
                {
                    isValidLength = false;
                }

                for (int j = 0; j < currentText.Length; j++)
                {
                    char currentSymbol = currentText[j];

                    if (!char.IsLetterOrDigit(currentSymbol) && currentSymbol != '-' && currentSymbol != '_')
                    {
                        isCaseValid = false;
                        break;
                    }
                }

                if (isValidLength && isCaseValid)
                {
                    Console.WriteLine(currentText);
                }
            }
        }
    }
}


