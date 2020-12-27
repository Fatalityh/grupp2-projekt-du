using System;
using System.Collections.Generic;

namespace gruppprojekt2
{
    class OutputData
    {
        public void OutputPersonData() {
            foreach (var post in Posts) { // Prints each person data from list persons
                Console.WriteLine(post);
            }
            Console.WriteLine("\n Returning to Main Menu");
        }
    }
}