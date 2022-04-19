using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsipemrograman4330
{
    class Karyawan
    {
        //property
        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }

        //constructor
        public void Karyawan()
        {
            Console.WriteLine("No \tNIK/Nama \t Gaji Bulanan");
            Console.Write("{0}", Nik);
            Console.Write(" ");
            Console.Write("{0}", Nama);
            Console.Write("\t");
            if (GajiBulanan <= 0)
            {
                GajiBulanan = 0;
                Console.WriteLine("{0}", GajiBulanan);
            }
            else
            {
                Console.WriteLine("{0}", GajiBulanan);
            }


        }
        public void BonusGaji()
        {
            int Gaji = GajiBulanan;
            Gaji += (GajiBulanan * 10) / 100;
            Console.WriteLine("Asikkkk Kenaikan Gaji.........");
            Console.WriteLine("No\t NIK/Nama\t Gaji Bulanan\t");
            Console.Write("{0}", Nik);
            Console.Write(" ");
            Console.Write("{0}", Nama);
            Console.Write("\t");
            Console.WriteLine("{0}", Gaji);


        }


    }
}