using System;

namespace Ejercicio_5_CESAR
{
        class Program
        {
            static void Main(string[] args)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("taller mecanico");
                Console.ForegroundColor = ConsoleColor.White;
                TALLER taller = new TALLER(7);
                // se instancian los 5 numeros 
                Console.WriteLine(taller.EspacioDisponible());
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Te mostramos los espacios disponibles");
                Console.WriteLine("Al ingresar 'S' el programa se cerrara");
                char ans; char salir = 'f';
                while (salir != 'S')
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("¿Que es lo que desea hacer?");
                    Console.WriteLine("A)Meter en el taller \n");
                    Console.WriteLine("B)sacar del taller \n");
                    Console.WriteLine("Selecione una accion: ");
                    ans = char.ToUpper(Convert.ToChar(Console.ReadLine()));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear(); switch (ans)
                    {
                        case 'A':
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Ha seleccionado meter en el taller ");
                                Console.Write("Introduzca el numero de su placa: ");
                                Console.ForegroundColor = ConsoleColor.White;
                                string placa = Convert.ToString(Console.ReadLine());
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write("Introduzca su nombre porfavor : ");
                                Console.ForegroundColor = ConsoleColor.White;
                                string nombre = Convert.ToString(Console.ReadLine());
                                if (taller.Meter(placa, nombre) == false)
                                {
                                    Console.WriteLine("Lo sentimos, cupo llena");
                                    Console.ReadKey();
                                }
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Clear();
                                Console.WriteLine("Se ha actualizado la cupo del taller ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine(taller.EspacioDisponible());
                                Console.ReadKey(); break;
                            }
                        case 'B':
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("Ha seleccionado sacar");
                                if (taller.Sacar() == false)
                                {
                                    Console.WriteLine("Lo sentimos, cupo vacio");
                                    Console.ReadKey();
                                }
                                Console.WriteLine("Se ha actualizado la tabla de cupo");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine(taller.EspacioDisponible());
                                Console.ReadKey(); break;
                            }
                    }
                    Console.Clear();
                    Console.WriteLine("Para salir seleccione la letra S o para continuar seleccione cualquier otra tecla");
                    salir = char.ToUpper(Convert.ToChar(Console.ReadLine()));
                    Console.Clear();
                }
            }
        }
    }
