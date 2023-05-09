using System.ComponentModel.Design;

namespace Ejercicio16.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numeroingresado;

            Console.Write("Ingrese el Numero: ");
            numeroingresado = double.Parse(Console.ReadLine());

            if (numeroingresado >= 0)
            {
                Console.WriteLine($"El numero {numeroingresado} es Positivo");
            }
            else Console.WriteLine($"El numero {numeroingresado} es Negativo");

            

            
            }
        }
    }
