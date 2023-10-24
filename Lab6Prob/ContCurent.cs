using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6Prob
{
    class ContCurent : ContBancar
    {
        private double descoperireContPlafon = 5000;

        public ContCurent(string nume) : base(nume) { }

        public override void Retrage(double suma)
        {
            double sumaDisponibila = soldCurent + descoperireContPlafon;

            if (suma <= sumaDisponibila)
            {
                if (suma <= soldCurent)
                {
                    base.Retrage(suma);
                }
                else
                {
                    double sumaDeRetrasDinDescoperire = suma - soldCurent;
                    soldCurent = 0;
                    descoperireContPlafon -= sumaDeRetrasDinDescoperire;
                    Console.WriteLine($"Suma de {suma} lei a fost retrasa din contul curent al lui {nume}.");
                }
            }
            else
            {
                Console.WriteLine($"Fonduri insuficiente in contul curent {nume}. Retragerea nu poate fi efectuata.");
            }
        }
    }
}
