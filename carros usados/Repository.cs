namespace Carros;
public class Repository
{     
    public List<Carro> ListCarros { get; set; }
    private bool LoadedFile {get; set;} = false;
   
    public void LoadFile(String filename)
    { 
        try 
        { 
            ListCarros = new List<Carro>();
            var listCarroStrings = FileReader.ReadFile(filename);               
            foreach (var item in listCarroStrings.Skip(1).Take(20))
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

    public List<Carro> GetCarroByName (String Name)
    { 
        Console.WriteLine("busacando nombre de carro");
        if(LoadedFile == false)
        {
           throw new Exception("No se ha cargado el archivo");
        }
        return ListCarros.Where(m => m.Name.Contains(Name)).ToList();
    }
}