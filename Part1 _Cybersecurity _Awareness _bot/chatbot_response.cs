using System;
using System.Runtime.CompilerServices;

namespace Part1__Cybersecurity__Awareness__bot
{//start of namespace
    internal class chatbot_response
    {//start of class
        public void start_chat()
        {
            string input = "";

           // To display chatbot introduction mesage with color formatting
           Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n---Cybersecurity Chat Started---");
            Console.WriteLine("Ask about passowrds, phishsing or safe browsing");
            Console.WriteLine("Type 'exit 'to quit.\n");
            Console.ResetColor();

            while (input != "exit")
            {
                //to prompt user for input
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("USER: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                //read user user input convert to lowercase for esy comparison 
                input = Console.ReadLine().ToLower();
                //to validate  input to check if uder entered nothing
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("AI: Please enter something...");
                    Console.ResetColor();
                    continue;
                }
                respond(input);
            }
        }
        private void respond(string input)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("AI: ");
            Console.ForegroundColor = ConsoleColor.White;

            //keywords array
            string[] keywords =
            {
                "how are you",
                "purpose",
                "passwords",
               "phishing",
               "safe browsing"

            };
            //responses array
            string[] responses = {
                "I am doing great, i am here to help you stay safe online.",
                "My purpose is to educate you about cybersecurity.",
                "Use strong passwords with uppercase letters, numbers and symbols.",
                "Phishing is when scammers trick you into giving personal information.",
                "Always check links and avoid suspicious websites"

            };
            bool found = false;
            //loop through keywords
            for (int i = 0; i < keywords.Length; i++) {
                if (input.Contains(keywords[i]))
                {
                    Console.WriteLine(responses[i]);
                    found = true;
                    break;
                }
            }
            if (input == "exit")
            {
                Console.WriteLine("Goodbye! Stay safe online.");
            }
            else if (!found)
            {
                Console.WriteLine("I didnt quite get that. Could you rephrase?");
            }
            Console.ResetColor();
        }
    }//end of class
}//end of namespce