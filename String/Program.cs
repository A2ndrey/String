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
            // change_char_case();

            // string
            //CountWordInString();
            //ReverseString();
            //DeCharFromString();
            //x_or_w_earlierinstring();
            //IsPolindrom();
            //DuplicateChar();
            //IsIdentificator();
            //NormalString();
            //ksymbolinstring();
            //berweenchar();
            //initials();
            // lastchar_s_equal_firstchar_s2();
            // countvowel();
            // etoi();
            digitinstring();

            Console.ReadKey();
        }

        private static void digitinstring()
        {
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
                if ((s[i] >= '0') && (s[i] <= '9')) { Console.Write(s[i] + " "); }
        }

        private static void etoi()
        {
            string s = Console.ReadLine();
            s = s.Replace('e', 'i');
            Console.WriteLine(s);
        }

        private static void countvowel()
        {
            string s = Console.ReadLine();
            var count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] == 'a') || (s[i] == 'e') || (s[i] == 'i') || (s[i] == 'o') || (s[i] == 'u'))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        private static void lastchar_s_equal_firstchar_s2()
        {
            string s = Console.ReadLine();
            string s2 = Console.ReadLine();

            char fs = s[0];
            char fs2 = s2[s2.Length - 1];

            Console.WriteLine(fs == fs2 ? "YES" : "NO");
        }

        private static void initials()
        {
            string surname = Console.ReadLine();
            string name = Console.ReadLine();
            string secondname = Console.ReadLine();

            char short_name = name[0];
            char short_secondname = secondname[0];

            Console.WriteLine($"{surname} {short_name}. {short_secondname}.");
        }

        private static void berweenchar()
        {
            char a = Convert.ToChar(Console.ReadLine());
            char b = Convert.ToChar(Console.ReadLine());

            char startchar = b;
            char finishchar = a;

            if (a < b)
            {
                startchar = a;
                finishchar = b;
            }

            for (char c = startchar; c <= finishchar; c++)
                Console.Write(c + " ");
        }


        private static void ksymbolinstring()
        {
            string s = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());
            if (k > s.Length) { Console.WriteLine("NO"); }
            else { Console.WriteLine(s[k]); }
        }

        private static void NormalString()
        {
            var space = ' ';
            var newstring = "";
            int j = 0;

            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                if ((j > 0) && (s[i] == space) && (newstring[j - 1] == space))
                {
                    continue;
                }
                newstring += s[i];
                j++;
            }

            Console.WriteLine(newstring);
        }

        private static void IsIdentificator()
        {
            const int FirstABC = 97;
            const int LastABC = 122;
            const int FirstDigit = 48;
            const int LastDigit = 57;

            string ident = Console.ReadLine();
            ident = ident.ToLower();

            bool result = false;

            for (int i = 0; i < ident.Length; i++)
            {
                if (i == 0)
                {
                    if ((ident[i] == '_') || ((ident[i] >= FirstABC) && (ident[i] <= LastABC)))
                        result = true;
                    else { result = false; break; };
                }
                else
                {
                    if ((ident[i] == '_') || ((ident[i] >= FirstABC) && (ident[i] <= LastABC))
                         || ((ident[i] >= FirstDigit) && (ident[i]) <= LastDigit))
                    {
                        result = true;
                    }
                    else { result = false; break; };
                }
            }
            Console.WriteLine(result);
        }

        //ачинается ли оно с английской буквы в любом регистре или знака подчеркивания
        //    и не содержит других символов, кроме букв английского алфавита(в любом регистре), цифр и знака подчеркивания.

        private static void DuplicateChar()
        {   // abcdeb
            string s = Console.ReadLine();

            for (int i = 0; i < s.Length; i++)
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j]) { Console.WriteLine(s[i]); return; }
                }
        }

        private static void IsPolindrom()
        {
            string s = Console.ReadLine();
            string s2 = "";

            for (int i = s.Length - 1; i >= 0; i--)
            {
                s2 += s[i];
            }

            Console.WriteLine(s == s2 ? "YES" : "NO");
        }

        private static void x_or_w_earlierinstring()
        {
            string result = "-1";
            string s = Console.ReadLine();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'x') { result = "x"; break; }
                else if (s[i] == 'w') { result = "w"; break; }
            }

            Console.WriteLine(result);


        }

        private static void DeCharFromString()
        {
            const int dellength = 1;
            string s = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());
            string s2 = "";
            //s = s.Remove(k, dellength);
            k--;
            for (int i = 0; i < s.Length; i++)
            {
                if (i == k) { continue; }
                s2 += s[i];
            }


            Console.WriteLine(s2);

        }

        private static void ReverseString()
        {
            string s = Console.ReadLine();
            int length = s.Length;

            for (int i = length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }

        }

        private static void CountWordInString()
        {
            string s = Console.ReadLine();
            int length = s.Length;
            int count = 0;

            for (int i = 0; i < length; i++)
            {
                if (s[i] == ' ')
                {
                    count++;
                }
            }

            Console.WriteLine(count + 1);
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
