using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.Gato.BL.Validaciones
{
    internal class ValidarEntradaCorrecta
    {
        public bool LaEntradaEsCorrecta (int laEntrada)
        {
            bool elResultado;
            elResultado = (laEntrada == Modelo.EstructuraDelJuegoVersionDos.ValorAsignadoAlJugadorUno && 
                           laEntrada == Modelo.EstructuraDelJuegoVersionDos.ValorAsignadoAlJugadorDos);
            return elResultado;
        }
    }
}
