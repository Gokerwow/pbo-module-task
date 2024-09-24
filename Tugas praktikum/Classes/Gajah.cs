using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_praktikum.Classes
{
    public class Gajah : Mamalia
    {
        public Gajah(string nama, int umur, int jumlahkaki) : base(nama, umur, jumlahkaki)
        {

        }

        public override string suara(string suara)
        {
            return $"Ular {nama} sedang bersuara {suara}";
        }
    }
}
