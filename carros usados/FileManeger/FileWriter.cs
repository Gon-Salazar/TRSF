namespace Carros;
public interface IFileWriter
{
    public void Write(List<Carro> carro, string path);
}