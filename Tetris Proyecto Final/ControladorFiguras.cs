using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tetris_Proyecto_Final
{
    class ControladorFiguras
    {
        private static List<Figura> listaFigura;

        // static constructor : No need to manually initialize
        static ControladorFiguras()
        {
            listaFigura = new List<Figura>
            (
                new Figura[]
                {
                    new Figura(2, 2, Brushes.Yellow, new int[,]
                    {
                        { 1, 1 },
                        { 1, 1 }
                    }),
                    new Figura(1, 4, Brushes.LightBlue, new int[,]
                    {
                        { 2 },
                        { 2 },
                        { 2 },
                        { 2 }
                    }),
                    new Figura(3, 2, Brushes.LightPink, new int[,]
                    {
                        { 0, 3, 0 },
                        { 3, 3, 3 }
                    }),
                    new Figura(3, 2, Brushes.Orange, new int[,]
                    {
                        { 0, 0, 4 },
                        { 4, 4, 4 }
                    }),
                    new Figura(3, 2, Brushes.DarkBlue, new int[,]
                    {
                        { 5, 0, 0 },
                        { 5, 5, 5 }
                    }),
                    new Figura(3, 2, Brushes.Red, new int[,]
                    {
                        { 6, 6, 0 },
                        { 0, 6, 6 }
                    }),
                    new Figura(3, 2, Brushes.Green, new int[,]
                    {
                        { 0, 7, 7 },
                        { 7, 7, 0 }
                    })
                    // Añadir nuevas figuras aquí ...
                }
            );
        }

        // Get a shape form the array in a random basis
        public static Figura GetRandomShape()
        {
            return listaFigura[new Random().Next(listaFigura.Count)];
        }

        public static Figura[] GetFigurasAleatorias()
        {
            // Lista de posiciones únicas
            List<int> posicionFigura = new List<int>();

            List<Figura> figuras = new List<Figura>();

            int numAleatorio;
            Random rnd = new Random();
            while (posicionFigura.Count < listaFigura.Count)
            {
                numAleatorio = rnd.Next(listaFigura.Count);

                if (!posicionFigura.Contains(numAleatorio))
                    posicionFigura.Add(numAleatorio);
            }

            foreach (int pos in posicionFigura)
            {
                figuras.Add(listaFigura[pos]);
            }

            return figuras.ToArray();
        }

        public static Brush GetColorNumero(int num)
        {
            return listaFigura[num - 1].GetColor();
        }
    }
}
