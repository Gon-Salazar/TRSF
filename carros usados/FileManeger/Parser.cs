using Carros;
 public class Parser
 {
     public Carro Parse(string line)
     {
         var carro = new Carro();
         var values = line.Split(',');
         carro.ID = int.Parse(values[0]);
         carro.Mileage = 100;
         if(Enum.TryParse<Transmissior>(values[7], out var Transmissior))
         {
             carro.Transmissior = Transmissior;
         }
         carro.Name = values [1];
         carro.Location = values[2];
         return carro;

     }
 }
