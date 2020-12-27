using System;
using System.Collections.Generic;

namespace gruppprojekt2
{
    class AddToFile
    {
        List<AddToFile> AddPostsToFile = new List<AddToFile>();
        
        string posterName, posterComment;
        public void SetPosterName(string pName) {
            this.posterName = pName;
        }
        public void SetPostComment(string pData) {
            this.posterComment = pData;
        }
    }

    class Posts {
        List<Posts> PostsList = new List<Posts>();

        public void AddPostData() {

            Console.WriteLine("\nWrite the name of the person that is posting..."); // Name of the poster 
            string savedPosterName = Console.ReadLine();
            Console.WriteLine($"{savedPosterName}");

            Console.WriteLine($"Write your post {savedPosterName}?"); // Post
            string savedPost = Console.ReadLine();
            Console.WriteLine($"{savedPost} added to {savedPosterName}");

            Console.WriteLine($"{savedPost} added to {savedPosterName}, you are now done adding this person to the list. \nReturning to Main Menu."); // End of adding details

            AddToFile PostsWriteToFile = new AddToFile(); // Creates an instance of AddToFile

            // Adds all the data into the postUser variable
            postUser.SetPosterName(savedPosterName);
            postUser.SetPostComment(savedPost);

            PostsList.Add(postUser); // Adds the data above (postUser - variable) into the list persons
        }
    }
}