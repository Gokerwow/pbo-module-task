using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_praktikum.Classes
{
    public class Mamalia : Hewan
    {
        public int jumlahkaki;

        public Mamalia(string nama, int umur, int jumlahkaki) : base(nama, umur)
        {
            this.jumlahkaki = jumlahkaki;
        }

        public override string suara(string suara)
        {
            return $"{nama} sedang bersuara {suara}";
        }
    }
}
