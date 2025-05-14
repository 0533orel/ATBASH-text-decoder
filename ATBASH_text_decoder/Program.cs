using System;
using System.Collections.Generic;

namespace ATBASH_text_decoder
{
    class Program
    {
        static void Main()
        {

        }


        static int dangerousWordCount(string text, List<string> warningWordsList)
        {
            int CountDangerousWord = 0;

            string[] words = text.Split(new char[] { ' ', ',', '.', '?', '!', '_', '-', ':', ':', '{', '}', '[', ']', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            
            foreach (var word in words)
            {
                if (warningWordsList.Contains(word))
                {
                    CountDangerousWord++;
                }
            }

            return CountDangerousWord;
        }
    }
}