using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxiifinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            taxigas taxi = new taxigas();

            Console.Write("Masukan Nama Driver : ");
            taxi.DriveName = Console.ReadLine();

            Console.Write("Masukan Jumlah Penumpang : ");
            taxi.NumPassenger = Convert.ToInt16(Console.ReadLine());

            if (taxi.NumPassenger > 0)
            {
                taxi.info();
                taxi.up();
                taxi.down(); ;

                Console.ReadLine();
            }
            else
                taxi.info();
            taxi.ngangur();

            Console.ReadLine();




        }
    }
}