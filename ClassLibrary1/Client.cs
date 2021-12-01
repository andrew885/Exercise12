using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ClassLibrary1
{
    public class Client
    {
        public string Name { get; set; }
        public Client(string Name)
        {
            this.Name = Name;                
        }
        List<Categories> CategoriesList = new List<Categories>();
        public void GetNews(Categories category)
        {
            CategoriesList.Add(category);
        }
        public void ShowSubscriptions()
        {
            Console.Write(string.Concat(Name, " subscriptions are: "));
            foreach (var category in CategoriesList)
            {
                Console.Write(string.Concat(category,", "));
            }
        }               
        public void ShowNews()
        {
            Console.Write(string.Concat(Name, " news are: \n"));            
            foreach (var item in CategoriesList)
            {
                switch (item)
                {
                    case Categories.Weather:
                        Console.WriteLine(string.Concat("Weather : ", StringfromList(NewsProvider.WeatherNews)));
                        break;
                    case Categories.News:
                        Console.WriteLine(string.Concat("News : ", StringfromList(NewsProvider.NewsNews)));
                        break;
                    case Categories.Accidents:
                        Console.WriteLine(string.Concat("Accidents : ", StringfromList(NewsProvider.AccidentsNews)));
                        break;
                    case Categories.Humor:
                        Console.WriteLine(string.Concat("Accidents : ", StringfromList(NewsProvider.HumorNews)));
                        break;
                    case Categories.Sport:
                        Console.WriteLine(string.Concat("Accidents : ", StringfromList(NewsProvider.SportNews)));
                        break;
                }
            }
        }
        public static string StringfromList(List<News> myList)
        {
            string text = "";
            if (myList.Count == 0)
                return "There is no news";
            else
            {
                foreach (var item in myList)
                {
                    text += item.Text + ", ";
                }
            }            
            return text;
        }

    }
}
