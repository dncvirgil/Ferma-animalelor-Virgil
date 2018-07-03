using FermaAnimalelor.Hrana;
using FermaAnimalelor.Infrastructura;
using FermaAnimalelor.Resurse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermaAnimalelor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intr-o ferma se afla 3 vaci, 2 oi si 5 gaini. Defineste clasele corespunzatoare
            //folosind clasele si interfetele predefinite fara a le modifica in vreun fel si 
            // afiseaza raspunsurile la cele 4 intrebari de mai jos.

            //adauga animalele in lista predefinita
            var animale = new Animal[10];

            for (int i = 0; i < 10; i++)
            {
                if (i < 5)
                {
                    animale[i] = new Gaina();
                }
                else if (i == 5 || i < 8)
                {
                    animale[i] = new Vaca();
                }
                else
                {
                    animale[i] = new Oaie();
                }
            }

            //1. Tipareste numarul de gaini calculandul programatic

            foreach (var animal in animale)
            {
                Console.WriteLine(animal.GetType().ToString());
            }

            int numarGaini = 0;
            foreach (var animal in animale)
            {
                if (animal.GetType().ToString() == "FermaAnimalelor.Gaina")
                {
                    numarGaini++;
                }
            }
            Console.WriteLine($"Numarul de gaini din ferma este: {numarGaini}");



            //2. Hraneste animalele cu tipul de hrana adecvat. Tipurile de hrana vor fi definite
            // folosind IHRana si create in folderul Hrana

            Gaina gaina = new Gaina();
            IHrana hranaGaina = new Cereale();

            Console.WriteLine($"Gaina este granita: {gaina.AnimalHranit}");
            if (gaina.AnimalHranit == false)
            {
                gaina.Mananca(hranaGaina); // verific daca este hranita gaina
            }

            Console.WriteLine($"Gaina este granita: {gaina.AnimalHranit}"); 

            //3. Colecteaza toate resursele produse de animale (oua, lapte) si afisati totalul cantitatii
            //   colectate pentru fiecare din ele.
            //   Tipurile de resurse vor fi definite folosind IResursa si vor fi puse in folderul
            //   Resurse

            var ou =  gaina.ColecteazaResurse();
            Console.WriteLine($"Gaina a facut {ou.Cantitate} {ou.UnitateDeMasura} ou");


            //4. Pune animalele la somn. Pentru a ne asigura ca animalele sunt la somn se va 
            // verifica ca fiecare Animal este "AnimalAdormit"- proprietate disponibila pe clasa 
            // animal. 

            Console.WriteLine($"Gaina acum este adormita: {gaina.AnimalAdormit}");

            if (gaina.AnimalAdormit == false) //verific daca este adormita gaina
            {
                gaina.Doarme();
            }

            Console.WriteLine($"Gaina acum este adormita: {gaina.AnimalAdormit}");

            
            Console.ReadLine();
        }
    }
}
