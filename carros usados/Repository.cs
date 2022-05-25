namespace Carros;
public class Repository
{     
    public List<Carros> ListCarros { get; set; }
    private bool LoadedFile {get; set;} = false;
   
    public void LoadFile(String filename)
    { 
        try 
        { 
            ListCarros = new List<Carros>();
            var listMovieStrings = FileReader.ReadFile(filename);               
            foreach (var item in listMovieStrings.Skip(1).Take(20))
            {
              //  Console.WriteLine(item);
                var parser = new Parser();
                var carro = parser.Parse(item);
                ListCarros.Add(carro);
            } 
        }
        catch(Exception ex)
        { 
            Console.WriteLine(ex.Message);
        }
        LoadedFile = true;
    } 

    public List<Carro> GetAll ()
    {         
        if(LoadedFile == false)
        {
           throw new Exception("No se ha cargado el archivo");
        }
        return ListCarros;
    }

    public List<Carro> GetMovieByName (String Name)
    { 
        Console.WriteLine("busacando nombre de carro");
        if(LoadedFile == false)
        {
           throw new Exception("No se ha cargado el archivo");
        }
        return ListCarros.Where(m => m.Name.Contains(Name)).ToList();
    }
}