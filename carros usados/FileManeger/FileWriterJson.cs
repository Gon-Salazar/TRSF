using Newtonsoft.Json;

namespace Carros;

public class FileWriterJson : IFileWriter
{
    public void Write(List<Carro> corros, string path)
    {
        var json = JsonConvert.SerializeObject(carro);
        File.WriteAllText(path, json); 
    }
}