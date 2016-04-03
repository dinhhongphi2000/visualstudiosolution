using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace WebClientDownloadAsyn
{
    class HttpClient_RequestMessage
    {
        public static void main()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, new Uri("http://genk.vn"));
            request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("text/htl"));
            Console.WriteLine(request.ToString());
            Console.ReadLine();
        }
    }
}
