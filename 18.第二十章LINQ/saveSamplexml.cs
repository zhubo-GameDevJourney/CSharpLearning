﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        XDocument xd = new XDocument(
            new XElement("MyElements",
                new XElement(
                    "first",
                    new XAttribute("color", "red"),
                    new XAttribute("size", "small")
                    ),
                new XElement(
                    "second",
                    new XAttribute("color", "red"),
                    new XAttribute("size", "medium")
                    ),
                new XElement(
                    "third",
                    new XAttribute("color", "blue"),
                    new XAttribute("size", "large")
                    )
            )
       );

        Console.WriteLine(xd);
        xd.Save("SimpleSample.xml");


     }
}
