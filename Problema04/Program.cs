using System;

namespace Problema04
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            try
            {
                Console.WriteLine("{0} - {1} - {2}", a, b);
            }
            catch (FormatException) {
                Console.WriteLine("Error. No coincide la cantidad de argumentos con la cantidad de parámetros.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
