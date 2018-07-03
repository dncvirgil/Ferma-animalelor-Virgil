using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FermaAnimalelor.Infrastructura;

namespace FermaAnimalelor.Resurse
{
    class Ou : IResursa
    {
        public int Cantitate
        {
            get
            {
                return 1;
            }
        }

        public string UnitateDeMasura
        {
            get
            {
                return "bucata";
            }
        }
    }
}
