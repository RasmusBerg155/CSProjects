using System;

namespace NewProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program translate from zip code to a city-name");
            // Read data from a user
            Console.Write("Input your zip- code:");
            // Read input from the user from the console
            string postcodeInputFromUser = Console.ReadLine();
            // create an object to hld the website data
            System.Net.WebClient wc = new System.Net.WebClient();
            // download data from website, insert UserInput in the url.
            //string webData = wc.DownloadString
        }
    }
}
