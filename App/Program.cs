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

            int lettrCnt = 0;
            int sentCnt = 0;
            double wrdsPrCnt = 0;
            double charPrCnt = 0;
            CharCnt = 0;
            NumCnt = 0;
            SpecCnt = 0;
            WordCnt = 0;



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

            string[] words = inp.Split(null);
            for (int i = 0; i < words.Length; i++)
            {
                WordCnt++;
            }


            char[] delimit = { '.', '!', '?' };
            string[] sentences = inp.Split(delimit);
            for (int i = 1; i < sentences.Length; i++)
            {
                sentCnt++;
            }

            wrdsPrCnt = (double)WordCnt / (double)sentCnt;


            Console.WriteLine("Word Count: " + WordCnt);
            Console.WriteLine("Sentence Count: " + sentCnt);
            Console.WriteLine("Words Per Sentence: " + string.Format("{0:0.000}", wrdsPrCnt));
            Console.WriteLine("Character Count: " + CharCnt);
            Console.WriteLine("Special Character Count: " + SpecCnt);
            Console.WriteLine("Characters Per Sentence: " + string.Format("{0:0.0000}", charPrCnt));
            Console.WriteLine("Number Count: " + NumCnt);



            Console.WriteLine(SpecCnt);
            Console.WriteLine(lettrCnt);
            Console.WriteLine(WordCnt);
            Console.WriteLine(sentCnt);


            // THIS SHOULD BE THE LAST STATEMENT FOR MAIN
            Console.Read();
        }

    }
}
