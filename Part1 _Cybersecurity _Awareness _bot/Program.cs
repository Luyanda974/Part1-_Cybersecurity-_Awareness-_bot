using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1__Cybersecurity__Awareness__bot
{//start of namespace
    internal class Program
    {//start of class
        static void Main(string[] args)
        {// start of main
            //An instance voice_greeting class with constructor
            new voice_greeting();
            //An instance for the asii_logo class with constructor
            new ascii_logo();
            //An instance for the welcome_and_username class with an object name welcome_and_collect
            welcome_and_username welcome_and_collect = new welcome_and_username();

            //calling the method welcome
            welcome_and_collect.welcome();
            //calling the method to ask the user  for name
            welcome_and_collect.ask_user();
            chatbot_response bot = new chatbot_response();
            bot.start_chat();
        }//end of main
    }//end of class
}//end of namespace
