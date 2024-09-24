using System;
using Tugas_praktikum.Classes;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            KebunBinatang kebunBinatang = new KebunBinatang();
            Ular ular1 = new Ular("kita", 10, 10);
            Singa singa1 = new Singa("hikam", 90, 5);
            Gajah gajah1 = new Gajah("jinak", 50, 6);
            Buaya buaya1 = new Buaya("fuka", 10, 10);

            Console.WriteLine(singa1.suara("aung"));
            kebunBinatang.TambahHewan(singa1);
            kebunBinatang.TambahHewan(gajah1);
            kebunBinatang.TambahHewan(ular1);
            kebunBinatang.TambahHewan(buaya1);

            Console.WriteLine(ular1.suara("ssss")); 
            ular1.infohewan();

            Console.WriteLine(singa1.suara("aung")); 
            singa1.infohewan();

            Console.WriteLine(gajah1.suara("purrr")); 
            gajah1.infohewan();

            Console.WriteLine(buaya1.suara("rawr"));
            buaya1.infohewan();

            kebunBinatang.daftarhewan();
        }
    }
}