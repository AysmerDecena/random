using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = "Esta es una frase estática que si quieres puedes cambiarla";
            Console.WriteLine("Frase original: " + frase);

            Console.WriteLine("Presiona la tecla de espacio para reemplazar dos caracteres por un signo _");

            string fraseModificada = frase;

            while (!fraseModificada.Replace("_", "").Equals(""))
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.Spacebar)
                {
                    Random random = new Random();
                    int caracteresReemplazados = 0;

                    while (caracteresReemplazados < 2)
                    {
                        int indice = random.Next(fraseModificada.Length);
                        if (fraseModificada[indice] != '_')
                        {
                            fraseModificada = fraseModificada.Remove(indice, 1).Insert(indice, "_");
                            caracteresReemplazados++;
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("Frase modificada: " + fraseModificada);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Se han reemplazado todos los caracteres. Frase final: " + fraseModificada);

            Console.WriteLine("Presiona cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
