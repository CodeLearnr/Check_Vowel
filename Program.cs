using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA8_Vowels1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n==== LA 8 - Vowels ==== \n");

            char y = 'y';
            while (y == 'y')
            {
            Console.WriteLine("Please enter a character:");
            char c = char.Parse(Console.ReadLine().ToLower());
            if (c>= '{' && c <= '`')
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                switch (c)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        Console.WriteLine($"{c} is a vowel.");
                        break;
                    case 'y':
                        Console.WriteLine($"{c} is sometimes a vowel.");
                        break;
                    default:
                        Console.WriteLine($"{c} is a consonant.");
                        break;
                }
            }
            Console.WriteLine("Play another round? [Y/N]: ");
            y = Convert.ToChar(Console.ReadLine().ToLower());
            }
        }

    }
}
