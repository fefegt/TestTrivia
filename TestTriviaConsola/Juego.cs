using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTriviaConsola
{
    public class Juego
    {
            static int Puntaje = 0;
            static int Vidas = 5;
            
            static void AgregarPuntaje()
            {
                Puntaje++;
            }

            static void EliminarVida()
            {
                Vidas--;
            }

            static void EjecutarJuego(int timeselected) 
            {
             
             for (timeselected; timeselected >= 0; timeselected--)
                {
                    Console.WriteLine("Quedan {0} segundos para la siguiente ronda.", timeselected);
                    Thread.Sleep(1000);
                    Console.Clear();
                }

        }
            
        
    }
}
