using System;
using System.Collections.Generic;

namespace gruppprojekt2 {
    class AddToFile {
        List<AddToFile> AddPostsToFile = new List<AddToFile>();
    }

    class PostsClass {
        List<PostsInfo> Posts = new List<PostsInfo>();

        public void AddPostData() {
            PostsInfo postsUser = new PostsInfo(); // Creates an instance of AddToFile

            Console.WriteLine("\nWrite the name of the person that is posting"); // Name of the poster 
            string savedPosterName = Console.ReadLine();

            Console.WriteLine($"\nWrite the title of the post {savedPosterName}?"); // Post
            string savedPostTitle = Console.ReadLine();

            Console.WriteLine($"\nWrite your post {savedPosterName}?"); // Post
            string savedPost = Console.ReadLine();

            Console.WriteLine($"\n{savedPost} added to {savedPosterName}\nReturning to Main Menu.\n");

            // Adds all the data into the postUser variable
            postsUser.DateOfPost = DateTime.Now;
            postsUser.PosterName = savedPosterName;
            postsUser.PosterTitle = savedPostTitle;
            postsUser.PosterComment = savedPost;

            Posts.Add(postsUser); // Adds the data above (postUser - variable) into the list persons
        }

        public void OutputPersonData() {
            bool miniMenu = true;

            while (miniMenu == true) {
                Console.WriteLine("Choose sorting option, 1: Early to Late 2: Late to early");
                int buttonPressed = int.Parse(Console.ReadKey().KeyChar.ToString());

                switch (buttonPressed) {
                    case 1:
                        Posts.Sort((x, y) => DateTime.Compare(x.DateOfPost, y.DateOfPost));
                        Posts.ForEach(Console.WriteLine);
                        miniMenu = false;
                        break;

                    case 2:
                        Posts.Sort((y, x) => DateTime.Compare(x.DateOfPost, y.DateOfPost));
                        Posts.ForEach(Console.WriteLine);
                        miniMenu = false;
                        break;
                }
            }
        }

        public void OutputSearchParameter() {
            Console.WriteLine("Search for a post");
            string savedSearchParameter = Console.ReadLine();
            bool foundMatch = false;

            foreach (PostsInfo post in Posts) {
                if (post.PosterName.Contains(savedSearchParameter)) {
                    Console.WriteLine(post);
                    foundMatch = true;
                }
            }
            if (!foundMatch) {
                Console.WriteLine($"Invalid, could not find a post containing {savedSearchParameter}");
            }
        }
    }
}