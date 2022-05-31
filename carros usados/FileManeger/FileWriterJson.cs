using Carros; 
using Newtonsoft.Json;

namespace Carros;

public class FileWriterJson : IFileWriter
{
    public void Write(List<Carro> carros, string path)
    {
        var json = JsonConvert.SerializeObject(carros);
        File.WriteAllText(path, json); 
    }
}