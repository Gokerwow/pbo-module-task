using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_praktikum.Classes
{
    public class Ular : Reptil
    {
        public Ular(string nama, int umur, double panjangtubuh) : base(nama, umur, panjangtubuh)
        {

        }

        public void merayap()
        {
            Console.WriteLine("Ular sedang merayap");
        }

        public override string suara(string suara)
        {
            return $"Ular {nama} sedang bersuara {suara}";
        }
    }
}
