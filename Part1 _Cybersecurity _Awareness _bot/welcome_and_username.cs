using System;

namespace Part1__Cybersecurity__Awareness__bot
{//start of namespace
    internal class welcome_and_username
    {//start of class
       //global variable
       private string username = string.Empty;

        public void welcome()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[Welcome to the Chatbot]");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-----------------------------------");
            Console.ResetColor();
        }
        // method to ask for the user name
        public void ask_user()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("AI NAME:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter your name...");
            Console.ResetColor();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("USER: ");

                Console.ForegroundColor = ConsoleColor.Gray;

                username = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(username))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("AI NAME: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Hey " + username);
                    Console.ResetColor();
                    break;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("AI NAME: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter name....");
                    Console.ResetColor();
                }
            }

            }
        }//end of class
}//end of namespace