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

            for(var i=0; i < array.Length; i++)
            {
                if(length < array[i].Length)
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

            for (var i=0; i <num -2; i++)
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
                else if (Char.IsPunctuation(x))
                    nextList.Add(x);
                else if (x == 'Z')
                    nextList.Add('A');
                else
                   nextList.Add((char)(((int)x) + 1));
            }

            //List<char> vowelList = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            char[] vowelArray = new char[5] { 'a', 'e', 'i', 'o', 'u' };

            foreach(var x in nextList)
                Console.WriteLine(x);

            //foreach (char x in nextList)
            //{
            //    if (vowelArray.Contains(x))
            //    {
            //        Char.ToUpper(x);
            //    }
            //}

            return str;

        }

    }
}
