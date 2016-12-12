using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topicos.Gato.BL;


namespace Topicos.Gato.BL.Acciones
{
    public class RealizarJugada
    {

        public string[,] TableroDeJuego { set; get; }

        private Validaciones.Mensajes mensaje = new Validaciones.Mensajes();

        public RealizarJugada(string[,] tableroSync)
        {
            TableroDeJuego = tableroSync;
        }

        public string Jugada(Modelo.Coordenada posicion, Modelo.EstructuraDelJuegoVersionDos.Jugador jugador)
        {
            string mensaje = string.Empty;

            try
            {

                TableroDeJuego[posicion.fila, posicion.columna] = ((char)jugador).ToString();


                // Validaciones.Mensajes.mGanadorNO

            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return mensaje;
            }
            return mensaje;
        }

    }
}
