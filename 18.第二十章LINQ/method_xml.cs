using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        XDocument xd = XDocument.Load("D:\\computer_program_practice\\C#_practice\\CSPractice\\bin\\Debug\\net8.0\\SimpleSample.xml");
        XElement root = xd.Element("MyElements");

        var xyz = from e in root.Elements()
                  where e.Name.ToString().Length == 5
                  select new {e.Name, color = e.Attribute("color")};

        foreach (var e in xyz)
            Console.WriteLine(e);

        Console.WriteLine();

        foreach (var x in xyz)
            Console.WriteLine("{0,-6}, color : {1,-7}", x.Name, x.color.Value);
    }
}
