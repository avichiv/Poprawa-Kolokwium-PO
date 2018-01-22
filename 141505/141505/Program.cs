using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace _141505
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sportowiec sportowiec1 = new Sportowiec("Adam", 'W');
            List<Sportowiec> sport = new List<Sportowiec>();
            sport.Add(new Biegacz("ADAM", 'W', 23));
            sport.Add(new Biegacz("BRONEK", 'W', 25));
            sport.Add(new Biegacz("WRONEK", 'W', 26));
            sport.Add(new Biegacz("JAN", 'W', 27));



            foreach (Biegacz element in sport)
            {
                element.Zawody(3);
            }

            //Wypisanie listy na konsoli
            for (int i = 0; i < sport.Count; i++)
            {
                Console.WriteLine(sport[i] + " ");
            }
            Console.WriteLine("--------------------------");

            sport.Sort(); //POSORTOWANIE LISTY

            for (int i = 0; i < sport.Count; i++)
            {
                Console.WriteLine(sport[i] + " ");
            }

            Console.WriteLine("--------------------------");

            sport.Reverse(); //ODWROCENIE LISTY

            for (int i = 0; i < sport.Count; i++)
            {
                Console.WriteLine(sport[i] + " ");
            }

            
            Console.WriteLine("--------------------------");



            ///////////////////////////////////////////////////
            Console.WriteLine("Podaj liczbe: ");
            int liczba = int.Parse(Console.ReadLine());

            Biegacz biegacz1 = new Biegacz("Wieslaw",'E',liczba);
            

            //Zawody zawody1 = new Zawody();

            ArrayList myAL = new ArrayList();
            myAL.Add("Hello");
            myAL.Add(123);
            myAL.Add(true);
            myAL.Add('w');
            myAL.Add(2.22);
            myAL.Add(false);
            myAL.Add(123);
            myAL.Add(2555);

            Console.WriteLine("Lista o parzystych indeksach:");
            for (int i = 0; i < myAL.Count; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(myAL[i] + " ");
                }
            }

            LinkedList<char> linked = new LinkedList<char>();
            linked.AddLast('w');
            linked.AddLast('a');
            linked.AddLast('s');
            linked.AddLast('d');
            linked.AddLast('f');
            //linked.AddBefore(linked[3], 'W');
            Console.ReadKey();
        }
    }
}
