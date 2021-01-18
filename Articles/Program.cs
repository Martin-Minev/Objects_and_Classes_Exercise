using System;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                             .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Article article = new Article(input[0], input[1], input[2]);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArg = Console.ReadLine()
                                  .Split(": ", StringSplitOptions.RemoveEmptyEntries);
                if (cmdArg[0]=="Edit")
                {
                    // input[0] = cmdArg[1];
                    article.Edit(cmdArg[1]);
                }
                else if (cmdArg[0] == "ChangeAuthor")
                {
                    // input[1] = cmdArg[1];
                    article.ChangeAuthor(cmdArg[1]);
                }
                else if (cmdArg[0] == "Rename")
                {
                    article.Rename(cmdArg[1]);
                  //  input[2] = cmdArg[1];
                }                  
            }
            Console.WriteLine(article.ToString());          
        }
    }
}

class Article
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }

    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public void Edit(string content)
    {
        Content = content;
    }
    public void ChangeAuthor(string author)
    {
        Author = author;
    }
    public void Rename(string title)
    {
        Title = title;
    }
    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}