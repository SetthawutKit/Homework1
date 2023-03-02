using System;
namespace Homework {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter your passcode: ");
            string pass = Console.ReadLine();

            Console.WriteLine("Enter your agency: ");
            string agent = Console.ReadLine();

            if (pass.Length != 6) {
                Console.WriteLine("Error: Passcode must have 6 digits.");
            }
            else if (agent != "FBI" && agent != "NSA" && agent != "CIA") {
                
            }
        }
    }
}
