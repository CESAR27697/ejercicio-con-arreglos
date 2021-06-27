using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_5_CESAR
{
   
        class TALLER
        {
            //Atributos    
            private string[,] carros;
            private List<string> carrosAcumulados;
            private List<int> monto;
            private int indice;
            private int indiceS;
            //Constructor    
            public TALLER (int n)
            {
                //se ingresa el numero de la capacidad maxima de autos que pueden ingresar en el taller 
                N = n;
                Carros = new string[N, 2];
                Monto = new List<int>();
                CarrosAcumulados = new List<string>();
                IndiceS = 0;
                Indice = 0;
                for (int rows = 0; rows < N; rows++)
                {
                    for (int columns = 0; columns < 2; columns++)
                    {
                        Carros[rows, columns] = " - ";
                    }
                }
            }
            //metodo     
            public Boolean Meter(string placas, string nombreDueño)
            {
                if (Indice < N)
                {
                    for (int i = 0; i < N; i++)
                    {
                        if (Carros[i, 0] == " - ")
                        {
                            Indice = i; break;
                        }
                    }
                    Carros[Indice, 0] = placas;
                    Carros[Indice, 1] = nombreDueño; string value = $"{placas}, {nombreDueño}";
                    CarrosAcumulados.Add(value); return true;
                }
                return false;
            }
            public Boolean Sacar()
            {
                if (Indice - 1 >= 0)
                {
                    for (int i = 0; i < N; i++)
                    {
                        if (Carros[i, 0] != " - ")
                        {
                            Carros[i, 0] = Carros[i + 1, 0];
                            Carros[i, 1] = Carros[i + 1, 1];
                        }
                    }
                    Carros[N - 1, 0] = " - "; Carros[N - 1, 1] = " - "; return true;
                }
                return false;
            }
            public string EspacioDisponible()
            {
                String ans = "";
                for (int rows = 0; rows < N; rows++)
                {
                    ans += carros[rows, 0] + ", "; ans += carros[rows, 1] + "\n";
                }
                return ans;
            }
            public void Cobrar(int monto)
            {
                Monto.Add(monto);
            }
            public int[] GetMonto()
            {
                int[] AMonto = Monto.ToArray(); return AMonto;
            }
            public string[] GetCarrosAcumulados()
            {
                string[] ACarrosAcumulados = CarrosAcumulados.ToArray(); return ACarrosAcumulados;
            }
            //propiedades    
            public string[,] Carros
            {
                get => carros; set => carros = value;
            }
            public int N
            {
                get;
            }
            public List<int> Monto
            {
                get => monto; set => monto = value;
            }
            public int Indice
            {
                get => indice; set => indice = value;
            }
            public List<string> CarrosAcumulados
            {
                get => carrosAcumulados; set => carrosAcumulados = value;
            }
            public int IndiceS { get => indiceS; set => indiceS = value; }
        }
    }

