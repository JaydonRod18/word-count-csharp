using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rodrigues.WordCount.App15
{
    public class InputOutput
    {
        public InputOutput() { }

        public void showMessageToUser(String message)
        {
            Console.WriteLine(message);
        }

        public void skipALine()
        {
            Console.WriteLine();
        }

        public String obtainInputFromUser(String message)
        {
            Console.Write(message + "  ");
            return Console.ReadLine();
        }
    }
}

