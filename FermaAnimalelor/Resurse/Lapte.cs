using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FermaAnimalelor.Infrastructura;

namespace FermaAnimalelor.Resurse
{
    class Lapte : IResursa
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
                return "litri";
            }
        }
    }
}
