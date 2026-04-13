using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace talklyapp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 1. Play the voice greeting
            greet_voice voice = new greet_voice();

            // 2. Display the Logo
            AsciiLogo.DisplayLogo();

            // 3. Pause so the user can see the logo
            Console.WriteLine("\nPress any key to start the conversation...");
            Console.ReadKey();

            // 4. Clear the screen for a clean chat interface
            Console.Clear();

            // 5. Initialize and run the chat interaction
            greet_and_name greeting_and_name = new greet_and_name();

            greeting_and_name.welcome();
            greeting_and_name.ask_name();
            greeting_and_name.chat();

        } //end of main
    } //end of class
} //end of namespace