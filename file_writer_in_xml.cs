using System.Xml;
class Progrma{
    public static void Main(String[] args){
        XMLTextWriter writer = new XMLTextWriter("BookData.xml", null);
        writer.WriteStartElement("Books");

        writer.WriteElementString("id", "1");
        writer.WriteElementString("title", "c++");
        writer.WriteElementString("price", "250");

        writer.WriteElementString("id", "2");
        writer.WriteElementString("title", "c");
        writer.WriteElementString("price", "350");

        writer.WriteElementString("id", "3");
        writer.WriteElementString("title", "c#");
        writer.WriteElementString("price", "500");

        writer.WriteEndElement();
        writer.close();
        Console.WriteLine("one xml file created");
    }
}