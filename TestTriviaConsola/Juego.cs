namespace TestTriviaConsola
{
    public class Juego
    {    
        static int Puntaje = 0;
        static int Vidas = 5;

        int[] id = new int[3] {1, 2, 3};
        string[] pistas = new string[3] { "Estrenada en 2022. Dirigida por Robert Eggers. Protagoniza:Alexander Skasgard", "Estrenada en 2008. Dirigida por Chistopher Nolan. Protagoniza:Hugh Jackman", "Estrenada en 2022. Dirigida por Matt Reeves. Protagoniza:Robert Pattinson" };
        string[] peliculas = new string[3] { "The Northman", "The Prestige", "The Batman" };

        Random i = new Random();

        static void AgregarPuntaje()
        {
           Puntaje++;
        }

        static void EliminarVida()
        {
          Vidas--;
        }

        internal void EjecutarJuego(int timeselected)
        { 
            for(int cuentaRegresiva = 5; cuentaRegresiva > 0; cuentaRegresiva--) 
            {
                Console.WriteLine("Quedan {0} segundos para que arranque la ronda!!", cuentaRegresiva);
                Thread.Sleep(1000);
                Console.Clear();
            }

            while (timeselected != 0 || Vidas > 0 || Puntaje != 3)
            {
                for (int indice = ; indice >= peliculas.Length; indice++)//Falta un valor de inicializacion
                {
                    Console.WriteLine("Las opciones de peliculas son: {0}", peliculas[]);//Falta un indice
                    Console.WriteLine("La pista es: {0}", pistas[]);//Falta un indice
                }

                for (int t = timeselected; timeselected >= 0; timeselected--)
                {
                    Console.WriteLine("Quedan {0} segundos para la siguiente ronda.", timeselected);
                    Thread.Sleep(1000);
                    Console.Clear();
                }//Muestra correctamente el tiempo pero no funciona como condicion para el while
            }

            


        }

            
            
        
    }
}
