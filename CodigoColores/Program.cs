using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoColores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string color;

            Console.Write("Digita el codigo RGB para convertilo en codigo:  ");
            color = Console.ReadLine();

            switch (color)
            {
                // Caso para el color rojo
                case "Red":
                case "RED":
                case "red":
                    Console.WriteLine("El codigo RGB {0} es 255, 0, 0 ", color);
                    break;

                // Caso para el color verde
                case "GREEN":
                case "Green":
                case "green":
                    Console.WriteLine("El codigo RGB {0} es 0, 255, 0 ", color);
                    break;

                // Caso para el color azul
                case "BLUE":
                case "Blue":
                case "blue":
                    Console.WriteLine("El codigo RGB {0} es 0, 0, 255 ", color);
                    break;

                // Caso por defecto cuando no se encuentra el código RGB para el color ingresado
                default:
                    Console.WriteLine("No se encuentra el codigo RGB para el color {0} ingresado, intenta de nuevo.  ", color);
                    break;
            }
        }
    }
}
