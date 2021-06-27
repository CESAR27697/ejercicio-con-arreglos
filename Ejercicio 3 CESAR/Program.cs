using System;

namespace Ejercicio_3_CESAR
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] datos = new int[20];
            Console.WriteLine("inserta los 20 numeros "); 
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingresa el numero " + (i + 1) + ": "); 
                datos[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear(); string ans = " ";
            Numeros numeros = new Numeros(datos); 
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"{datos[i]}{numeros.Solucion()[i]}\n");
            }
        }
    }
}
class Numeros
{
    int[] datos;
    public Numeros(int[] datos)
    {
        Datos = datos;
    }
    public int[] Solucion()
    {
        Array.Sort(Datos);
        return Datos;
    }
    public int[] Datos { get => datos; set => datos = value; }
}