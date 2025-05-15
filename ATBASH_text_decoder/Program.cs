using System;
namespace ATBASH_text_decoder
{
    class Program
    {
        static void Main()
        {
            int numOfWorning = 0;

            List<string> dangerWords = new List<string> { "bomb", "nukhba", "fighter", "rocket", "secret" };



            string text = "Lfi ulixvh ziv kivkzirmt uli z nzqli zggzxp lm gsv Arlmrhg vmvnb. Gsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo.Ylnyh szev yvvm kozxvw mvzi pvb olxzgrlmh. Mfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm. Gsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm’g hvv rg xlnrmt. Dv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg. Erxglib rh mvzi. Hgzb ivzwb.";

            Console.WriteLine($"enter please the text:\n\n{text}\n");

            string decipheredText = AtbashDecoder(text);

            numOfWorning = dangerousWordCount(decipheredText, dangerWords);

            string levelOfDanger = CalculatorWarning(numOfWorning);

            Console.WriteLine($"the decipherd text is:\n\n\"{decipheredText}\"\n");
            Console.WriteLine($"the number of words we have are {numOfWorning} ther foer the level of danger is {levelOfDanger}");


        }


        static int dangerousWordCount(string text, List<string> warningWordsList)
        {
            int CountDangerousWord = 0;

            string[] words = text.Split(new char[] { ' ', ',', '.', '?', '!', '_', '-', ':', ':', '{', '}', '[', ']', '(', ')', '\\', '/', '\"' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var dangerousWord in warningWordsList)
            {
                foreach (var word in words)
                {
                    if (word.Contains(dangerousWord))
                    {
                        CountDangerousWord++;
                    }

                }
            }

            return CountDangerousWord;
        }


        static string AtbashDecoder(string text)
        {
            string newText = "";
            Dictionary<char, char> Hatbash = new Dictionary<char, char> {{ 'a', 'z' },{ 'b','y' },
                { 'c','x'},{ 'd','w'},{ 'e','v' },{ 'f','u'},{ 'g','t'},{ 'h','s'},{ 'i','r'} ,{ 'j','q'} ,
                { 'k','p'} ,{ 'l','o'} ,{ 'm','n'},{ 'n','m'},{ 'o','l'},{ 'p','k'},{ 'q','j'},{ 'r','i'},
                { 's','h'} ,{ 't','g'},{ 'u','f' },{ 'v','e' },{ 'w','d' },{ 'x','c' },{ 'y','b' },{ 'z','a' }
            };


            text = text.ToLower();
            foreach (var c in text)
            {
                if (Hatbash.ContainsKey(c))
                {
                    newText += Hatbash[c];
                }
                else
                {
                    newText += c;
                }


            }
            return newText;
        }



        static string CalculatorWarning(int pointNumber)
        {
            string alertstring = "";
            if (pointNumber == 0)
            {
                alertstring += "NO WAENING!";
            }
            else if (pointNumber >= 1 && pointNumber <= 5)
            {
                alertstring += "WARNING!!!";
            }

            else if (pointNumber >= 6 && pointNumber <= 10)
            {
                alertstring += "DANGER!!!";
            }
            else if (pointNumber >= 11)
            {
                alertstring += "ULTRA ALERT!!!";
            }
            else
            {
                alertstring += "ERROR!!!";
            }
            return alertstring;
        }


    }
}