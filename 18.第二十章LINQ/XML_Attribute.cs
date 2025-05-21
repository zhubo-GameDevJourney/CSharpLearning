using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        XDocument xd = new XDocument(
            new XElement("root",
                new XAttribute("color", "red"),
                new XAttribute("size", "large"),
                new XElement("first")
                )

        );

       Console.WriteLine( xd.ToString() );
        Console.WriteLine();

        //使用Attribute获取属性
        XAttribute color = xd.Root.Attribute("color");
        XAttribute size = xd.Root.Attribute("size");

        Console.WriteLine($"color :{color.Value}, size : {size.Value}");
        Console.WriteLine();

        //使用SetAttributeValue修改或添加属性
        xd.Root.SetAttributeValue("size", "middle");
        xd.Root.SetAttributeValue("width", "narrow");
        Console.WriteLine(xd);
        Console.WriteLine();

        //使用Remove或SetAttributeValue删除属性
        xd.Root.Attribute("color").Remove();
        xd.Root.SetAttributeValue("width", null);
        Console.WriteLine(xd);

    }
}
