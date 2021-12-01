using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class NewsProvider
    {
        public delegate void NewsHandler(Categories category);
        public event NewsHandler Notify;

        public static List<News> NewsNews = new List<News>();
        public static List<News> WeatherNews = new List<News>();
        public static List<News> AccidentsNews = new List<News>();
        public static List<News> HumorNews = new List<News>();
        public static List<News> SportNews = new List<News>();
        public void AddCategories(Categories category)
        {
            Notify(category);
        }
        public void AddNews(Categories cat, News news)
        {
            switch (cat)
            {
                case Categories.News:
                    NewsNews.Add(news);
                    break;
                case Categories.Weather:
                    WeatherNews.Add(news);
                    break;
                case Categories.Accidents:
                    AccidentsNews.Add(news);
                    break;
                case Categories.Humor:
                    HumorNews.Add(news);
                    break;
                case Categories.Sport:
                    SportNews.Add(news);
                    break;
            }
        }
        public List<News> GettList(List<News> myList)
        {
            return myList;
        }
    }
}
