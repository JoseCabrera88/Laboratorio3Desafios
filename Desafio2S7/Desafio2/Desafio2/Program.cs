using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Crea un Método que reciba como parámetro una arreglo bidimensional, el cual contenga por cada fila un listado de montos de las ultimas 5
//compras de 5 clientes. el programa debe calcular el total de compras de cada cliente y otorgar un descuento segun las siguientes reglas
class Programa
{
    static void Main(string[] args)
    {
        int[,] compras = {
            {20, 15, 12, 4, 25},
            {800, 1200, 900, 700, 600},
            {50, 70, 80, 90, 100},
            {1100, 900, 1200, 800, 1000},
            {48, 331, 20, 150, 250}
        };

        AplicarDescuentos(compras);
        Console.ReadKey();
    }

    static void AplicarDescuentos(int[,] compras)
    {
        for (int i = 0; i < compras.GetLength(0); i++)
        {
            int totalCompras = 0;

            for (int j = 0; j < compras.GetLength(1); j++)
            {
                totalCompras += compras[i, j];
            }

            double descuento = 0;

            if (totalCompras >= 100 && totalCompras <= 1000)
            {
                descuento = 0.1;
            }
            else if (totalCompras > 1000)
            {
                descuento = 0.2;
            }

            double totalAPagar = totalCompras * (1 - descuento);

            Console.WriteLine("Cliente " + (i + 1) + ": El Total de sus Compras es = " + totalCompras + ", Descuento = " + descuento * 100 + "%, El Total a Pagar con su Descuento es = " + totalAPagar);
        }
    }
}