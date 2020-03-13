using System.XML;
class Program{
    public static void Main(String[] args){
        try{
            String out = "";
            String formate = "xmlNodeType: {0, -12}, {1, 10}, {2}";
            XMLTextReader xmlReader = new xmlTextReader("BookData.xml");
            while(xmlReader.Read()){
                out = String,Formate(formate, (XmlReader.NodeType, xmlReader.Name), xmlReader.value);
                Console.WriteLine(out);
            }
        }catch(Exception ex){
            Console.WriteLine("error");
        }
    }
}