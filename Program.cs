using System;
using System.Collections.Generic;

namespace gruppprojekt2
{
    class Program
    {
        static void Main(string[] args) {     
            PostsClass postsInfo = new PostsClass(); // Creates an instance of AddToFile

            bool menuChoice = true; 
            int opt; 

            while (menuChoice)
            {
                Console.WriteLine("Hello! What do you want to do today?");
                Console.WriteLine("1. Create a new post");
                Console.WriteLine("2. Show all posts");
                Console.WriteLine("3. Search older posts");  
                Console.WriteLine("4. Exit");             
                int buttonPressed = int.Parse(Console.ReadKey().KeyChar.ToString());

               /* string stringinput;
                stringinput = Console.ReadLine();
                if (!int.TryParse(stringinput, out opt))
                {
                    Console.WriteLine("Invalid input, Try again");
                    continue;
                } */

                switch (buttonPressed)
                {

                    case 1:
                        postsInfo.AddPostData();
                        break;

                    case 2:
                        postsInfo.OutputPersonData();
                        break;

                    case 3:
                        postsInfo.OutputSearchParameter();
                        break;

                    case 4:
                        Console.WriteLine("Choice 4");
                        menuChoice = false;
                        break;
                }
            }
        }
    }
}
