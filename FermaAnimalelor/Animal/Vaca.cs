using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FermaAnimalelor.Infrastructura;
using FermaAnimalelor.Hrana;
using FermaAnimalelor.Resurse;

namespace FermaAnimalelor
{
    class Vaca : Animal
    {
        protected override IHrana HranaPreferata
        {
            get
            {
                return new Iarba();
            }
        }

        protected override string Rasa
        {
            get
            {
                return "Vaca romaneasca";
            }
        }

        public override IResursa ColecteazaResurse()
        {
            return new Lapte();
        }
    }
}
