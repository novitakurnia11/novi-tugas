using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace taxiifinal
{
    internal class taxigas
    {

        public string DriveName { get; set; }
        public Boolean OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void info()
        {
            Console.WriteLine("\n Taxi Info \n");
            Console.WriteLine("Nama Driver : {0}", DriveName);

            if (NumPassenger > 0)
            {
                Console.WriteLine("Kerja : Iya ", OnDuty);
            }
            else
            {

                Console.WriteLine("Kerja : Tidak", OnDuty);
            }
            Console.WriteLine("Jumlah Penumpang : {0}", NumPassenger);

        }
        public void ngangur()
        {
            Console.WriteLine("\n \n TIDAK BEKERJA \n \n", false);
        }
        public void up()
        {
            Console.WriteLine("\n {0} Sedang Menaikkan Penumpang", DriveName);
        }
        public void down()
        {
            Console.WriteLine("\n {0} Sedang Menurunkan Penumpang", DriveName);
        }
    }
}
