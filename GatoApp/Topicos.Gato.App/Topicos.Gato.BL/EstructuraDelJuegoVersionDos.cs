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

        public string[,] TableroDeJuego { set; get; }

        public int DimensionTablero { get; set; }

        public enum Jugador
        {
            JugadorUnoX = 'X',
            JugadorDosO = 'O'
        }

        /// <summary>
        /// Dimensionar el tamaño real del tablero del GATO
        /// </summary>
        /// <param name="DimensionTablero">Cantidad de filas y columnas para el tablero</param>
        public void CrearEstructuraDelJuegoVersionDos()
        {
            int cont = -1;
            TableroDeJuego = new string[DimensionTablero, DimensionTablero];
            for (int i = 0; i < DimensionTablero; i++)
            {
                for (int ii = 0; ii < DimensionTablero; ii++)
                {
                    TableroDeJuego[i,ii] = (cont--).ToString();
                }
            }
        }


    }
}
