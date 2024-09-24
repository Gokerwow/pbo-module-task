using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_praktikum.Classes
{
    public class Buaya : Reptil
    {
        public Buaya(string nama, int umur, double panjangtubuh) : base(nama, umur, panjangtubuh)
        {

        }

        public override string suara(string suara)
        {
            return $"Buaya {nama} sedang bersuara {suara}";
        }
    }
}
