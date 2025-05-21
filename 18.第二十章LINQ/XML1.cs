using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;


class Program
{
    static void Main()
    {
        XDocument employeeDoc =
        new XDocument(
            new XElement("Employees",
                new XElement("Employee",
                    new XElement("Name", "Bob smith"),
                    new XElement("PhoneNumber", "408-555-1000")
            ),

                new XElement("Employee",
                    new XElement("Name", "Sally Jones"),
                    new XElement("PhoneNumber", "415-555-2000")
            )
            )
        );


        XElement root = employeeDoc.Element("Employees");
        IEnumerable < XElement > employees = root.Elements();

        foreach ( XElement employee in employees )
        {
           XElement empNameNode = employee.Element("Name");
            Console.WriteLine(empNameNode.Value);

           XElement empPhoe = employee.Element("PhoneNumber");
            Console.WriteLine($"    {empPhoe.Value}");
        }
    }
}