using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.Gato.BL.Acciones
{
    public class AsignarPosicionDelTableroComoNoVacia
    {
        public void MarcarCeldaEnElTableroComoUtilizada (int [,] elTablero, Modelo.Coordenada laCoordenada, 
                                                         int valorParaAsignar)
        {
            elTablero[laCoordenada.fila, laCoordenada.columna] = valorParaAsignar;
        }
    }
}
