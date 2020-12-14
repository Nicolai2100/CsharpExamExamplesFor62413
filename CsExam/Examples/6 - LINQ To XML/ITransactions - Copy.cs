using System.Xml.Linq;

public class Example
{
    void instaElements()
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
                    new XElement("Postal", "68042")
                )
        )
    );
    }
}

