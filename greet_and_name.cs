using System;

namespace talklyapp
{//start of namespace
    public class greet_and_name
    {//start of class
        // Global variable for the username
        private string username = string.Empty;

        // Void method to welcome the user
        public void welcome()
        {//start of method
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=========================");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome to Talkly Chatbot");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=========================");
            Console.ResetColor();
        }

        // Prompt the user for their name
        public void ask_name()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Talkly: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter your name");
            Console.ResetColor();

            // Do-while loop to reprompt the user if they leave it blank
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("User: ");

                Console.ForegroundColor = ConsoleColor.Gray;
                username = Console.ReadLine();
                Console.ResetColor();

            } while (!isEmpty());//
        }

        // Boolean method to check if the user entered a valid name
        private bool isEmpty()
        {
            // string.IsNullOrWhiteSpace is much safer than checking != "" 
            // It prevents the user from just typing spaces!
            if (!string.IsNullOrWhiteSpace(username))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Talkly: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hey " + username + " WELCOME TO TALKLY ");
                Console.WriteLine("Ask me anything about cybersecurity!\n");
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Talkly: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a valid name.");
                return false;
            }
        }

        // Main chat loop
        public void chat()
        {
            string userInput = "";

            // Array of keywords and corresponding responses
            string[] keywords = {
        "how are you",
        "purpose",
        "tips",
        "about",
        "password",
        "phishing",
        "browser safety"
    };

            string[] responses = {
        "I'm doing great! Thanks for asking ",
        "My purpose is to help you learn about software development and stay safe online.",
        "Here are some tips:\n- Use strong passwords\n- Avoid suspicious links\n- Keep software updated",
        "You can ask me about cybersecurity!",
        "Use strong passwords with uppercase, lowercase, numbers, and symbols.",
        "Phishing is when attackers trick you into giving personal info. Always check links.",
        "Always use secure websites (https) and keep your browser updated."
    };

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(username + ": ");
                Console.ForegroundColor = ConsoleColor.Gray;

                userInput = Console.ReadLine()?.ToLower() ?? "";
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Talkly: ");

                bool found = false; // Flag to check if a response was found

                // Check for keywords in the user input
                for (int i = 0; i < keywords.Length; i++)
                {
                    if (userInput.Contains(keywords[i]))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(responses[i]);
                        found = true;
                        break;
                    }
                }

                // Check for exit command
                if (userInput == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Goodbye! Stay safe.");
                }
                // If no keywords matched and it's not an exit command, prompt the user to try again
                else if (!found)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("I didn't understand that. Could you please repeat?");
                }

                Console.ResetColor();

            } while (userInput != "exit");
        }//end of method
    }//end of class
}//end of namespace