using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topicos.Gato.BL.Acciones;
using Topicos.Gato.BL.Modelo;

namespace Topicos.Gato.App
{
    class Program
    {

        /// <summary>
        /// Se declara una variable de tipo Estructura de tablero
        /// </summary>
        private static EstructuraDelJuegoVersionDos estructura;

        /// <summary>
        ///  Aplicacion Main del proyecto.
        /// </summary>
        /// <param name="args">paramtros de aplicacion</param>
        static void Main(string[] args)
        {

            // pregunta el tamaño del tablero.
            Console.Write("Digite el tamaño del GATO: ");
            int TVal = int.Parse(Console.ReadLine().ToString());

            // la creacion del tablero AxB
            estructura = new EstructuraDelJuegoVersionDos(TVal);
            //Console.WriteLine(estructura.TableroDeJuego));
            Console.ReadKey();

            while 

        }
    }
}
