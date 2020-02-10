using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            PrintPattern(n);
            Console.WriteLine();

            int n2 = 6;
            PrintSeries(n2);
            Console.WriteLine();
            Console.WriteLine();

            string s = "09:15:35PM";
            string t = UsfTime(s);
            Console.WriteLine(t);
            Console.WriteLine();

            int n3 = 110;
            int k = 11;
            UsfNumbers(n3, k);

            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            PalindromePairs(words);

            int n4 = 5;
            Stones(n4);


        }
        /* I have used try and catch for all the methods. Try will execute when it gets an
         * expected value and catch will execute when it gets an unexpected value*/
        private static void PrintPattern(int n)
        {
            try
            { /* I have taken a nested for loop, the first for loop would generate n number of
                iterations.*/
                for (int i = n; i >= 1; i--)

                {
                    /* This second loop would print each row from j to 1. In each iteration,
                    Value of j would decrease.*/
                    for (int j = i; j >= 1; j--)
                    {
                        Console.Write(j);
                    }
                    // This statement is generating each iteration in a new line.
                    Console.WriteLine();
                }

            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printPattern");
            }
        }
        private static void PrintSeries(int n2)
        {
            try
            { // I have used the for loop for generating iteration till the value of n2.
                int sum = 0;
                for (int i = 1; i <= n2; i++)
                {
                    //sum is used to store the value of sum with addition of i.
                    sum = sum + i;
                    Console.Write(sum);
                    /* If the value of n2 is greater then i, then it will include a comma.
                     When i gets bigger than n2, it would not include a comma which is not
                     required after the last number gets printed.*/
                    if (i < n2)
                    {
                        Console.Write(",");

                    }
                }

            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printSeries");
            }
        }


        public static string UsfTime(string s)
        {
            try
            {
                /*Conversion of the the time in 24 hours format 
                 and then calculation of the
                 total seconds is done and the mathematical formula is
                 used for finding the hours, minutes and 
                 seconds.*/
                DateTime Date = Convert.ToDateTime(s);
                string Time = Date.ToString("HH:mm:ss");
                double Seconds = ((TimeSpan.Parse(Time).TotalSeconds));
                int h = 60 * 45;
                int m = 45;
                double hours = Math.Floor(Seconds / h);
                double minutes = Math.Floor((Seconds / m) % 60);
                int seconds = Convert.ToInt32(Seconds % 45);
                Console.WriteLine(hours + ":" + minutes + ":" + seconds);
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing UsfTime");
            }
            return null;
        }


        public static void UsfNumbers(int n3, int k)
        {
            try
            {
                // This for loop is used for generating iteration till n3.
                for (int b = 1; b <= n3; b += k)
                {
                    int g = b;
                    // Inner loop is to print the number(user defined) of unique words each line. 
                    for (int i = 1; i <= k; i++)
                    {
                        // Taken if cases for generating the unique series
                        if (g % 3 == 0 && g % 5 != 0 && g % 7 != 0)
                        {
                            Console.Write("U" + " ");
                        }
                        if (g % 5 == 0 && g % 3 != 0 && g % 7 != 0)
                        {
                            Console.Write("S" + " ");
                        }
                        if (g % 7 == 0 && g % 5 != 0 && g % 3 != 0)
                        {
                            Console.Write("F" + " ");
                        }
                        if (g % 3 == 0 && g % 5 == 0 && g % 7 != 0)
                        {
                            Console.Write("US" + " ");
                        }
                        if (g % 7 == 0 && g % 5 == 0 && g % 3 != 0)
                        {
                            Console.Write("SF" + " ");
                        }
                        if (g % 3 == 0 && g % 7 == 0 && g % 5 != 0)
                        {
                            Console.Write("UF" + " ");
                        }
                        if (g % 3 == 0 && g % 7 == 0 && g % 5 == 0)
                        {
                            Console.Write("USF" + " ");
                        }
                        if (g % 3 != 0 && g % 7 != 0 && g % 5 != 0)
                        {
                            Console.Write(g + " ");
                        }
                        g++;
                    }
                    Console.WriteLine();
                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }
        }
        public static void PalindromePairs(string[] words)
        {
            try
            {
                // This loop is used for generating a word at one time.  
                for (int x = 0; x < words.Length; x++)
                {
                    /* The inner loop is used for matching each word with the word 
                       picked at the outer loop for palindrome check.*/
                    for (int y = 0; y < words.Length; y++)
                    {
                        if (y != x)
                        {
                            string z = words[x] + words[y];
                            // Changing the words to characters.
                            char[] chars = z.ToCharArray();
                            // Empty array of character contains the length of word.
                            char[] result = new char[chars.Length];
                            // This for loop is used for reversing the characters of a word.
                            for (int i = 0, jm = chars.Length - 1; i < chars.Length; i++, jm--)
                            {
                                result[i] = chars[jm];
                            }
                            string com = new string(result);
                            // Here, comparison for the pallindrome check is done.
                            if (z == com)
                            {
                                Console.WriteLine(x + "," + y + " is pallindrome");
                            }

                        }
                    }
                }
            }
            catch
            {

                Console.WriteLine("Exception occured while computing PalindromePairs()");
            }
        }

        public static void Stones(int n4)
        {
            try
            {
                if (n4 % 4 == 0)
                {
                    Console.WriteLine("You can not win");
                }
                else if (n4 < 4)
                {
                    Console.WriteLine(n4);
                }
                else
                {
                    int t = n4 % 4;
                    for (int i = 1; i < 4; i++)
                    {
                        int rt = n4 - (t + i);
                        Console.Write("[" + t + "," + i + "," + rt + "] ");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Stones()");
            }
        }

    }

}
