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
    class Oaie : Animal, IResursa
    {
        public int Cantitate
        {
            get
            {
                return 10;
            }
        }

        public string UnitateDeMasura
        {
            get
            {
                throw new NotImplementedException();
            }
        }

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
                return "Oaie romaneasca";
            }
        }

        public override IResursa ColecteazaResurse()
        {
            return new Lapte();
        }
    }
}
