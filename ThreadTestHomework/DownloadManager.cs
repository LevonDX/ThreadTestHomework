using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadTestHomework
{
    class DownloadManager
    {
        IEnumerable<string> urls;

        public DownloadManager(IEnumerable<string> urls)
        {
            this.urls = urls;
        }

        public DownloadManager(params string[] urls)
        {
            this.urls = urls;
        }

        void F(int a)
        {

        }

        public void DownloadParallel()
        {
            Thread[] threads = new Thread[this.urls.Count()];

            int i = 0;
            FileDownloader downloader = new FileDownloader();

            foreach (var url in this.urls)
            {
                string fileName = (i + 1).ToString();

                threads[i] = new Thread(() => downloader.Download(url, fileName + ".jpg"));
                threads[i].Start();
                i++;
            }

            foreach (var thread in threads)
            {
                thread.Join();
            }
        }
    }
}
