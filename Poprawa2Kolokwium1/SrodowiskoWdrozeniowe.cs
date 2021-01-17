using System;
using System.Collections.Generic;
using System.Text;

namespace Poprawa2Kolokwium1
{
    class SrodowiskoWdrozeniowe
    {
        public string Nazwa { get; set; }
        public string AdresIP { get; set; }
        public int AktualnaWersja { get; set; }
        public int PoprzedniaWersja { get; set; }

        public SrodowiskoWdrozeniowe(string nazwa, string adresip, int aktualnawersja, int poprzedniawersja)
        {
            if (!nazwa.Equals("") && (Convert.ToString(adresip).Length == 15 && (Convert.ToString(adresip).Contains("..."))))
            {
                Nazwa = nazwa;
                AdresIP = adresip;
                AktualnaWersja = 1;
                PoprzedniaWersja = 1;
            }
        }
        public void Aktualizuj(int wersja)
        {
            if (wersja == AktualnaWersja)
            {
                Console.WriteLine("Podana wersja jest aktualna");
            }
            if (wersja < AktualnaWersja)
            {
                throw new ArgumentException("blad");
            }
            else
            {
                PoprzedniaWersja = AktualnaWersja;
                AktualnaWersja = wersja;
            }
        }
        public void WycofajZmiany()
        {
            Console.WriteLine("Wycofywanie zmian");
            AktualnaWersja = PoprzedniaWersja;
        }
    }

}
