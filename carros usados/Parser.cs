using libraryone;

 public class Parser
 {
     public Carro Parse(string line)
     {
         var carro = carro();
         var values = line.Split(´,´);
         carro.Mileage = 100;
         carro.Transmissior = long.Parse(values[0]);
         carro.Name = values(1);
         carro.Location = (location)Enum.Parse(typeof(location), values{2});

     }
 }
