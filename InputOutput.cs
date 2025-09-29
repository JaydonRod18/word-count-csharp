using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rodrigues.WordCount.App15
{
    public class InputOutput
    {
        public InputOutput() { } //It is the constructor

        public void showMessageToUser(String message)  //It shows a message to the user
        {
            Console.WriteLine(message); //It shows the message
        }

        public void skipALine() //It skips a line
        {
            Console.WriteLine(); //It skips a line
        }

        public String obtainInputFromUser(String message) //It obtains input from the user
        {
            Console.Write(message + "  "); //It shows the message
            return Console.ReadLine(); //It returns the input from the user
        }
    }
}
