namespace Carros;
public class FileReader 
{

    public static List<string> ReadFile (String path)
    {
        return File.ReadAllLines(path).ToList();
    }
    
}