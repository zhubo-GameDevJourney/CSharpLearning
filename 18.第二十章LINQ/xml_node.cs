using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;


class Program
{
    static void Main()
    {
        XDocument books = new XDocument(
            new XElement("ProgrammingBooks",
                new XElement("book",
                    new XElement("Title", "C#入门经典"),
                    new XElement("Author", "John Sharp")
                ),
                new XElement("book",
                    new XElement("Title", ".NET设计模式"),
                    new XElement("Author", "Alice Wonder")

                )
            )
        );

        Console.WriteLine(books);

        XElement newbook1 = new XElement("book",
            new XElement("Title", "LINQ 实战"),
            new XElement("Author", "Bob Linq")
        );

        var root = books.Element("ProgrammingBooks")
            ?? throw new InvalidOperationException("根元素不存在");
        root.Add(newbook1);


        XElement secondBook = root.Elements("book").Skip(1).FirstOrDefault();
        XElement insertBook = new XElement("book",
            new XElement("Title", "XML高级编程"),
            new XElement("Author", "Charlie Xml")
        );
        secondBook.AddAfterSelf(insertBook);



        XElement firstBook = root.Elements("book").ElementAt(0);
        firstBook.SetElementValue("Author", "John Updates");


        Console.WriteLine();

        Console.WriteLine(books);

    }
}

