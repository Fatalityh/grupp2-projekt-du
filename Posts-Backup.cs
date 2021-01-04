using System;
using System.Collections.Generic;

namespace gruppprojekt2 {
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    /*class AddToFile {
        List<AddToFile> AddPostsToFile = new List<AddToFile>();

    }

    class PostsClass {
        List<PostsInfo> Posts = new List<PostsInfo>();

        public void AddPostData() {
            PostsInfo postsUser = new PostsInfo(); // Creates an instance of AddToFile

            Console.WriteLine("\nWrite the name of the person that is posting..."); // Name of the poster 
            string savedPosterName = Console.ReadLine();

            Console.WriteLine($"\nWrite the title of the post {savedPosterName}?"); // Post
            string savedPostTitle = Console.ReadLine();

            Console.WriteLine($"\nWrite your post {savedPosterName}?"); // Post
            string savedPost = Console.ReadLine();

            Console.WriteLine($"\n{savedPost} added to {savedPosterName}\nReturning to Main Menu.\n");


            // Adds all the data into the postUser variable
            postsUser.SetPostsDate(DateTime.Now);
            postsUser.SetPosterName(savedPosterName);
            postsUser.SetPostTitle(savedPostTitle);
            postsUser.SetPostComment(savedPost);

            Posts.Add(postsUser); // Adds the data above (postUser - variable) into the list persons
        }

        public void OutputPersonData() {
            Posts.ForEach(Console.WriteLine);
        }

        public void OutputSearchParameter() {
            Console.WriteLine("Search for a post");
            string savedSearchParameter = Console.ReadLine();

            foreach (PostsInfo post in Posts) {
                if (Posts.Contains(savedSearchParameter)) {
                    Posts.Find(x => x == savedSearchParameter);
                } else {
                    Console.WriteLine($"Invalid, could not find a post containing {savedSearchParameter}");
                }
            }
        }
    }

    


    /*class PostsInfo {
        //string posterName, posterTitle, posterComment;
        //string posterName { get, set };
        
        DateTime dateOfPost;
        public void SetPostsDate(DateTime pDate) {
            this.dateOfPost = pDate;
        }
        public void SetPosterName(string pName) {
            this.posterName = pName;
        }
        public void SetPostTitle(string pTitle) {
            this.posterTitle = pTitle;
        }
        public void SetPostComment(string pData) {
            this.posterComment = pData;
        }

        public override string ToString() { // Outputs everything in the "Show data of people" option in menu
            return $"{dateOfPost}\n  {posterTitle}\n     {posterName}\n{posterComment}\n";
        }
    }*/
}