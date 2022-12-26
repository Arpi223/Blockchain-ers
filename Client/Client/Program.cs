using System;
using System.Collections.Generic;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int i = 0;
            List<Client> ClientList = new List<Client>();

            /*
            Client klijent = new Client();

            Console.WriteLine(klijent);
            */

            
                Console.WriteLine("Unesite id: ");
                string id = Console.ReadLine();
                Console.WriteLine("Unesite vrednost: ");
                string vrednost = Console.ReadLine();

            Client klijent = new Client(id, vrednost);

            Console.WriteLine(klijent.Povratna);

              //  ClientList[i] = new Client(id, vrednost);

            // napraviti da se lista popunjava, ovo je samo placeholder
            


        }
    }
}
