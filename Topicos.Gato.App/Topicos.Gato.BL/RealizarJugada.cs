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
        public int DimensionTablero { get; set; }

        private Validaciones.ValidacionesGenerales validar = new Validaciones.ValidacionesGenerales();

        public RealizarJugada(string[,] tableroSync)
        {
            TableroDeJuego = tableroSync;
        }

        private void ResetearJuego()
        {
            try
            {

                for (int i = 0; i <= DimensionTablero - 1; i++)
                {
                    for (int ii = 0; ii <= DimensionTablero - 1; ii++)
                    {
                        TableroDeJuego[i, ii] = string.Empty;
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool hayEmpate()
        {
            return validar.hayEmpate();
        }

        public string Jugada(Modelo.Coordenada posicion, Modelo.EstructuraDelJuegoVersionDos.Jugador jugador)
        {
            string mensaje = string.Empty;

            try
            {
                validar.Mensaje = new Validaciones.Mensajes();
                validar.vTablero = TableroDeJuego;
                validar.DimensionTablero = DimensionTablero;

                if (validar.ValidaEspacio(posicion, jugador))
                {
                    TableroDeJuego[posicion.fila, posicion.columna] = ((char)jugador).ToString();
                    if (validar.hayGanador(posicion, jugador))
                    {
                        Console.WriteLine(" GANADOR ==> {0}", validar.Mensaje.mGanadorOtros);
                        Console.ReadKey();
                        ResetearJuego();
                    }
                }
                else
                {
                    throw new Exception(validar.Mensaje.mGanadorOtros);
                }

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
