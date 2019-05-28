using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FileDownloadApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://file-examples.com/wp-content/uploads/2017/02/zip_2MB.zip", "zip_2MB.zip");
            }
        }
    }
}
