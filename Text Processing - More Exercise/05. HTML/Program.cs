//You will receive 3 lines of input. On the first line, you will receive a title of an article.
//On the next line, you will receive the content of that article.
//On the next n lines until you receive "end of comments" you will get the comments about the article.
//Print the whole information in HTML format.
//The title should be in "h1" tag (<h1></h1>); the content in article tag (<article></article>);
//each comment should be in div tag (<div></div>).

using System;
using System.Collections.Generic;

internal class Program
{
    static void Main()
    {
        string title = Console.ReadLine();
        string article = Console.ReadLine();
        List<string> comments = new List<string>();
        string input;

        while ((input = Console.ReadLine()) != "end of comments")
            comments.Add(input);

        Console.WriteLine($"<h1>\n    {title}\n</h1>");
        Console.WriteLine($"<article>\n    {article}\n</article>");
        foreach (string comment in comments)
            Console.WriteLine($"<div>\n    {comment}\n</div>");
    }
}
