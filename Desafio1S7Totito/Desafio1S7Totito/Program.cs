using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///Crear una copia del juego ToTiTo usando arreglos de múltiples dimensiones.
class Program
{
    static char[,] tablero = new char[3, 3];
    static char jugador = 'X';

    static void Main(string[] args)
    {
        IniciarTablero();
        ImprimirTablero();

        while (!JuegoTerminado())
        {
            int[] position = ObtenerEntradaDeJugador();
            tablero[position[0], position[1]] = jugador;
            jugador = jugador == 'X' ? 'O' : 'X';
            ImprimirTablero();
        }

        Console.WriteLine(ObtenerGanador() + " Es el ganador!!!");
        Console.ReadLine();
    }

    static void IniciarTablero()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                tablero[i, j] = '-';
            }
        }
    }

    static void ImprimirTablero()
    {
        Console.Clear();
        Console.WriteLine("  0 1 2");

        for (int i = 0; i < 3; i++)
        {
            Console.Write(i + " ");

            for (int j = 0; j < 3; j++)
            {
                Console.Write(tablero[i, j] + " ");
            }

            Console.WriteLine();
        }
    }

    static int[] ObtenerEntradaDeJugador()
    {
        int[] position = new int[2];

        Console.WriteLine("Jugador " + jugador + ", ingrese una fila:");
        position[0] = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Jugador " + jugador + ", ingrese una columna:");
        position[1] = Convert.ToInt32(Console.ReadLine());

        return position;
    }

    static bool JuegoTerminado()
    {
        if (ObtenerGanador() != '-')
        {
            return true;
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (tablero[i, j] == '-')
                {
                    return false;
                }
            }
        }

        return true;
    }

    static char ObtenerGanador()
    {
        for (int i = 0; i < 3; i++)
        {
            if (tablero[i, 0] != '-' && tablero[i, 0] == tablero[i, 1] && tablero[i, 1] == tablero[i, 2])
            {
                return tablero[i, 0];
            }
        }

        for (int j = 0; j < 3; j++)
        {
            if (tablero[0, j] != '-' && tablero[0, j] == tablero[1, j] && tablero[1, j] == tablero[2, j])
            {
                return tablero[0, j];
            }
        }

        if (tablero[0, 0] != '-' && tablero[0, 0] == tablero[1, 1] && tablero[1, 1] == tablero[2, 2])
        {
            return tablero[0, 0];
        }

        if (tablero[0, 2] != '-' && tablero[0, 2] == tablero[1, 1] && tablero[1, 1] == tablero[2, 0])
        {
            return tablero[0, 2];
        }

        return '-';
    }
}
