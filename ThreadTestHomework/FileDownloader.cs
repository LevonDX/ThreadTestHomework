using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ThreadTestHomework
{
    class FileDownloader
    {
        public void Download(string fileUrl, string fileName)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile(fileUrl, fileName);

                Console.WriteLine("Thread " + fileName);
                Thread.Sleep(5000);
            }
        }
    }
}
