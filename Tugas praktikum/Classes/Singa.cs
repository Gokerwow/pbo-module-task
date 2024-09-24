using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_praktikum.Classes
{
    public class Singa : Mamalia
    {
        public Singa(string nama, int umur, int jumlahkaki) : base(nama, umur, jumlahkaki)
        {

        }

        public void mengaung()
        {
            Console.WriteLine($"Singa {nama} sedang mengaung");
        }

        public override string suara(string suara)
        {
            return $"Singa {nama} sedang bersuara {suara}";
        }
    }
}
