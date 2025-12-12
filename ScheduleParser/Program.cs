using System;
using HtmlAgilityPack;

class Program
{
    static void Main()
    {
        var web = new HtmlWeb();
        string url = "https://www.polessu.by/ruz/?f=1&q=22%D0%98%D0%A2-2";

        HtmlDocument doc = web(url);

        var titleNode = doc.DocumentNode.SelectSingleNode("//title");

        Console.WriteLine(titleNode?.InnerText ?? "Заголовок не найден");
    }
}
