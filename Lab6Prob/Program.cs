using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6Prob
{
    class Program
    {
            /*
* Scrieti un program care va modela conturi bancare. Un cont bancar poate fi cont de economii,
cont de investitii sau cont curent si va fi caracterezat de un nume.

• In toate conturile vom putea depune bani.

 La depunerea banilor soldul curent va crește cu valoarea depusa
Din toate conturile vom putea extrage bani

 În situatia in care suma ceruta depașește soldul curent, pe ecran va fi afișat un mesaj
corespunzator iar suma nu va fi extrasa.

• Contul curent
 La extragerea numerarului dintr-un cont curent, in cazul in care suma extrasa este mai mare
decat cea disponibila in cont, contul va permite descoperirea de cont in limita plafonului de 5000
ron.

 Daca suma ceruta depaseste plafonul descoperirii de cont, atunci pe ecran va fi afișat un mesaj
corespunzator iar suma nu va fi extrasa.

• Contul de economii

 Este carecterizat de o rata a dobanzii.

 Dupa fiecare depunere, soldul contului de economii va fi reactualizat tinandu-se cont de rata
dobanzii :

 ValoareSold = ValoareSold*(1+rataDobanzii)
            */
             static void Main()
            {
                ContBancar cont1 = new ContEconomii("Ion", 0.15);
                ContBancar cont2 = new ContInvestitii("Maria", 20);
                ContBancar cont3 = new ContCurent("Alex");

                cont1.Depune(1000);
                cont1.Retrage(500);

                cont2.Depune(2000);
                cont2.Retrage(2500);

                cont3.Depune(3000);
                cont3.Retrage(2000);

                Console.ReadKey();
            }
        }
    }
