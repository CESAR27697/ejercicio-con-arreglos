using System;

namespace Ejercicio__2_CESAR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("ingresa una linea de caracteres ");
            Console.Write("Ingresa el numero maxino de letras que quieres que tenga: ");
            Console.ForegroundColor = ConsoleColor.White; int n = int.Parse(Console.ReadLine()); 
            //arreglo
            char[] cadena = new char[n];   
            //almacenamiento de caracteres 
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Escribe el caracter " + (i + 1) + ": "); 
                cadena[i] = Convert.ToChar(Console.ReadLine());
            }
            Cadenas Ccadena = new Cadenas(cadena);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("indica aplicacion: ");
            Console.WriteLine("A) La cadena escrita al revés.");
            Console.WriteLine("B) La cadena en mayúsculas.");
            Console.WriteLine("C) La cadena anterior modificada según las siguientes reglas\n" +
                "A=4\n" +
                "I=1\n" +
                "S=5\n" +
                "B=8\n" +
                "E=3\n" +
                "T=7");
            Console.ForegroundColor = ConsoleColor.White;
            char ans = char.ToUpper(Convert.ToChar(Console.Read())); Console.Clear();
            switch (ans)//-- se verifica que opcion se escogio 
            {
                case 'A': Console.WriteLine(Ccadena.Reversa()); break;
                case 'B': Console.WriteLine(Ccadena.Mayusculas()); break;
                case 'C':
                    {
                        foreach (char c in Ccadena.Sustitucion())
                        {
                            Console.WriteLine(c);
                        }
                        break;
                    }
                default: Console.WriteLine("lo que a intyrducido es equivoco"); break;
            }
        }
    }
}
//interfas
interface ICadenas
{
    string Reversa(); string Mayusculas(); char[] Sustitucion();
}
// Clase derivada
class Cadenas : ICadenas
// Atributos
{
    char[] charArr; string cadena;
    // Constructor     
    public Cadenas(char[] cadena)
    {
        CharArr = cadena;
    }
    //Propiedades  
    public char[] CharArr { get => charArr; set => charArr = value; }
    public string Cadena { get => cadena; set => cadena = value; }
    //Metodos de la aplicacion

    //convirerte la cadena en mayusculas
    public string Mayusculas() 
    {
        string ans = "";
        // Rcore el arreglo para agregar a la cadena
        foreach (char c in CharArr)
        {
            ans += char.ToUpper(c) + "\n";
        }
        return ans;
    }
    public string Reversa()
    {
        string ans = "";
        //recorre y guarda consecutivamente
        for (int i = CharArr.Length - 1; i != -1; i--) 
        {
            ans += CharArr[i] + "\n";
        }
        return ans;
    }
    public char[] Sustitucion()
    {
        //recorre el arreglo solamente
        for (int i = 0; i < CharArr.Length; i++)
        {
            //evalua el caracter quye quyere sustituir
            switch (CharArr[i])
            {
                case 'A': CharArr[i] = '4'; break;
                case 'I': CharArr[i] = '1'; break;
                case 'S': CharArr[i] = '5'; break;
                case 'B': CharArr[i] = '8'; break;
                case 'E': CharArr[i] = '3'; break;
                case 'T': CharArr[i] = '7'; break;
            }
        }
        return CharArr;
    }
}

