using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.Gato.BL.Acciones
{
    public class JugarEnUnaPosicion
    {
        public void JuegueEnUnaPosicion (int [,] elTablero, int filaDeJuego, int columnaDeJuego, 
                                        int elNumeroDelJugador)
        {
            var laValidacion = new Validaciones.ValidarJugada();
            var laCoordenadaDeJuego = new Modelo.Coordenada() { fila = filaDeJuego, columna = columnaDeJuego };
            if (laValidacion.EstaUnaPosicionLibreParaJugar(elTablero, laCoordenadaDeJuego))
            {
                var laMarca = new Acciones.AsignarPosicionDelTableroComoNoVacia();
                laMarca.MarcarCeldaEnElTableroComoUtilizada(elTablero, laCoordenadaDeJuego, elNumeroDelJugador);
            }

        }
    }
}
