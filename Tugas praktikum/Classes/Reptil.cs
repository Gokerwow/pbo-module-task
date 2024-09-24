using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_praktikum.Classes
{
    public class Reptil : Hewan
    {
        public double panjangtubuh;

        public Reptil(string nama, int umur, double panjangtubuh) : base(nama, umur)
        {
            this.panjangtubuh = panjangtubuh;
        }

        public override string suara(string suara)
        {
            return $"{nama} sedang bersuara {suara}";
        }
    }
}
