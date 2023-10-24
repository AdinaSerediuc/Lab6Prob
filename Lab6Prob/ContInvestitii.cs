using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6Prob
{
    class ContInvestitii : ContBancar
    {
        // public ContInvestitii(string nume) : base(nume) { }
        private int ziuaTermenExtragere;

        public ContInvestitii(string nume, int ziuaTermenExtragere) : base(nume)
        {
            this.ziuaTermenExtragere = ziuaTermenExtragere;
        }

        public override void Depune(double suma)
        {
            base.Depune(suma);
            Console.WriteLine($"Suma de {suma} lei a fost depusa in contul de investitii al lui {nume}.");
        }

        public override void Retrage(double suma)
        {
            if (DateTime.Now.Day >= ziuaTermenExtragere)
            {
                base.Retrage(suma);
                Console.WriteLine($"Suma de {suma} lei a fost retrasa din contul de investitii al lui {nume}.");
            }
            else
            {
                Console.WriteLine($"Extragerea banilor din contul de investitii al lui {nume} este posibila doar dupa ziua {ziuaTermenExtragere}.");
            }
        }
    }
}

