using System;
using System.Collections.Generic;

namespace gruppprojekt2
{
    class Program
    {
        static void Main(string[] args) {
            bool showMenu = true;

            while (showMenu == true) {
                Console.WriteLine("\nMenu Options\n 1: Option 1\n 2: Option 2\n 3: Option 3\n 4: Option 4\n 5: Option 5\n 6: Exit Program\n");
                int buttonPressed = int.Parse(Console.ReadKey().KeyChar.ToString()); // Registers the key pressed instantly instead of manually pressing "Enter"

                if (buttonPressed == 1) // Option 1
                {
                    
                } else if (buttonPressed == 2) // Exits menu and enters option 2
                  {
                    showMenu = false;
                  }
                } else if (buttonPressed == 3) // Option 3
                  {

                  }
                } else if (buttonPressed == 4) // Shows the creator lulz
                  {
                    Console.WriteLine("\n\nMade by Auan Jiawook, Hilda Behnam and Manne Johnsson");
                  }
                } else if (buttonPressed == 5) // Option 5
                  {
                    
                  }
                } else if (buttonPressed == 6) // Exits the program
                 {
                    Environment.Exit(0); // Exits the program instead of having to manually exit with "Control + C"
                }

                if (showMenu == false) // When you press 2 you exit the menu and enter the math feature
                {
                    
                }
            }
        }
    }
}