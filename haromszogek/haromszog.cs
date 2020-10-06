using System;
using System.Collections.Generic;

namespace haromszogek
{
    internal class haromszog
    {
        private double aOldal;
        private double bOldal;
        private double cOldal;

        public double Terulet { get; private set; }
        public double Kerulet { get; private set; }

        public bool Szerkesztheto { get; private set; }
        public List<string> AdatokSzoveg()
        {
            List<string> adatok = new List<string>();
            adatok.Add($"a: {aOldal} - b: {bOldal} - c: {cOldal}");
            if (Szerkesztheto)
            {
                adatok.Add($" Kerület: {Kerulet} - Terület {Terulet}");
            }
            else
            {
                adatok.Add("Nem szerkeszthető");
            }
            return adatok;
        }
        private void Szerk()
        {
            if (aOldal < bOldal + cOldal && bOldal < aOldal + cOldal && cOldal < aOldal + bOldal)
            {
                Szerkesztheto = true;
                Terulet = teruletSzamitas();
                Kerulet = keruletSzamitas();
            }
            
            else
            {
                Szerkesztheto = false;
                Terulet = 0;
                Kerulet = 0;
            }
        }
        private double teruletSzamitas()
        {
            double s = (aOldal + bOldal + cOldal) / 2;
            return Math.Sqrt(s*(s-aOldal)*(s-bOldal)*(s-cOldal));
            
        }
        private double keruletSzamitas()
        {
            return aOldal + bOldal + cOldal;

        }
        public haromszog(string sor)
        {
            string[] adatok = sor.Split(';');
            aOldal = Convert.ToDouble(adatok[0]);
            bOldal = Convert.ToDouble(adatok[1]);
            cOldal = Convert.ToDouble(adatok[2]);
            Szerk();
        }
        public haromszog(double aOldal,double bOldal, double cOldal)
        {
            this.aOldal = aOldal;
            this.bOldal = bOldal;
            this.cOldal = cOldal;
            Szerk();
        }
    }
}