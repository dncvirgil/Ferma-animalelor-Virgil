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
    class Gaina : Animal
    {
        protected override IHrana HranaPreferata
        {
            get
            {
                return new Cereale();
            }
        }

        protected override string Rasa
        {
            get
            {
                return "Gaina romaneasca";
            }
        }

        public override IResursa ColecteazaResurse()
        {
            return new Ou();
        }
    }
}
