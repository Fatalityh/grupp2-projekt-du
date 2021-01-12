using System;
using System.Collections.Generic;

namespace gruppprojekt2 {
    [Serializable] // Makes it so that everything in here is Serializable and able to become JSON data
    class PostsInfo {
        public string PosterName { get; set; }
        public string PosterTitle { get; set; }
        public string PosterComment { get; set; }
        public DateTime DateOfPost { get; set; } 

        public override string ToString() { // Outputs everything in the "Show all posts" option in menu
            return $"{DateOfPost}\n  {PosterTitle}\n     {PosterName}\n{PosterComment}\n";
        }
    }
}