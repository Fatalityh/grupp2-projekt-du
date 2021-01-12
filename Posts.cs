using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace gruppprojekt2 {
    class PostsClass {
        public List<PostsInfo> Posts = new List<PostsInfo>(); // Creates a list from PostsInfo class

        public void AddPostData() {
            PostsInfo postsUser = new PostsInfo(); // Creates an instance of PostsInfo

            Console.Clear();
            Console.WriteLine("\nPost Creation:\n");

            Console.WriteLine("\nName...");
            string savedPosterName = Console.ReadLine();

            Console.WriteLine($"\nTitle...");
            string savedPostTitle = Console.ReadLine();

            Console.WriteLine($"\nPost...");
            string savedPost = Console.ReadLine();

            while (true) // Will run until the Console.ReadLine() has no char (empty string) and breaks the while loop
            {
                string extraText = Console.ReadLine();
                if (extraText == "") {
                    break;
                }
                savedPost = savedPost + "\n" + extraText;
            }

            Console.Clear();

            Console.WriteLine($"\nPost Added. Returning to Main Menu.\n");


            // Adds all the data into the postUser variable
            postsUser.DateOfPost = DateTime.Now;
            postsUser.PosterName = savedPosterName;
            postsUser.PosterTitle = savedPostTitle;
            postsUser.PosterComment = savedPost;

            Posts.Add(postsUser); // Adds the data above (postUser - variable) into the list persons

            var jsonData = PostsClass.ConvertToJson(Posts); // Converts the Posts data into JSON and then writes it to a file below this code
            WritePostData(jsonData);
        }

        static string ConvertToJson(List<PostsInfo> Posts) { // Converts the list Posts into JSON
            string json = JsonSerializer.Serialize<List<PostsInfo>>(Posts); // Serializes the Posts and saves it to string json
            return json;
        }

        static void WritePostData(string text) { // Writes "string text" to a file called "PostsData.json"
            string path = "PostsData.json";
            File.WriteAllText(path, text);
        }

        static string ReadPostData(string path) { // Reads the data from file (method)
            string content = File.ReadAllText(path);
            return content;
        }

        public List<PostsInfo> ReadJsonFromFile() { // Method that is used to Deserialize from the file "PostsData.json" so that we can read the objects and use WriteLine to output each string and datetime
            string path = "PostsData.json";
            string json = ReadPostData(path);
            List<PostsInfo> Posts = JsonSerializer.Deserialize<List<PostsInfo>>(json); // Deserializes the List<PostsInfo>
            return Posts; // Return the serialized data from the list (Posts)
        }

        public void OutputPersonData() { // Used so that we can sort the Posts by early to late OR late to early by using a miniMenu
            bool miniMenu = true;

            Console.Clear();
            while (miniMenu == true) {
                Console.WriteLine("\nChoose a sorting option to show Posts, 1: Early to Late 2: Late to early");

                char buttonPressed;
                buttonPressed = Console.ReadKey(true).KeyChar;

                switch (buttonPressed) {
                    case '1':
                        Console.WriteLine("");
                        Posts.Sort((x, y) => DateTime.Compare(x.DateOfPost, y.DateOfPost)); // Early to Late, hence the x, y
                        Posts.ForEach(Console.WriteLine);
                        miniMenu = false;
                        break;

                    case '2':
                        Console.WriteLine("");
                        Posts.Sort((y, x) => DateTime.Compare(x.DateOfPost, y.DateOfPost)); // Late to Early, we just flipped the x, y to y, x in the Posts.Sort()
                        Posts.ForEach(Console.WriteLine);
                        miniMenu = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("\nIncorrect: Please choose a sorting option by clicking 1 or 2.\n");
                        break;
                }
            }
        }

        public void OutputSearchParameter() { // Used for searching through each post (not from JSON File though) Basically you can search and find results from PosterName and PosterTitle. I did not include datetime or post text cous it's not needed in my opinion
            Console.Clear();
            Console.WriteLine("\nSearch for a post:");
            string savedSearchParameter = Console.ReadLine();
            bool foundMatch = false;

            foreach (PostsInfo post in Posts) { // Used to find each Post in the list Posts so that when we search it goes through all the Posts until it finds a result from our input
                if (post.PosterName.ToLower().Contains(savedSearchParameter.ToLower()) || post.PosterTitle.ToLower().Contains(savedSearchParameter.ToLower())) {
                    Console.Clear();
                    Console.WriteLine($"Found match for '{savedSearchParameter}'\n");
                    Console.WriteLine(post);
                    foundMatch = true;
                }
            }
            if (!foundMatch) { // Checker to see if it finds the result or not, if not then we get this Writeline below.
                Console.WriteLine($"\nInvalid, could not find a post containing {savedSearchParameter}\n");

                bool miniMenu = true;

                while (miniMenu == true) {
                    Console.WriteLine("1: Search again\n2: Return to Main Menu");

                    char buttonPressed;
                    buttonPressed = Console.ReadKey(true).KeyChar;

                    switch (buttonPressed) {
                        case '1':
                            OutputSearchParameter();
                            break;

                        case '2':
                            Console.Clear();
                            miniMenu = false;
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("\nIncorrect: Please choose a option by clicking 1 or 2.\n");
                            break;
                    }
                }
            }
        }
    }
}