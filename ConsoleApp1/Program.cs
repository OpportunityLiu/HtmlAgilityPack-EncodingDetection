using HtmlAgilityPack;
using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            var data = Convert.FromBase64String("PCFET0NUWVBFIGh0bWwgUFVCTElDICItLy9XM0MvL0RURCBYSFRNTCAxLjAgVHJhbnNpdGlvbmFsLy9FTiIgImh0dHA6Ly93d3cudzMub3JnL1RSL3hodG1sMS9EVEQveGh0bWwxLXRyYW5zaXRpb25hbC5kdGQiPgo8aHRtbCB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMTk5OS94aHRtbCI+Cgo8aGVhZD4KICAgIDxtZXRhIGh0dHAtZXF1aXY9IkNvbnRlbnQtVHlwZSIgY29udGVudD0idGV4dC9odG1sOyBjaGFyc2V0PWdiayIgLz4KICAgIDx0aXRsZT6y4srUX7LiytQ8L3RpdGxlPgo8L2hlYWQ+Cgo8L2h0bWw+");

            var doc0 = new HtmlDocument();
            doc0.Load(new MemoryStream(data), Encoding.UTF8);
            Console.WriteLine("Doc0:");
            Console.WriteLine(doc0.DocumentNode.OuterHtml);

            var doc1 = new HtmlDocument();
            doc1.Load(new MemoryStream(data));
            Console.WriteLine("Doc1:");
            Console.WriteLine(doc1.DocumentNode.OuterHtml);

            var doc2 = new HtmlDocument();
            Console.WriteLine("Doc2:");
            doc2.Load(new MemoryStream(data), doc1.DeclaredEncoding);
            Console.WriteLine(doc2.DocumentNode.OuterHtml);
        }
    }
}
