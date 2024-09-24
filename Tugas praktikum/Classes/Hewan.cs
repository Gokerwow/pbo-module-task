using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_praktikum.Classes
{
    public class Hewan
    {
        public string nama;
        public int umur;

        public Hewan(string nama, int umur)
        {
            this.nama = nama;
            this.umur = umur;
        }

        public virtual string suara(string suara)
        {
            return $"hewan sedang {suara}";
        }

        public virtual string infohewan()
        {
            return $"Nama Hewan : {nama}\nUmur Hewan : {umur}";
        }
    }
}
