using System;
using System.Linq;
using System.Text;

namespace CoderByte_LetterChanges
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using the C# language, have the function LetterChanges(str) take the str parameter being passed and modify it using the following algorithm.
            //Replace every letter in the string with the letter following it in the alphabet (ie. c becomes d, z becomes a). 
            //Then capitalize every vowel in this new string (a, e, i, o, u) and finally return this modified string. 

                                          
            Console.WriteLine(LetterChanges("Hello, my name is William."));
            Console.ReadLine();
        }

        public static string LetterChanges(string str)
        {

            var demStr = new StringBuilder();

            for (int i = 0; i < str.Count(); i++)
            {
                char v = (char)((int)str[i]);
                if (Char.IsLetter(v))
                {
                    var h = (char)((int)str[i] + 1);

                    if (h == 'a' || h == 'i' || h == 'e' || h == 'o' || h == 'u')
                    {
                        h = char.ToUpper(h);
                    }
                    if (h == '!')
                    {
                        h = ' ';
                    }
                    demStr.Append(h);
                }
                else { demStr.Append(v); }

            }
            str = demStr.ToString();
            return str;

        }

    }
}
