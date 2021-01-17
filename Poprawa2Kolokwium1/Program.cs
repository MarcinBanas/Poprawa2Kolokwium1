using System;

namespace Poprawa2Kolokwium1
{
    class Program
    {
        public void CzasPrzenoszenia(double dane)
        {
            
                double czaswgrywanie, czaszgrywanie;
                czaswgrywanie = (dane * 1000) / 3;
                czaszgrywanie = (dane * 1000) / 5;
                Console.WriteLine("Czas:" + (czaswgrywanie + czaszgrywanie));
            

        }
        static void Main(string[] args)
        {
            string[] tab = new string[5];
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Podaj zyczenie:");
                tab[i] = Console.ReadLine();
            }
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Numer:"+i+" Zyczenie: "+tab[i]);
            }
            string odp;
            Console.WriteLine("Czy chcesz zmienic kolejnosc?(tak)");
            odp = Console.ReadLine();
            if (odp == "tak")
            {
                Console.WriteLine("podaj indeks elementu:");
                int index;
                index =int.Parse(Console.ReadLine());
                Console.WriteLine("podaj nowy indeks elementu");
                int index2;
                index2 = int.Parse(Console.ReadLine());

            }

        }
    }
}
