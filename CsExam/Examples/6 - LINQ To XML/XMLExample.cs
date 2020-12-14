using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace CsExam.Examples
{
    public class XmlExample
    {
        //            Create XML trees


        public void loadXml()
        {
            XElement purchaseOrder = XElement.Load("Examples\\6 - LINQ To XML\\PurchaseOrder.xml");
            IEnumerable<string> partNos = purchaseOrder.Descendants("Item").Select(x => (string)x.Attribute("PartNumber"));

            foreach (var item in partNos)
            {
                Console.WriteLine("The items are: {0}", item);
            }

            IEnumerable<XElement> pricesByPartNos = purchaseOrder.Descendants("Item")
                                        .Where(item => (int)item.Element("Quantity") * (decimal)item.Element("USPrice") > 100)
                                        .OrderBy(order => order.Element("PartNumber"));

            foreach (var item in pricesByPartNos)
            {
                Console.WriteLine("The items are: {0}", item);
            }
        }

        public static void XMLTree()
        {
            XElement contacts =
            new XElement("Contacts",
            new XElement("Contact",
                new XElement("Name", "Patrick Hines"),
                new XElement("Phone", "206-555-0144",
                    new XAttribute("Type", "Home")),
                new XElement("phone", "425-555-0145",
                    new XAttribute("Type", "Work")),
                new XElement("Address",
                    new XElement("Street1", "123 Main St"),
                    new XElement("City", "Mercer Island"),
                    new XElement("State", "WA"),
                    new XElement("Postal", "68042"))));


            Console.WriteLine(contacts);
        }

        //Programmet viser, hvordan man kan lave en XmlReader der indlæser fra en xml-fil
        public static void instaElements()
        {
            XmlReader r = XmlReader.Create("Examples\\6 - LINQ To XML\\books.xml");
            while (r.NodeType != XmlNodeType.Element)
                r.Read();
            XElement e = XElement.Load(r);

            foreach (var item in e.Elements())
            {
                Console.WriteLine("The elements are: {0}", item);
            }

            Console.WriteLine(e);
        }

        //C:\Users\NicolaiLarsen\source\repos\CsExam\CsExam\Examples\6 - LINQ To XML\books.xml


        //public static void Main()
        //{
        //    instaElements();

        //}

    }
}



