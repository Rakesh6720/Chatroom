using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    interface UserInterface
    {
        //interface methods
        public void Display(string message)
        {
            Console.WriteLine(message);
        }

        public string GetUserInput()
        {
            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}
