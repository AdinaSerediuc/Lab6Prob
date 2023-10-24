using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6Prob
{
    class ContBancar
    {
        protected string nume;
        protected double soldCurent;

        public ContBancar(string nume)
        {
            this.nume = nume;
            this.soldCurent = 0;
        }

        public virtual void Depune(double suma)
        {
            soldCurent += suma;
            Console.WriteLine($"Suma de {suma} lei a fost depusa in contul lui {nume}.");
        }

        public virtual void Retrage(double suma)
        {
            if (suma <= soldCurent)
            {
                soldCurent -= suma;
                Console.WriteLine($"Suma de {suma} lei a fost retrasa din contul lui {nume}.");
            }
            else
            {
                Console.WriteLine($"Fonduri insuficiente in contul lui {nume}. Retragerea nu poate fi efectuata.");
            }
        }

        private void RetrageSuma(double suma)
        {
            soldCurent -= suma;
            Console.WriteLine($"Suma de {suma} lei a fost retrasa din contul lui {nume}.");
        }
    }
}
