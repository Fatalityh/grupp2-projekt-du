using System;
using System.Collections.Generic;

namespace gruppprojekt2
{
    class Program
    {
        static void Main(string[] args) {     
            OutputData outputData = new OutputData(); // Creates an instance of AddToFile
            PostsClass postsInfo = new PostsClass(); // Creates an instance of AddToFile


            bool menuChoice = true;

            while (menuChoice)
            {
                Console.WriteLine("Hello! What do you want to do today?");
                Console.WriteLine("1. Create a new post");
                Console.WriteLine("2. Search older posts");
                Console.WriteLine("3. Exit");             
                int buttonPressed = int.Parse(Console.ReadKey().KeyChar.ToString());

                switch (buttonPressed)
                {
                    case 1:
                        postsInfo.AddPostData();
                        break;

                    case 2:
                        outputData.OutputPersonData();
                        break;

                    case 3:
                        Console.WriteLine("Choice 3");
                        menuChoice = false;
                        break;
                }
            }
        }
    }
}
