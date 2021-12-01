using System;
using ClassLibrary1;

namespace Exercise12
{
    class Program
    {       
        static void Main(string[] args)
        {
            NewsProvider CNN = new NewsProvider();
            Client client1 = new Client("Bob");

            CNN.Notify += client1.GetNews;
            CNN.AddCategories(Categories.News);
            CNN.AddCategories(Categories.Accidents);
            CNN.AddCategories(Categories.Weather);
            CNN.AddNews(Categories.Weather, new News("Rain is falling"));
            CNN.AddNews(Categories.Weather, new News("Sun is shinnig"));
            CNN.AddNews(Categories.News, new News("London is a capital of GreatBritain"));

            client1.ShowSubscriptions();
            Console.WriteLine();
            client1.ShowNews();

            CNN.AddNews(Categories.Accidents, new News("Versailles rail accident has happenned"));
            Console.WriteLine();
            client1.ShowNews();
        }        
    }
}
