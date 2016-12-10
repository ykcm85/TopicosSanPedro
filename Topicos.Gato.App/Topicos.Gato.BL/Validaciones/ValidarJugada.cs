using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.Gato.BL.Validaciones
{
    internal class ValidarJugada
    {
        public bool EstaUnaPosicionLibreParaJugar(int[,] elTablero, Modelo.Coordenada laCoordenadaDeJuego)
        {
            var elResultado = true;
            var laValidacion = new Validaciones.ExistenEspaciosDisponiblesParaJugar();
            var laListaDeEspaciosDisponibles = laValidacion.ObtenerListaDeEspaciosDisponibles(elTablero);
            if (!laListaDeEspaciosDisponibles.Contains(laCoordenadaDeJuego))
            {
                elResultado = false;
            }
            return (elResultado);
        }

    }
}
