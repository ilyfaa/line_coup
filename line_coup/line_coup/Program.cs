using System;

namespace line_coup
{
    class Program
    {
        static string coup(string str)
        {
            try
            {


                char[] letters = new char[str.Length];
                int j = str.Length - 1;
                char o = 'h';
                for (int i = 0; i < letters.Length; i++)
                {
                    letters[i] = str[i];
                }
                if (str.Length % 2 == 0)
                {
                    for (int i = 0; i < str.Length / 2; i++, --j)
                    {
                        o = letters[i];
                        letters[i] = letters[j];
                        letters[j] = o;
                    }
                }
                else
                {
                    for (int i = 0; i < (str.Length / 2) + 1; i++, --j)
                    {
                        o = letters[i];
                        letters[i] = letters[j];
                        letters[j] = o;
                    }
                }
                string endstring = "";
                for (int i = 0; i < str.Length; i++)
                {
                    endstring += letters[i];
                }

                return endstring;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error {0}",ex.ToString());
                return "";
            }
        }
    static void Main(string[] args)
        {
            Console.Write("Enter the rate for the coup: ");
            Console.WriteLine(coup(Console.ReadLine()));
            Console.ReadKey();
            
        }
    }
}
