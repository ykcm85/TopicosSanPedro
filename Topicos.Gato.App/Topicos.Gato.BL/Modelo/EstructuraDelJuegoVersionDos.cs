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
        public int[,] TableroDeJuego ;
        public const int LaPosicionEstaVacia = 0;
        public const int ValorAsignadoAlJugadorUno = 1;
        public const int ValorAsignadoAlJugadorDos = 2;

        /// <summary>
        /// Dimensionar el tamaño real del tablero del GATO
        /// </summary>
        /// <param name="DimensionTablero">Cantidad de filas y columnas para el tablero</param>
        public EstructuraDelJuegoVersionDos(int DimensionTablero)
        {
            TableroDeJuego = new int[DimensionTablero, DimensionTablero];
        }
    }
}
