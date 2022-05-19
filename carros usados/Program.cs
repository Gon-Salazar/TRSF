using Carros;

Carro carro = new Carro ();
carro.Mileage = 100;
carro.Owner_Type = Owner_Type.Second;
carro.Fuel_type = Fuel_type.Diesel;
carro.Transmissior = Transmissior.Manual;

Console.WriteLine("{0}", carro.Name);
Console.WriteLine("{0}", carro.Location);
Console.WriteLine("{0}", carro.Year);