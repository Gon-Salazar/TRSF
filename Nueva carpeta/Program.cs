using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace numerovalorabsoluto
{
    public class program
    {
        static void Main(string []args)
        {
        int numero;
        Console.Writeline("ingresar un numero");
        numero = int.Parse(Console.ReadLine());
        if (numerovalorabsoluto > 0)
        {
            Console.Writeline("el numero es:" + numero + "y su valor es:" +Math.Abs(numero));   
        }
        else
        {
            Console.Writeline("el numero es:" + numero);
            Console.ReadKey();
        
        }
        }
    }
}    
