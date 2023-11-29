using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.News_Publisher_Subscriber_Example
{
    public class NewsArticle
    {
        public string Title { get; }
        public string Content { get; }

        public NewsArticle(string Title, string Content)
        {
            this.Title = Title;
            this.Content = Content;
        }
    }
    public class NewsPublisher
    {
        public event EventHandler <NewsArticle> NewsArticlePublished;

        public void PublishNews(string Title, string Content)
        {
            NewsArticle newsArticle = new NewsArticle(Title, Content);
            NewsArticlePublished?.Invoke(this, newsArticle);
        }

    }

    public class NewsSubscriber
    {
        public string Name { get; }

        public NewsSubscriber(string name)
        {
            Name = name;
        }
        public void Subscribe(NewsPublisher publisher)
        {
            publisher.NewsArticlePublished += HandleNewsPublished;
        }

        public void UnSubscribe(NewsPublisher publisher)
        {
            publisher.NewsArticlePublished -= HandleNewsPublished;
        }
        public void HandleNewsPublished(object sender,  NewsArticle newsArticle)
        {
            Console.WriteLine($"{Name} recieved published news.");
            Console.WriteLine($"Title : {newsArticle.Title}");
            Console.WriteLine($"Content : {newsArticle.Content}\n");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            NewsPublisher newsPublisher = new NewsPublisher();
            NewsSubscriber newsSubscriber = new NewsSubscriber("Mohamed");

            newsSubscriber.Subscribe(newsPublisher);
            newsPublisher.PublishNews("Egypt", "Egypt is my favourite country");

            newsSubscriber.UnSubscribe(newsPublisher);
            newsPublisher.PublishNews("Egypt", "Egypt is my favourite country");

        }
    }
}
