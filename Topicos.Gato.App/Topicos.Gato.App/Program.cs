using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topicos.Gato.BL;
using Topicos.Gato.BL.Modelo;
using Topicos.Gato.BL.Acciones;

namespace Topicos.Gato.App
{
    class Program
    {

        /// <summary>
        /// Se declara una variable de tipo Estructura de tablero
        /// </summary>
        private static EstructuraDelJuegoVersionDos estructura;

        /// <summary>
        ///
        /// </summary>
        private static RealizarJugada jugada;

        /// <summary>
        ///
        /// </summary>
        private static Coordenada posicion = new Coordenada();


        private static string Mensaje = string.Empty;

        /// <summary>
        ///  Aplicacion Main del proyecto.
        /// </summary>
        /// <param name="args">paramtros de aplicacion</param>
        static void Main(string[] args)
        {

            // pregunta el tamaño del tablero.
            Console.Write("Digite el tamaño del GATO: ");

            // la creacion del tablero AxB
            estructura = new EstructuraDelJuegoVersionDos(int.Parse(Console.ReadLine().ToString()));
            jugada = new RealizarJugada(estructura.TableroDeJuego);

            Console.Clear();

            do
            {

                posicion = new Coordenada();
                Console.Write("Jugador 1(X), digite la posicion X:");
                posicion.fila = int.Parse(Console.ReadLine().ToString());
                Console.Write("Jugador 1(X), digite la posicion Y:");
                posicion.columna = int.Parse(Console.ReadLine().ToString());

                Mensaje = jugada.Jugada(posicion, EstructuraDelJuegoVersionDos.Jugador.JugadorUnoX);

                if (Mensaje.Length > 0)
                {
                    Console.Write(string.Format("Jugador 1(X), Se ha cometido un error: {0}, rediseñe la jugada....  ", Mensaje));
                    Console.ReadKey();
                    Console.Clear();
                    posicion = new Coordenada();
                    Console.Write("Jugador 1(X), digite la posicion X:");
                    posicion.fila = int.Parse(Console.ReadLine().ToString());
                    Console.Write("Jugador 1(X), digite la posicion Y:");
                    posicion.columna = int.Parse(Console.ReadLine().ToString());
                }
                else
                {
                    estructura.TableroDeJuego = jugada.TableroDeJuego;
                }



                Console.Clear();

                posicion = new Coordenada();
                Console.Write("Jugador 2(O), digite la posicion X:");
                posicion.fila = int.Parse(Console.ReadLine().ToString());
                Console.Write("Jugador 2(O), digite la posicion Y:");
                posicion.columna = int.Parse(Console.ReadLine().ToString());

                Mensaje = jugada.Jugada(posicion, EstructuraDelJuegoVersionDos.Jugador.JugadorDosO);

                if (Mensaje.Length > 0)
                {
                    Console.Write(string.Format("Jugador 2(O), Se ha cometido un error: {0}, rediseñe la jugada....  ", Mensaje));
                    Console.ReadKey();
                    Console.Clear();
                    posicion = new Coordenada();
                    Console.Write("Jugador 2(O), digite la posicion X:");
                    posicion.fila = int.Parse(Console.ReadLine().ToString());
                    Console.Write("Jugador 2(O), digite la posicion Y:");
                    posicion.columna = int.Parse(Console.ReadLine().ToString());
                }
                else
                {
                    estructura.TableroDeJuego = jugada.TableroDeJuego;
                }


            } while (true);

            estructura = null;

        }
    }
}
