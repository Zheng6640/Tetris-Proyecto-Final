using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tetris_Proyecto_Final
{
    class Figura
    {
        private static int cantidad = 0;
        private int anchura;
        private int altura;
        private int[,] dots;
        private int[,] backupDots;
        private Brush color;
        private int valorNumerico;

        public Figura(int anchura, int altura, Brush color, int[,] dots)
        {
            this.anchura = anchura;
            this.altura = altura;
            this.color = color;
            this.dots = dots;
            valorNumerico = ++cantidad;
        }

        public void Rotar()
        {
            // Copia de la figura para que se pueda
            // volver al caso anterior
            backupDots = dots;

            dots = new int[anchura, altura];

            for (int i = 0; i < anchura; i++)
            {
                for (int j = 0; j < altura; j++)
                {
                    dots[i, j] = backupDots[altura - j - 1, i];
                }
            }

            int temp = anchura;
            anchura = altura;
            altura = temp;
        }

        // El retroceso se ejecutará cuando el jugador intente rotar
        // una pieza pero dicha figura colisionaría con otras figuras
        public void Retroceso()
        {
            dots = backupDots;

            var temp = anchura;
            anchura = altura;
            altura = temp;
        }

        public int GetAnchura()
        {
            return anchura;
        }

        public int GetAltura()
        {
            return altura;
        }

        public int GetValorNumerico()
        {
            return valorNumerico;
        }

        public int[,] GetDots()
        {
            return dots;
        }

        public Brush GetColor()
        {
            return color;
        }
    }
}
