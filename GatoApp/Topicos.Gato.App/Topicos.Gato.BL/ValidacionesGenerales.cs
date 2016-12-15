using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.Gato.BL.Validaciones
{
    internal class ValidacionesGenerales
    {

        private Mensajes sError;
        public string[,] vTablero { get; set; }
        public int DimensionTablero { get; set; }
        public Mensajes Mensaje
        {
            get
            {
                return sError;
            }
            set
            {
                sError = new Mensajes();
                sError = value;
            }
        }

        public bool ValidaEspacio(Modelo.Coordenada posicion, Modelo.EstructuraDelJuegoVersionDos.Jugador jugador)
        {
            bool esValido;
            try
            {

                esValido = true;

                if (int.Parse(vTablero[posicion.fila, posicion.columna].ToString()) > 0)
                {
                    esValido = false;
                    string vFicha = (vTablero[posicion.fila, posicion.columna] == "X") ? "Ficha (X) del jugador 1" : "Ficha (O) del jugador 2";
                    Mensaje.mGanadorOtros = string.Format(" {0} ya se encuentra en este espacio. Seleccione otro. ", vFicha);
                }

            }
            catch (Exception)
            {
                throw;
            }
            return esValido;
        }

        public bool hayGanador(Modelo.Coordenada posicion, Modelo.EstructuraDelJuegoVersionDos.Jugador jugador)
        {
            bool esGanador;
            try
            {

                esGanador = false;

                for (int fila = 0; fila <= DimensionTablero - 1; fila++)
                {

                    if (vTablero[fila, 0] == vTablero[fila, 1] && vTablero[fila, 1] == vTablero[fila, 2])
                    {
                        Mensaje.mGanadorOtros = (vTablero[fila, 0].ToUpper().Contains("X")) ? " Gana Jugador 1 (X) " : " Gana Jugador 2 (O) ";
                        esGanador = true;
                        break;
                    }

                    if (vTablero[0, fila] == vTablero[1, fila] && vTablero[1, fila] == vTablero[2, fila])
                    {
                        Mensaje.mGanadorOtros = (vTablero[fila, 0].ToUpper().Contains("X")) ? " Gana Jugador 1 (X) " : " Gana Jugador 2 (O) ";
                        esGanador = true;
                        break;
                    }
                }

                if (!esGanador)
                {
                    if (vTablero[0, 0] == vTablero[1, 1] && vTablero[1, 1] == vTablero[2, 2])
                    {
                        Mensaje.mGanadorOtros = (vTablero[0, 0].ToUpper().Contains("X")) ? " Gana Jugador 1 (X) " : " Gana Jugador 2 (O) ";
                        esGanador = true;
                    }

                    if (vTablero[2, 0] == vTablero[1, 1] && vTablero[1, 1] == vTablero[0, 2])
                    {
                        Mensaje.mGanadorOtros = (vTablero[2, 0].ToUpper().Contains("X")) ? " Gana Jugador 1 (X) " : " Gana Jugador 2 (O) ";
                        esGanador = true;
                    }

                }

            }
            catch (Exception)
            {
                throw;
            }
            return esGanador;
        }

        public bool hayEmpate()
        {

            bool esGanador;
            try
            {

                esGanador = false;
                int iLoc;
                for (int i = 0; i <= DimensionTablero - 1; i++)
                {
                    for (int ii = 0; ii <= DimensionTablero - 1; ii++)
                    {
                        if (int.TryParse(vTablero[i, ii], out iLoc))
                        {
                            if (iLoc <= 0)
                            {
                                Mensaje.mGanadorOtros = " Se produjo un empate ";
                                esGanador = true;
                                break;
                            }

                        }
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return esGanador;

        }

    }
}
