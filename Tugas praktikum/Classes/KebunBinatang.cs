using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_praktikum.Classes
{
    public class KebunBinatang
    {
        public List<Hewan> KoleksiHewan = new List<Hewan>();


        public void TambahHewan(Hewan hewan)
        {
            KoleksiHewan.Add(hewan);
            Console.WriteLine($"{hewan.nama} telah ditambahkan ke kebun binatang.");
        }

        public void daftarhewan()
        {
            foreach(var hewan in this.KoleksiHewan)
            {
                Console.WriteLine($"hewan ini bernama {hewan.nama} berumur {hewan.umur}");
            }
            
        }
    }
}
