using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.Gato.BL.Validaciones
{
    internal class ExistenEspaciosDisponiblesParaJugar
    {
        public bool DetermineSiHayEspaciosDisponibles (int [,] elTablero)
        {
            bool elResultado = false;
            for (int i = 0; i < 3 && elResultado == false; i++)
            {
                for (int j = 0; j < 3 && elResultado == false; j++)
                {
                    if (elTablero[i,j] == Modelo.EstructuraDelJuegoVersionDos.LaPosicionEstaVacia)
                        elResultado = true;
                }
            }
            return elResultado;
        }

        public List<Modelo.Coordenada> ObtenerListaDeEspaciosDisponibles(int[,] elTablero)
        {
            var elResultado = new List<Modelo.Coordenada> (); 
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (elTablero[i, j] == Modelo.EstructuraDelJuegoVersionDos.LaPosicionEstaVacia)
                    {
                        var laCoordenada = new Modelo.Coordenada();
                        laCoordenada.fila = i;
                        laCoordenada.columna = j;
                        elResultado.Add(laCoordenada);
                    }
                }
            }
            return elResultado;
        }

    }
}
