using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Threading;

namespace WebClientDownloadAsyn
{
    class Program
    {
        static void Main(string[] args)
        {
            //WebClient client = new WebClient();
            //client.DownloadStringCompleted += (sender, eventArgs) =>
            //{
            //    using (FileStream sr = File.Create("D:\\music.mp3"))
            //    {
            //        Byte[] info = new UTF8Encoding(true).GetBytes(eventArgs.Result);
            //        sr.Write(info, 0, info.Length);
            //        Console.WriteLine("Xong");
            //    }
            //};

            //client.DownloadStringAsync(new Uri("http://aredir.nixcdn.com/cf9d647267708ec9b930535bd49e34b6/56e80c13/NhacCuaTui889/PhutCoDonNgayMua-HoangYenChibi-3819483.mp3"));
            //Console.ReadLine();

            //var Result = DoWorkAsync().Result;
            //Console.WriteLine(Result);
            //Console.WriteLine("Dinh Hong Phi");
            //Console.ReadLine();

            //DoWorkAsync().ContinueWith(task =>
            //{
            //    Console.WriteLine(task.Result);
            //});
            //Console.WriteLine("Hello phi");
            //Console.ReadLine();

            //Task_FromResult.main();

            HttpClient_RequestMessage.main();
        }



        //static Task<string> DoWorkAsync()
        //{
        //    return Task<string>.Factory.StartNew(()=> {
        //        Thread.Sleep(3000);
        //        return "Hello everyone...";
        //    });
        //}
    }
}
