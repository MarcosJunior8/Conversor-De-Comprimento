using System;

namespace Conversor_De_Comprimento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o número de medida");
            Comprimento cp1 = new Comprimento(Convert.ToDouble(Console.ReadLine()));
            


            Console.WriteLine(cp1.Quilometro + " kms");
            Console.WriteLine(cp1.Metro + " metros");
            Console.WriteLine(cp1.Centimetro + " cms"); 
            Console.WriteLine(cp1.Milimetro+ " milimetros"); 
            Console.WriteLine(cp1.Micrometro + " micrometros"); 
            Console.WriteLine(cp1.Nanometro + " nanometros"); 
            Console.WriteLine(cp1.Milha + " milhas");
            Console.WriteLine(cp1.Jarda + " jardas"); 
            Console.WriteLine(cp1.Pe + " pés");
            Console.WriteLine(cp1.Polegada + " polegadas"); 
            Console.WriteLine(cp1.Milhanautica + " milhasnauticas");
                  
        }
    }
}
