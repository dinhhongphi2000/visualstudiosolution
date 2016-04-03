using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace GroupByLinq
{
    class HOATDONG
    {
        public string SOHOATDONG { get; set; }
        public string MaHD { get; set; }
        public string TENHOATDONG { get; set; }
        public DateTime NGAY { get; set; }
        public Decimal SOTIEN { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<HOATDONG> database = new List<HOATDONG>
            {
                new HOATDONG {SOHOATDONG = "1",MaHD = "CD0000",TENHOATDONG = "TAO",SOTIEN = 100000, NGAY=new DateTime(2016,3,15) },
                new HOATDONG {SOHOATDONG = "2",MaHD = "CD0000",TENHOATDONG = "DONGLAI",SOTIEN = 10000,NGAY=new DateTime(2016,3,12) },
                new HOATDONG {SOHOATDONG = "3",MaHD = "CD0000",TENHOATDONG = "DONGLAI",SOTIEN = 10000 ,NGAY=new DateTime(2016,3,11)},
                new HOATDONG {SOHOATDONG = "4",MaHD = "CD0000",TENHOATDONG = "DONGLAI",SOTIEN = 10000 ,NGAY=new DateTime(2016,3,14)},
                new HOATDONG {SOHOATDONG = "5",MaHD = "CD0000",TENHOATDONG = "DONGLAI",SOTIEN = 10000 ,NGAY=new DateTime(2016,3,15)},
                new HOATDONG {SOHOATDONG = "6",MaHD = "CD0000",TENHOATDONG = "DONGLAI",SOTIEN = 10000 ,NGAY=new DateTime(2016,3,15)},
                new HOATDONG {SOHOATDONG = "7",MaHD = "CD0000",TENHOATDONG = "DONGLAI",SOTIEN = 10000 ,NGAY=new DateTime(2016,3,15)},
                new HOATDONG {SOHOATDONG = "8",MaHD = "CD0000",TENHOATDONG = "DONGLAI",SOTIEN = 10000 ,NGAY=new DateTime(2016,3,15)},
            };

            var hddonglai = (from hd in database
                             where (hd.TENHOATDONG == "DONGLAI") && database.Where(p => p.MaHD == hd.MaHD && p.TENHOATDONG == "DONGLAI").All(p => p.NGAY <= hd.NGAY)
                             select hd).GroupBy(p => p.NGAY);
            foreach(var t in hddonglai)
            {
                //Console.WriteLine(t.First().MaHD);
                Console.WriteLine("MaHD = {0}  | Ngay = {1}",t.First().MaHD,t.First().NGAY);
            }

            //foreach(var x in hddonglai)
            //{
            //    Console.WriteLine("MaHD = {0} | TENHOATDONG = {1} | NGAYTHANG = {2}", x.MaHD, x.TENHOATDONG, x.NGAY);
            //}
            Console.ReadLine();
        }
    }
}
