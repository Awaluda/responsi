using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman3418
{
    class Karyawan
    {
        public int nim     { get; set; }
        public string nama { get; set; }
        public int gaji    { get; set; }
        public int naikgaji{ get; set; }

        public Karyawan(int nim,string nama,int gaji)
        {
            this.nim = nim;
            this.nama = nama;

            if (gaji < 0)
            {
                this.gaji = 0;
            }
            else
            {
                this.gaji = 0;
            }

            double tmp = 0;
            tmp = 0.1 * gaji;
            naikgaji = Convert.ToInt32(tmp) + gaji;
        }
    }
}
