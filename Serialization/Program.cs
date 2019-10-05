using System;

namespace Serialization
{
    public class XMLWriter
    {
        static void Main(string[] args)
        {
            WriteXML();
        }


        public class Book
        {
            public String title;
        }

        public static void WriteXML()
        {
            Book book = new Book();
            book.title = "Jordan's book";
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(Book));

            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationOverview.xml";
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, book);
            file.Close();
        }
    }
}
