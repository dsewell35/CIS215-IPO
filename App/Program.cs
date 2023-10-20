using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;

namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Output.Line("Enter Input: ");
            var inp = Console.ReadLine();
            Console.SetIn(new StreamReader(Console.OpenStandardInput(2048)));
            int WordCnt, CharCnt, NumCnt, SpecCnt;
            /********************** DO NOT EDIT ABOVE THIS LINE **********************************/


            //Variable Initialization
            int lettrCnt = 0;
            int sentCnt = 0;
            double wrdsPrCnt = 0;
            double charPrCnt = 0;
            CharCnt = 0;
            NumCnt = 0;
            SpecCnt = 0;
            WordCnt = 0;



            ///<summary>
            ///This block takes the users input and counts the number
            ///Of Characters in the input by stepping through it as an array
            ///And also assigns the var variable c to each character input in the array
            ///The if loop then compares the variable to known values in order
            ///To increase specific counts
            /// </summary>
            for (int i = 0; i < inp.Length; i++)
            {
                var c = inp[i];
                CharCnt++;
                if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z')
                {
                    lettrCnt++;
                }
                else if (c >= '0' && c <= '9')
                {
                    NumCnt++;
                }
                else if (c != ' ')
                {
                    SpecCnt++;
                }
            }
            ///<summary>
            ///This block parses the user input
            ///Then splits the string into a string array
            ///At each whitespace character
            /// The for loop then steps through the array
            /// Counting the number of words in the array
            /// </summary>
            string[] words = inp.Split(null);
            for (int i = 0; i < words.Length; i++)
            {
                WordCnt++;
            }

            ///<summary>
            ///This block delimits sentence ending characters
            ///then splits the string where the delimiters end
            ///The For loop then steps through the array
            ///Adding to the total of sentence count with each iteration
            /// <summary>


            char[] delimit = { '.', '!', '?' };
            string[] sentences = inp.Split(delimit);
            for (int i = 1; i < sentences.Length; i++)
            {
                sentCnt++;
            }

            //Calculations
            wrdsPrCnt = (double)WordCnt / (double)sentCnt;
            charPrCnt = (double)CharCnt / (double)sentCnt;

            //Output section
            Console.WriteLine("Word Count: " + WordCnt);
            Console.WriteLine("Sentence Count: " + sentCnt);
            Console.WriteLine("Words Per Sentence: " + string.Format("{0:0.000}", wrdsPrCnt)); //Narrows percision to 3 places
            Console.WriteLine("Character Count: " + CharCnt);
            Console.WriteLine("Special Character Count: " + SpecCnt);
            Console.WriteLine("Characters Per Sentence: " + string.Format("{0:0.0000}", charPrCnt)); //Narrows percision to 4 places
            Console.WriteLine("Number Count: " + NumCnt);




            // THIS SHOULD BE THE LAST STATEMENT FOR MAIN
            Console.Read();
        }

    }
}
