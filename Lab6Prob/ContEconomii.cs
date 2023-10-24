using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6Prob
{
    class ContEconomii : ContBancar
    {
        private double rataDobanzii;

        public ContEconomii(string nume, double rataDobanzii) : base(nume)
        {
            this.rataDobanzii = rataDobanzii;
        }

        public override void Depune(double suma)
        {
            base.Depune(suma);
            ReactualizeazaSold();
        }

        private void ReactualizeazaSold()
        {
            soldCurent *= (1 + rataDobanzii);
            Console.WriteLine($"Soldul contului de economii a fost reactualizat la {soldCurent} lei cu rata de dobanda {rataDobanzii * 100}%.");
        }

        public ContEconomii(string nume) : base(nume) { }

        public override void Retrage(double suma)
        {
            if (suma <= soldCurent)
            {
                base.Retrage(suma);
                //Console.WriteLine($"Suma de {suma} lei a fost retrasa din contul de economii al lui {nume}.");
                ReactualizeazaSold();
            }
            else
            {
                Console.WriteLine($"Fonduri insuficiente in contul de economii al lui {nume}. Retragerea nu poate fi efectuata.");
            }
        }
    }
}

