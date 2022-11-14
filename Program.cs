using System;

namespace ejercicio_23
{
    public class program
    {
        public static void Main()
        {
            int numer;
            int resultado;
            int doblado;

            Console.WriteLine("Por favor ingrese un número"); 
            
            numer = Convert.ToInt32(Console.ReadLine()); 
            
            doblado= numer * 2;

            resultado = doblado * 25;

            Console.WriteLine($" El resultado de la operacion es: {resultado}");
        }
    }
}