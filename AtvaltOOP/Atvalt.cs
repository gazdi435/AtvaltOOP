using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvaltOOP
{
    internal class Atvalt
    {
        public Atvalt()
        {
            
        }

        public string BinarisraValtStringes(int megadottSzam)
        {
            return Convert.ToString(BinarisraValt(megadottSzam));
        }

        public string BinarisraValtStringes(string megadottSzam)
        {
            try
            {
                int szam = Convert.ToInt32(megadottSzam);
                return Convert.ToString(BinarisraValt(szam));
            }
            catch
            {
                throw new Exception("Nem érvényes decimális szám!");
            }
        }

        public int BinarisraValt(int megadottSzam)
        {
            if (megadottSzam < 0)
            {
                throw new ArgumentException("Csak nem-negatív számokat lehet binárisra váltani.");
            }

            int binarisSzam = 0;
            int helyiertek = 1;

            while (megadottSzam > 0)
            {
                int maradek = megadottSzam % 2;       
                binarisSzam += maradek * helyiertek;  
                megadottSzam /= 2;                    
                helyiertek *= 10;                     
            }

            return binarisSzam;
        }

        public string DecimalisbaValtStringes(int megadottSzam)
        {

            return Convert.ToString(DecimalisbaValt(megadottSzam));
        }



        public string DecimalisbaValtStringes(string megadottSzam)
        {
            string binarisSzam = Convert.ToString(megadottSzam);

            return Convert.ToString(DecimalisbaValt(binarisSzam));
        }

        public int DecimalisbaValt(int megadottSzam)
        {
            string binarisSzam = Convert.ToString(megadottSzam);

            return DecimalisbaValt(binarisSzam);
        }

        public int DecimalisbaValt(string binarisSzam)
        {
            if (Convert.ToInt32(binarisSzam) < 0)
            {
                throw new Exception("A szám nem lehet kissebb mint 0");
            }
            try
            {
                Convert.ToInt32(binarisSzam);
            }
            catch (Exception e)
            {

                throw new Exception("Nem szám!");
            }
            int atvaltottSzam = 0;

            for (int i = 0; i < binarisSzam.Length; i++)
            {
                char bit = binarisSzam[binarisSzam.Length - 1 - i]; 
                if (bit == '1')
                {
                    atvaltottSzam += (int)Math.Pow(2, i);
                }
                else if (bit != '0')
                {
                    throw new Exception("Nem lehet átfordítani!");
                }
            }

            return atvaltottSzam;
        }
    }
}
