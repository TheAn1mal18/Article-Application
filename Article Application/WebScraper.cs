using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using CsvHelper;

namespace Article_Application
{
    public class WebScraper
    {
        public static List<string> ScrapeTitles(string source)
        {
            Console.WriteLine("Scraping Titles");

            string page = $"https://www.{source}.com";
            List<string> Titles = new List<string>();
            var web = new HtmlWeb();
            var doc = web.Load(page);

            if (source == "techspot")
            {
                var articles = doc.DocumentNode.SelectNodes("//*[@class = 'article-content']");

                foreach (var article in articles)
                {
                    var text = article.SelectSingleNode(".//h2");
                    if (text.InnerHtml.Trim().Split('"')[1].Contains("downloads") == true || text.InnerHtml.Trim().Split('"')[1].Contains("techspot") != true)
                    {
                        continue;
                    }
                    Titles.Add(text.InnerText.Trim());
                }
            }
            else if (source == "engagdet")
            {

            }

            return Titles;
        }

        public static List<string> ScrapeSummary(string source)
        {
            Console.WriteLine("Scraping Summary");
            string page = $"https://www.{source}.com";
            List<string> Summary = new List<string>();
            var web = new HtmlWeb();
            var doc = web.Load(page);

            if (source == "techspot")
            {
                var articles = doc.DocumentNode.SelectNodes("//*[@class = 'article-content']");

                foreach (var article in articles)
                {
                    Console.WriteLine("Grabing URL");
                    var text = article.SelectSingleNode(".//h2");
                    if (text.InnerHtml.Trim().Split('"')[1].Contains("downloads") == true || text.InnerHtml.Trim().Split('"')[1].Contains("techspot") != true)
                    {
                        continue;
                    }
                    Console.WriteLine(text.InnerHtml.Trim().Split('"')[1]);
                    doc = web.Load(text.InnerHtml.Trim().Split('"')[1]);
                    var Internal = doc.DocumentNode.SelectNodes("//*[@class = 'articleBody']");
                    foreach (var i in Internal)
                    {
                        Console.WriteLine("Grabing Summary");
                        var s = i.SelectSingleNode(".//p");
                        Summary.Add(s.InnerText.Trim());
                    }
                }
                Console.WriteLine("Finished");
                return Summary;
            }
            else if (source == "engagdet")
            {

            }

            return Summary;
        }
    }
}
