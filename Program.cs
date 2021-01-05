using System;
using System.Collections.Generic;
using System.IO;

namespace gruppprojekt2
{
    class Program
    {
        static void Main(string[] args) {     
            PostsClass postsInfo = new PostsClass(); // Creates an instance of AddToFile


            bool menuChoice = true;
            int option; 
            while (menuChoice)
            {
                Console.WriteLine("Hello! What do you want to do today?");
                Console.WriteLine("1. Create a new post");
                Console.WriteLine("2. Show all posts");
                Console.WriteLine("3. Search older posts");  
                Console.WriteLine("4. Exit");             
                int buttonPressed = int.Parse(Console.ReadKey().KeyChar.ToString());

                /* Vid fel input från användaren */
                string stringOption;
                stringOption = Console.ReadLine();
                if (!int.TryParse(stringOption, out option))
                {
                    Console.WriteLine("\n Testa igen!");
                    continue; // Om användaren skriver fel input mer än en gång, så kommer menyn upp igen //
                }


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
                        Console.WriteLine("Choice 3");
                        menuChoice = false;
                        break;
                /*
                ReadFileWithOpen(); */
                }
            }

          /*  statis void ReadFileWithOpen()
            {
                string path = "UsingOpen.txt";
                using(FileStream fs = File.Open(path, FileMode.OpenOrCreate, FileAcess.Read, FileShare.Read))
                {
                    byte[] b = new byte[1024];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while(fs.Read(b, 0, b.Length) > 0)
                    {
                        Console.WriteLine(temp.GetString(b));
                    }
                }
            }

            static void ReadAllLines()
                {
                    string path = "ReadAllLines.txt";
                    string[] readText = File.ReadAllLines(path);
                    foreach(string s in readText)
                    {
                        Console.WriteLine(s);
                    }
                } 
            ) */
        }
    }
}
