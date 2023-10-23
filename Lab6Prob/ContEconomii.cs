using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6Prob
{
    class ContEconomii : ContBancar
    {

        public ContEconomii(string nume) : base(nume) { }

        public override void Retrage(double suma)
        {
            if (suma <= soldCurent)
            {
                base.Retrage(suma);
                Console.WriteLine($"Suma de {suma} lei a fost retrasa din contul de economii al lui {nume}.");
            }
            else
            {
                Console.WriteLine($"Fonduri insuficiente in contul de economii al lui {nume}. Retragerea nu poate fi efectuata.");
            }
        }
    }
}

