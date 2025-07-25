using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Activity_32
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Enter a capital letter (A-Z): ");
           char endLetter = Console.ReadLine().ToUpper()[0];

            if (endLetter < 'A' || endLetter > 'Z')
            {
              Console.WriteLine("Invalid input. Please enter a capital letter A-Z.");
              return;
            }
            for (char currentRow = 'A'; currentRow <= endLetter; currentRow++)
            {
            for (char ch = 'A'; ch <= currentRow; ch++)
            {
               Console.Write(ch);
            }
               Console.WriteLine();
            }
        }
    }
}


