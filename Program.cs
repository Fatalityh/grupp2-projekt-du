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
                Console.WriteLine("Hej! Skriv in en siffra på önskat menyval nedan!");
                Console.WriteLine("1. Gångertabellen 1 till 9");
                Console.WriteLine("2. Få reda på summa samt medelvärdet på dina tal");
                Console.WriteLine("3. Sortera datorns slumpade tal");
                Console.WriteLine("4. Ge egenskaper till person/personer");
                Console.WriteLine("5. Avsluta programmet!");

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

                    /* Sortera datorns slumpade tal */
                    case 3:
                        SlumpadeTal();
                        break;

                    case 4:
                        AddUser();
                        break;

                    /* Avsluta programmet */
                    case 5:
                        menyVal = false;
                        break;
                }
            }
        }
            
        }
    }
}
