using System.Xml.Serialization;

namespace Carros;

public class FileWriterXml : IFileWriter
{
    public void Write(List<Movie> carro, string path)
    {
        var serializer = new XmlSerializer(typeof(List<Carro>));
        using (var writer = new StreamWriter(path))
        {
            serializer.Serialize(writer, Carro);
        }
    }
}