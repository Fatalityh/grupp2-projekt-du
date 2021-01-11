using System;
using System.Collections.Generic;

namespace gruppprojekt2
{
    class Program
    {
        static void Main(string[] args)
        {
            PostsClass postsInfo = new PostsClass(); // Creates an instance of AddToFile
            bool menuChoice = true;
            postsInfo.Posts = postsInfo.ReadJsonFromFile(); // Adds the data from JSON file into postsInfo.posts (list)

            while (menuChoice)
            {
                Console.WriteLine("Hello! What do you want to do today?");
                Console.WriteLine("1. Create a new post");
                Console.WriteLine("2. Show all posts");
                Console.WriteLine("3. Search post");
                Console.WriteLine("4. Read Posts from Json File");
                Console.WriteLine("5. Exit");
                break;
            }

            char buttonPressed;
            buttonPressed = Console.ReadKey(true).KeyChar;
            switch (buttonPressed)
            {
                case '1':
                    postsInfo.AddPostData(); // Method
                    Console.Clear();
                    break;

                case '2':
                    postsInfo.OutputPersonData(); // Method
                    break;

                case '3':
                    postsInfo.OutputSearchParameter(); // Method
                    break;

                case '4':
                    postsInfo.ReadJsonFromFile().ForEach(Console.WriteLine); // Method - Reads the postsInfo from JSON file and executes the ToString() method from PostsInfo
                    Console.Clear();
                    break;

                case '5':
                    Console.WriteLine("\nGoodbye\n"); // Exits the program
                    menuChoice = false;
                    break;

                default:
                    Console.WriteLine("\nIncorrect: Please choose a number between 1-5.");
                    break;
            }
        }
    }
}
