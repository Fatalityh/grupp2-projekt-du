using System;
using System.Collections.Generic;

namespace gruppprojekt2 {
    class Program {
        static void Main(string[] args) {
            PostsClass postsInfo = new PostsClass(); // Creates an instance of AddToFile
            bool menuChoice = true;
            postsInfo.Posts = postsInfo.ReadJsonFromFile(); // Adds the data from JSON file into postsInfo.posts (list)

            while (menuChoice) {
                Console.WriteLine("\nHello and Welcome to Your Diary \n------------------------------ \n What do you want to do today?");
                Console.WriteLine("1. Create a new post");
                Console.WriteLine("2. Show all posts");
                Console.WriteLine("3. Search post");
                Console.WriteLine("4. Read Posts from Json File");
                Console.WriteLine("5. Exit \n------------------------------");

                int buttonPressed;
                while (!int.TryParse(Console.ReadLine(), out buttonPressed)) { // Checks to see if input is a int, if not the code below will execute
                    Console.WriteLine("\nIncorrect: Please choose a number between 1-5.");
                }

                switch (buttonPressed) {
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
                        postsInfo.ReadJsonFromFile().ForEach(Console.WriteLine); // Method - Reads the postsInfo from JSON file and executes the ToString() method from PostsInfo
                        break;

                    case 5:
                        menuChoice = false;
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
