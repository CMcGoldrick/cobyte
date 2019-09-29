using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CoByte
{
    class Easy
    {
        public static string LongestWord(string sen)
        {
            var nopunc = new string(sen.Where(c => !char.IsPunctuation(c)).ToArray());

            // remember " " this will error out because not char notation > ' '
            string[] array = nopunc.Split(' ').ToArray();
            int length = 0, longest = 0;

            for (var i = 0; i < array.Length; i++)
            {
                if (length < array[i].Length)
                {
                    length = array[i].Length;
                    longest = i;
                }
            }
            return array[longest];

            //string[] words = sen.Split(' ');
            //return words.OrderByDescending(s => s.Length).First(); ;
        }

        public static int FirstFactorial(int num)
        {
            int next = num - 1;
            int total = num * next;

            for (var i = 0; i < num - 2; i++)
            {
                next -= 1;
                total *= next;
            }
            return total;

            //if (num < 1)
            //{
            //    return 1;
            //}
            //if (num > 1)
            //{
            //    return num * FirstFactorial(--num);
            //}
            //return num;
        }

        public static string FirstReverse(string str)
        {
            char[] chararry = str.ToCharArray();
            Array.Reverse(chararry);
            string reversed = new string(chararry);

            return reversed;
        }

        public static string LetterChanges(string str)
        {
            List<char> nextList = new List<char>();

            foreach (var x in str)
            {
                if (x == 'z')
                    nextList.Add('a');
                else if (x == ' ')
                    nextList.Add(' ');
                else if (Char.IsPunctuation(x))
                    nextList.Add(x);
                else if (x == 'Z')
                    nextList.Add('A');
                else
                    nextList.Add((char)(((int)x) + 1));
            }

            char[] vowelArray = new char[5] { 'a', 'e', 'i', 'o', 'u' };

            var nextArray = nextList.Select(c => vowelArray.Contains(c) ? char.ToUpper(c) : c).ToArray();

            string charstring = new string(nextArray);
            return charstring;
        }

        public static int SimpleAdding(int num)
        {
            int total = 0;
            int iteration = num;

            for (var i = 0; i < iteration; i++)
            {
                total += num;
                num--;
            }

            return total;
        }

        public static string LetterCapitalize(string str)
        {
            string[] strArray = str.Split();

            for(var i = 0; i < strArray.Length; i++)
            {
                strArray[i] = char.ToUpper(strArray[i][0]) + strArray[i].Substring(1);
            }
            string joined = string.Join(" ", strArray);
            return joined;
        }

        public static bool SimpleSymbols(string str)
        {
            bool test = true;
            char[] characters = str.ToCharArray();
            int i = 0;

            //get the type
            //Console.WriteLine(characters[i].GetType());

            // these are the characters included in the IsPunctuation() method
            //char[] possibilities = new char[] {  '!', '\\', '\'', '"', '#', '%', '&', '(', ')', '*', ',', '-', '.', '/', ',', ';', '?', '@', '[', ']', '_', '{', '}'};
       
            for (i =0; i < characters.Length; i++)
            {
                if(char.IsLetter(characters[0]) || char.IsNumber(characters[0]))
                {
                    if (characters[1] != '+')
                    {
                        test = false;
                        break;
                    } 
                }

                if(char.IsLetter(characters[characters.Length - 1]) || char.IsNumber(characters[characters.Length - 1]))
                {
                    if (characters[characters.Length -2] != '+')
                    {
                        test = false;
                        break;
                    }
                }

                if(characters[i] != characters[0] && characters[i] != characters[characters.Length - 1])
                {
                    if (char.IsLetter(characters[i]) || char.IsNumber(characters[i]))
                    {
                        if (characters[i - 1] != '+' || characters[i + 1] != '+')
                        {
                            test = false;
                            break;
                        }
                    }
                }
            }

            return test;

        }

        public static string RightPoint()
        {
            for (int i = 0; i<101; i++)
            {
                if(i % 3 == 0 && i % 5 == 0 )
                {
                    Console.WriteLine("rightpoint");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("right");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("point");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            return "completed";
        }

    }
}
 