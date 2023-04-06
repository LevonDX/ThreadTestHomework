using static System.Net.WebRequestMethods;

namespace ThreadTestHomework
{
    internal class Program
    {
        static void Main()
        {
            string[] urls = new string[]
            {
                "https://images.pexels.com/photos/244206/pexels-photo-244206.jpeg?cs=srgb&dl=asphalt-auto-automobile-244206.jpg&fm=jpg",
                "https://img.freepik.com/premium-photo/red-premium-business-sedan-car-sports-configuration-white-background-3d-rendering_101266-26555.jpg?w=2000",
                "https://images.unsplash.com/photo-1616455579100-2ceaa4eb2d37?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8Ym13JTIwY2FyfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60"
            };

            DownloadManager downloadManager = new DownloadManager(urls);
            downloadManager.DownloadParallel();

            Console.WriteLine("All files downloaded");
        }
    }
}