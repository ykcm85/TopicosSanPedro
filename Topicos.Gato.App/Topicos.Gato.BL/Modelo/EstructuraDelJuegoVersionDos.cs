using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.Gato.BL.Modelo
{
    /// <summary>
    /// Esta es la estructura definitiva que se va a 
    /// utilizar en el desarrollo de la aplicación
    /// </summary>
    public class EstructuraDelJuegoVersionDos
    {
        //int[][] TableroDeJuego; // = new int[3] ;
        public int[,] TableroDeJuego = new int[3, 3];

        public const int LaPosicionEstaVacia = 0;
        public const int ValorAsignadoAlJugadorUno = 1;
        public const int ValorAsignadoAlJugadorDos = 2;
    }
}
