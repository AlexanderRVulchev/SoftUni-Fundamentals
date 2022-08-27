//Change the program in such a way, that you will be able to store a list of articles.
//You will not need to use the previous methods anymore (except the "ToString()").
//On the first line, you will receive the number of articles.
//On the next lines, you will receive the articles in the same format as in the previous problem:
//"{title}, {content}, {author}".Finally, you will receive a string: "title", "content" or an "author".
//Print the articles. 

using System;
using System.Collections.Generic;
using System.Linq;

public class Article
{
    public string Title { get; set; }

    public string Content { get; set; }

    public string Author { get; set; }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }

    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }
}

internal class Program
{
    static void Main()
    {
        int numberOfArticles = int.Parse(Console.ReadLine());
        List<Article> articlesList = new List<Article>();
        for (int i = 0; i < numberOfArticles; i++)
        {
            string[] articleInfo = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);
            Article newArticle = new Article(articleInfo[0], articleInfo[1], articleInfo[2]);
            articlesList.Add(newArticle);
        }
        Console.WriteLine(String.Join("\n", articlesList));
    }
}