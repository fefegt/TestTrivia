using System.Runtime.InteropServices;

namespace TestTriviaConsola
{   
    internal class Program
    {
        static void SetTimer (int tiempoelegido)
        {
            bool ejecuta = true;

            switch (tiempoelegido) 
            {
                case 0:
                    tiempoelegido = 120;
                break;
                
                case 1:
                    tiempoelegido = 30;
                break;

                case 2:
                    tiempoelegido = 60;
                break;

                case 3:
                    tiempoelegido = 90;
                break;

                case 4:
                    try
                    {
                        Console.WriteLine("Ingrese la cantidad de segundos:");
                        tiempoelegido = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e) 
                    {
                        Console.WriteLine("Se produjo el error:{0}. Asegurese de ingresar un valor numerico", e.Message);
                        ejecuta = false;
                    }

                break;
            }

            if (ejecuta == true)
            {
                Juego newPlayer = new Juego();
                
                newPlayer.EjecutarJuego(tiempoelegido);
            }
        }
        
        
        static void Eleccion()
        {
            string[] opcionesContador = new string[5] { "0:Por defecto", "1:30 segundos", "2:60 segundos", "3:90 segundos", "4:Ingresar un tiempo personalizado"};
            int opcionElegida = 0;

            Console.WriteLine("\t\t*****************************************");
            Console.WriteLine("\t\t\tBienvenido a Tri-Movies");
            Console.WriteLine("\t\t*****************************************");
            Console.WriteLine("Seleccione una de las siguientes opciones para asignarle el tiempo al temporizador:");

            foreach (string o in opcionesContador)
            {
                Thread.Sleep(1500);
                Console.WriteLine(o);
            }

            Console.WriteLine("(Recuerde que la ronda terminara cuando el temporizador llegue a 0 y por defecto esta seteado en 2 minutos)");
            string input = Console.ReadLine();
            Console.Clear();

            opcionElegida = int.Parse(input);
            SetTimer(opcionElegida);
        }

        static void Main(string[] args)
        {
            Eleccion();
        }
    }
}