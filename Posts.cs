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

            Console.WriteLine("\nWrite the name of the person that is posting..."); // Name of the poster 
            string savedPosterName = Console.ReadLine();
            Console.WriteLine($"{savedPosterName}");

            Console.WriteLine("\n Whats the title of the post?"); // Title of the Post
            string savedPostTitle = Console.ReadLine();
            Console.WriteLine($"{savedPostTitle}");
            

            Console.WriteLine($"Write your post {savedPosterName}?"); // Post
            string savedPost = Console.ReadLine();
            Console.WriteLine($"{savedPost} added to {savedPosterName}");

            Console.WriteLine($"{savedPost} added to {savedPosterName}, you are now done adding this post. \nReturning to Main Menu."); // End of adding details


            // Adds all the data into the postUser variable
            postsUser.SetPosterName(savedPosterName);
            postsUser.SetPostComment(savedPost);
            postsUser.SetPostTitle(savedPostTitle);

            Posts.Add(postsUser); // Adds the data above (postUser - variable) into the list persons
        }

        /*public void OutputPersonData() {
            Posts.ForEach(Console.WriteLine);
        }*/

        public List<PostsInfo> GetList() {
            return Posts;
        }
    }

    class PostsInfo {
        string posterName, posterComment;
        public void SetPosterName(string pName) {
            this.posterName = pName;
        }
        public void SetPostComment(string pData) {
            this.posterComment = pData;
        }
        public void SetPostTitle(string pTitle) {
            this.postTitle = pTitle;
        }
    }
}