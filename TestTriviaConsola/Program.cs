namespace TestTriviaConsola
{
    internal class Program
    {
        static void SetTimer (int tiempoelegido)
        {
            switch (tiempoelegido) 
            {
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
                    tiempoelegido = 120;
                break;

                case 5:
                    Console.WriteLine("Ingrese la cantidad de segundos:");
                    tiempoelegido = int.Parse(Console.ReadLine());
                break;
            }
            

            for(int t=tiempoelegido; t >= 0; t--) 
            {
                tiempoelegido-=5;
                Console.WriteLine("Quedan {0} segundos para la siguiente ronda.", t);
                Thread.Sleep(1000);
                Console.Clear();
            }

        }
        
        
        static void Eleccion()
        {
            string[] opcionesContador = new string[] { "1:30 segundos", "2:60 segundos", "3:90 segundos", "4:120 segundos", "5:Ingresar un tiempo personalizado" };
            int opcionElegida = 0;

            Console.WriteLine("\t\t*****************************************");
            Console.WriteLine("\t\t\tBienvenido a Trivia");
            Console.WriteLine("\t\t*****************************************");
            Console.WriteLine("Seleccione una de las siguientes opciones para asignarle el tiempo al contador:");

            foreach (string o in opcionesContador)
            {
                Thread.Sleep(1500);
                Console.WriteLine(o);
            }

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