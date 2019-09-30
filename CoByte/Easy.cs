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

            // remember ' " this will error out because not char notation > ' '
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

        public static string CheckNums(int num1, int num2)
        {
            string result = "true";
            if (num1 > num2)
            {
                result = "false";
                return result;
            }
            if (num1 == num2)
            {
                result = "-1";
                return result;
            }

            return result;
        }

        public static string TimeConvert(int num)
        {
            int remainder = num % 60;
            int hours = (num - remainder) / 60;

            return $"{hours}:{remainder}";
        }

        public static string AlphabetSoup(string str)
        {
            string ordered = String.Concat(str.OrderBy(c => c));
            return str;
        }

        public static string ABCheck(string str)
        {
            string result = "false";
            char[] array = str.ToCharArray();
            
            for (int i = 0; i < array.Length - 4; i++)
            {
                if (array[i] == 'a' && (array[i + 4]) == 'b')
                {
                    return result = "true";
                }
            }

            return result;
        }

        public static int VowelCount(string str)
        {
            int vowels = 0;
            char[] vow = new char[] { 'a', 'e', 'o', 'u', 'i', 'A', 'E', 'O', 'U', 'I' };

            foreach(var x in str)
            {
                if (vow.Contains(x))
                {
                    vowels++;
                }
            }
            return vowels;
        }

        public static int WordCount(string str)
        {
            var array = str.Split(" ");
           
            return array.Length;
        }

        public static string ExOh(string str)
        {
            string result = "false";
            int x = 0, o = 0;

            char[] characters = str.ToCharArray();

            foreach(char i in characters)
            {
                if (i == 'x')
                    x++;
                if (i == 'o')
                    o++;
            }

            if (x == o)
                return result = "true";

            //return str.Count(x => x == 'x') == str.Count(x => x == 'o') ? "true" : "false";
            return result;
        }

        public static string Palindrome(string str)
        {
            string result = "true";

            //regex to trim a string from punctuation and spaces
            string trimmed = System.Text.RegularExpressions.Regex.Replace(str, @"[^\w]", string.Empty);

            char[] inputarray = trimmed.ToCharArray();
            char[] reversed = new char[inputarray.Length];
            int j = 0;
            int l = inputarray.Length;

            for(int i = l-1; i >= 0; i--)
            {
                reversed[j] = inputarray[i];
                j++;
            }

            for (int i = 0; i < l; i++)
            {
                if (inputarray[i] != reversed[i])
                {
                    return result = "false";
                }
            }
            return result;
        }

        public static string ArithGeo(int[] arr)
        {
            int l = arr.Length, j = 1;
            bool aritmethic = true, geometric = true;
            string returnString = String.Empty;
            int difference = arr[1] - arr[0], multiplication = arr[1] / arr[0]; ;

            for(int i = 0; i<l-1; i++)
            {
                if(arr[j] - arr[i] != difference)
                {
                    aritmethic = false;
                }
                if(arr[j] / arr[i] != multiplication)
                {
                    geometric = false;
                }
                j++;
            }

            if(aritmethic) { returnString = "Arithmetic"; }
            else if(geometric) { returnString = "Geometric"; }
            else { returnString = "-1"; }

            return returnString;
        }

        public static string ArrayAdditionI(int[] arr)
        {
            int largest = arr.Max();
            int index = arr.ToList().IndexOf(largest);
            List<int> countList = arr.ToList();
            countList.RemoveAt(index);




            string returnString = String.Empty;



            return returnString;
        }


    }
}
  