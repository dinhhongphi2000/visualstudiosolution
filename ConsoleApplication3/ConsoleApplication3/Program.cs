using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Net.Http;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x = splitAddress("http://stackoverflow.com/questions");
            for(int i =0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
            Console.ReadLine();
        }

        public static string[] splitAddress(string address)
        {
            List<string> a = new List<string>();
            string x = "";
            int i = 0;
            while (address != "")
            {
                if (address[0] >= 'a' && address[0] <= 'z')
                {
                    x += address[0];
                }
                else {
                    if (x != "com" && x != "")
                    {
                        a.Add(x);
                        x = "";
                    }
                    else if (x == "com") x = "";
                }
                address = address.Substring(1,address.Length - 1);
            }
            string[] b = new string[a.Count];
            for (int k = 0; k < a.Count; k++)
            {
                b[k] = a[k];
            }
            return b;
            return b;
        }

    }
}
