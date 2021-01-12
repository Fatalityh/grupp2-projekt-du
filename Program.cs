using System;
using System.Collections.Generic;
using System.IO;

namespace gruppprojekt2 {
    class Program {
        static void Main(string[] args) {
            PostsClass postsInfo = new PostsClass(); // Creates an instance of AddToFile

            // Checker for the PostsData.json file to make sure the program does not crash if the file does not exist or if the file is empty.
            FileInfo FileChecker = new FileInfo("PostsData.json");
            if (!File.Exists("PostsData.json")) {
                FileStream ff = FileChecker.Create(); // Creates a file called "PostsData.json" if it does not exist and then exits so that the file is not locked.
                ff.Close();
            }
            long length = FileChecker.Length;
            if (length > 10) { // Makes sure the file has content in it before adding it to Posts
                postsInfo.Posts = postsInfo.ReadJsonFromFile(); // Adds the data from JSON file into postsInfo.posts (list)
            }
            // End of File Checker

            bool menuChoice = true;

            Console.Clear();
            while (menuChoice) {
                Console.WriteLine(@"
______ _                  
|  _  (_)                 
| | | |_  __ _ _ __ _   _ 
| | | | |/ _` | '__| | | |
| |/ /| | (_| | |  | |_| |
|___/ |_|\__,_|_|   \__, |
                     __/ |
                    |___/ ");
                Console.WriteLine("");
                Console.WriteLine("1. Create a new post");
                Console.WriteLine("2. Show all posts");
                Console.WriteLine("3. Search post");
                Console.WriteLine("4. Exit");

                char buttonPressed;
                buttonPressed = Console.ReadKey(true).KeyChar;

                switch (buttonPressed) {
                    case '1':
                        postsInfo.AddPostData(); // Method
                        break;

                    case '2':
                        postsInfo.OutputPersonData(); // Method
                        break;

                    case '3':
                        postsInfo.OutputSearchParameter(); // Method
                        break;

                    case '4':
                        Console.WriteLine("\nGoodbye\n"); // Exits the program
                        menuChoice = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("\nIncorrect: Please choose a number between 1-4.\n");
                        break;
                }
            }
        }
    }
}
