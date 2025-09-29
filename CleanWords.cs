using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rodrigues.WordCount.App15
{
    public class CleanWords
    {
        private String theWords;
        private String theCleanedWords;

        public CleanWords()
        {
            theWords = "Four score and seven years ago our fathers brought forth on this continent, a\r\nnew nation, conceived in Liberty, and dedicated to the proposition that all men\r\nare created equal.";

            removeUncountableChars();
        }

        public CleanWords(String s)
        {
            theWords = s;

            removeUncountableChars();
        }

        public String getTheCleanedWords()
        {
            return theCleanedWords;
        }

        private void removeUncountableChars()
        {
            theCleanedWords = "";

            removeNonCountableChars();
        }
        private void removeNonCountableChars()
        {
            copyFirstWordTotheCleanedWords();

            for (int n = theCleanedWords.Length; n < theWords.Length; n++)
            {
                if ((theWords[n] == ' ') || (theWords[n] >= 'a' && theWords[n] < +'z')
                    || (theWords[n] >= 'A' && theWords[n] < +'Z')
                    || (theWords[n] >= '0' && theWords[n] < +'9'))
                {

                    theCleanedWords += Convert.ToString(theWords[n]);
                    continue;
                }

                theCleanedWords += " ";
            }
        }

        private void copyFirstWordTotheCleanedWords()
        {
            int n = 0;

            do
            {
                if (theWords[n] != ' ')
                {
                    if ((theWords[n] >= 'a' && theWords[n] < +'z')
                     || (theWords[n] >= 'A' && theWords[n] < +'Z')
                     || (theWords[n] >= '0' && theWords[n] < +'9'))
                        theCleanedWords += Convert.ToString(theWords[n]);
                }
                else
                    return;
            } while (++n < theWords.Length);

            return;
        }
    }
}
