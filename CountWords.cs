using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rodrigues.WordCount.App15
{
    public class CountWords
    {
        public class CountTheWords
        {
            private String theWords;
            private String theCleanedWords;

            public CountTheWords()
            {
                InputOutput inOut = new InputOutput();

                obtainInputForCounting(inOut);
                prepInputForCounting();
                showOriginalAndPreppedInput(inOut);
            }

            private void obtainInputForCounting(InputOutput inOut)
            {
                theWords = inOut.obtainInputFromUser("Four score and seven years ago our fathers brought forth on this continent, a\r\nnew nation, conceived in Liberty, and dedicated to the proposition that all men\r\nare created equal"); //It is here to obtain the words to count
                inOut.skipALine();
                inOut.skipALine();
                if (theWords == null || theWords.Length == 0)
                    theWords = "Four score and seven years ago our fathers brought forth on this continent, a\r\nnew nation, conceived in Liberty, and dedicated to the proposition that all men\r\nare created equal"; //It is here to set the words to count
            }

            private void prepInputForCounting()
            {
                CleanWords cleanUp = new CleanWords(theWords);

                theCleanedWords = cleanUp.getTheCleanedWords();
            }

            private void showOriginalAndPreppedInput(InputOutput inOut)
            {
                inOut.showMessageToUser(theWords);
                inOut.showMessageToUser(theCleanedWords);
            }
        }
    }
}
