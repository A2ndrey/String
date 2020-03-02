using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            // char
            // IsCharDigit();
            // part_of_alphabet();
            //part_of_alphabet(false);
            change_char_case();

            Console.ReadKey();
        }

        private static void change_char_case()
        {
            const int code = 32;

            char c = Convert.ToChar(Console.ReadLine());
            if (((char)c >= 97) && ((char)c <= 122))
            {
                Console.WriteLine((char)(c - code));
            }
            else
            { Console.WriteLine((char)(c + code)); }
        }

        private static void part_of_alphabet(bool fromstart = true)
        {
            char c = Convert.ToChar(Console.ReadLine());
            char startchar = fromstart ? 'a' : c;
            char endchar = fromstart ? c : 'z';

            for (char a = startchar; a <= endchar; a++)
            {
                Console.Write(a + " ");
            }

        }

        private static void IsCharDigit()
        {
            int c = Convert.ToChar(Console.ReadLine());

            if (c >= '0' && c <= '9') { Console.WriteLine("YES"); }
            else { Console.WriteLine("NO"); }

        }
    }
}
