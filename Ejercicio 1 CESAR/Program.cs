using System;

namespace Ejercicio_1_CESAR
{
    class Program
    {
        static void Main(string[] args)
        {
            // este arreglo sirve como almacenamiento de los datos 
            int[] datos = new int[10];
            //acontinuacion 
            Numeros numeros = new Numeros(datos);
            //guardan los datos en el objeto
            for (int i = 0; i < datos.Length; i=i+1)
            {
                Console.WriteLine("este programa le alludara a multiplicar 10 numeros \n");
                Console.Write($"Escribir el numero{(i + 1)}: "); datos[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            Console.Clear();
            Console.WriteLine("Programa de ayuda multiple con 10  numeros \n");
            Console.WriteLine("Que opiciones son las que ocupas?: ");
            Console.WriteLine("A) Sumatoria de los 10 elementos:  ");
            Console.WriteLine("B)Promedio de los elementos leídos:  ");
            Console.WriteLine("C)Número más grande de los números leídos:  ");
            Console.WriteLine("D)Número más pequeño de los números leídos");
            char ans = char.ToUpper(Convert.ToChar(Console.ReadLine())); switch (ans)
            {
                case 'A': Console.WriteLine(numeros.Suma()); break;
                case 'B': Console.WriteLine(numeros.Promedio()); break;
                case 'C':
                    {
                        int[] Ians = numeros.Ordenar(); Console.WriteLine(Ians[0]); break;
                    }
                case 'D':
                    {
                        int[] Ians = numeros.Ordenar(); Console.WriteLine(Ians[9]); break;
                    }
                default: Console.WriteLine("No la opcion seleccionada"); break;
            }
        }
    }
}
//Clase Derivada
class Numeros : IDatos
{
    private double ans;
    //Atributos    
    private int[] datos;
    //Construcotor
    public Numeros(int[] datos)
    {
        Datos = datos;
    }
    //en lo siguienten insertamos los metodos     
    public double Suma()
    {
        for (int i = 0; i < Datos.Length; i=i+1)
        {
            this.ans += Datos[i];
        }
        return ans;
    }
    public double Promedio()
    {
        this.ans = this.Suma() / Datos.Length; return ans;
    }
    public int[] Ordenar()
    {
        Array.Reverse(Datos); return Datos;
    }
    //propiedaqdes 
    public int[] Datos { get => datos; set => datos = value; }
}
//Interfas 
interface IDatos
{
    double Suma(); double Promedio(); int[] Ordenar();
}
