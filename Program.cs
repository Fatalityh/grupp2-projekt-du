using System;
using System.Collections.Generic;

namespace gruppprojekt2
{
    class Program
    {
        static void Main(string[] args) {     
            PostsClass postsInfo = new PostsClass(); // Creates an instance of AddToFile
            bool menuChoice = true;

            while (menuChoice)
            {
                Console.WriteLine("Hello! What do you want to do today?");
                Console.WriteLine("1. Create a new post");
                Console.WriteLine("2. Show all posts");
                Console.WriteLine("3. Search post");  
                Console.WriteLine("4. Read Posts from Json File"); 
                Console.WriteLine("5. Exit");             
                int buttonPressed = int.Parse(Console.ReadKey().KeyChar.ToString()); // Registers the number characters instantly instead of writing a number and pressing enter

                switch (buttonPressed)
                {
                    case 1:
                        postsInfo.AddPostData(); // Method
                        break;

                    case 2:
                        postsInfo.OutputPersonData(); // Method
                        break;

                    case 3:
                        postsInfo.OutputSearchParameter(); // Method
                        break;

                    case 4:
                        postsInfo.GetFileReadFromJson(); // Method
                        break;

                    case 5:
                        Console.WriteLine("\nGoodbye\n"); // Exits the program
                        menuChoice = false;
                        break;
                }
            }
        }
    }
}
