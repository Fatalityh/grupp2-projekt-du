using System;
using System.Collections.Generic;

namespace gruppprojekt2
{
    class Program
    {
        static void Main(string[] args) {
            
            bool menyVal = true;
            int input;
            while (menyVal)
            {
                /* Menyn med alternativ för programmet */
                Console.WriteLine("Hello! What do you want to do today?");
                Console.WriteLine("1. Create a new post");
                Console.WriteLine("2. Search older posts");
                Console.WriteLine("3. Exit");
             
                /* Vid fel input från användaren */
                string stringInput;
                stringInput = Console.ReadLine();
                if (!int.TryParse(stringInput, out input))
                {
                    Console.WriteLine("Testa igen!");
                    continue; // Om användaren skriver fel input mer än en gång, så kommer menyn upp igen //
                }

                /* Alternativ 1 till 5 i menyn */
                switch (int.Parse(Console.ReadLine()))
                {
                    /* Multiplikationstabellen */
                    case 1:
                        Tabeller();
                        break;

                    /* Summa och medelvärde på önskade tal */
                    case 2:
                        Tal();
                        break;

          
                    /* Avsluta programmet */
                    case 3:
                        menyVal = false;
                        break;
                }
            }
        }
            
        }
    }
}
