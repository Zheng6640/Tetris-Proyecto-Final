using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris_Proyecto_Final
{
    class Controlador
    {
        // Variables globales
        const int canvasAnchura = 10;
        const int canvasAltura = 20;
        const int tamanyoBloque = 30;
        const int previewAnchura = 4;
        const int previewAltura = 4;

        // Lo que el usuario ve en la partida
        Bitmap canvasBitmap;
        Graphics canvasGraphics;
        Bitmap bitmapSiguienteFigura;
        Graphics graphicsSiguienteFigura;
        Bitmap bitmapFiguraGuardada;
        Graphics graphicsFiguraGuardada;

        // La puntuacion es estatica para poder acceder desde otro form
        static int puntuacion = 0;

        // Lugar donde se guarda las casillas rellenas
        int[,] canvasDotArray;

        // Posición de la pieza actual
        int xActual;
        int yActual;

        // Información de las piezas
        List<Figura> figuras;
        int numFigura = 0;
        Figura figuraActual;
        Figura siguienteFigura;
        Figura figuraGuardada;
        bool cambiado = false;

        // Variables para comprobar si el input es válido
        static Bitmap workingBitmap;
        static Graphics workingGraphics;

        public Controlador()
        {
            puntuacion = 0;
        }

        // Se utiliza al iniciar el juego
        public void CargarCanvas(PictureBox caja, PictureBox cajaSiguiente, PictureBox cajaGuardada)
        {
            caja.Width = canvasAnchura * tamanyoBloque;
            caja.Height = canvasAltura * tamanyoBloque;

            // Crea un Bitmap del mismo tamaño que la caja
            canvasBitmap = new Bitmap(caja.Width, caja.Height);
            canvasGraphics = Graphics.FromImage(canvasBitmap);
            canvasGraphics.FillRectangle(Brushes.White, 0, 0, canvasBitmap.Width, canvasBitmap.Height);
            caja.Image = canvasBitmap;

            // Crea un Bitmap para siguienteFieza
            bitmapSiguienteFigura = new Bitmap(previewAnchura * tamanyoBloque, previewAltura * tamanyoBloque);
            graphicsSiguienteFigura = Graphics.FromImage(bitmapSiguienteFigura);
            graphicsSiguienteFigura.FillRectangle(Brushes.White, 0, 0, previewAnchura * tamanyoBloque, previewAltura * tamanyoBloque);
            cajaSiguiente.Image = bitmapSiguienteFigura;

            // Crea un Bitmap para la figuraGuardada
            bitmapFiguraGuardada = new Bitmap(previewAnchura * tamanyoBloque, previewAltura * tamanyoBloque);
            graphicsFiguraGuardada = Graphics.FromImage(bitmapFiguraGuardada);
            graphicsFiguraGuardada.FillRectangle(Brushes.White, 0, 0, previewAnchura * tamanyoBloque, previewAltura * tamanyoBloque);
            cajaGuardada.Image = bitmapFiguraGuardada;

            // Inicializa canvasDotArray
            canvasDotArray = new int[canvasAnchura, canvasAltura];
        }

        // Comprueba si quedan figuras, si quedan pocos añade más
        public void ActualizarInformacionFiguras(PictureBox cajaSiguiente)
        {
            // Si se ha llegado al antepenúltimo elemento de la lista
            if (++numFigura + 2 >= figuras.Count)
            {
                figuras.AddRange(ControladorFiguras.GetFigurasAleatorias());
            }

            // Obtener la siguente figura
            figuraActual = figuras[numFigura];
            siguienteFigura = figuras[numFigura + 1];
            centrarFiguraActual();
            dibujarSiguienteFigura(cajaSiguiente);
        }

        // Comprueba si el movimiento que el usuario quiere hacer está permitido
        public bool IntentarMoverFigura(PictureBox caja, int movVertical = 0, int movHorizontal = 0)
        {
            int nuevoX = xActual + movHorizontal;
            int nuevoY = yActual + movVertical;

            // Comprobar si llega al fondo o los laterales
            if (nuevoX < 0 || nuevoX + figuraActual.GetAnchura() > canvasAnchura || nuevoY + figuraActual.GetAltura() > canvasAltura)
                return false;

            // Comprobar si toca algún otro bloque
            for (int i = 0; i < figuraActual.GetAnchura(); i++)
            {
                for (int j = 0; j < figuraActual.GetAltura(); j++)
                {
                    if (nuevoY + j > 0 && canvasDotArray[nuevoX + i, nuevoY + j] != 0 && figuraActual.GetDots()[j, i] != 0)
                        return false;
                }
            }

            // Si todo se ha ejecutado sin problemas
            xActual = nuevoX;
            yActual = nuevoY;

            dibujarFigura(caja);

            return true;
        }

        // Inserta en el canvasDotArray la figuraActual, además de comprobar si la partida ha acabado
        public bool ActualizarCanvasDotArray()
        {
            bool finPartida = false;
            for (int i = 0; i < figuraActual.GetAnchura(); i++)
            {
                for (int j = 0; j < figuraActual.GetAltura(); j++)
                {
                    if (figuraActual.GetDots()[j, i] != 0 && !finPartida)
                    {
                        finPartida = comprobarPartidaAcabada();

                        if (yActual >= 0)
                            canvasDotArray[xActual + i, yActual + j] = figuraActual.GetValorNumerico();
                    }
                }
            }
            return finPartida;
        }

        // Elimina las filas llenas
        public void EliminarFilasLlenas(PictureBox caja)
        {
            int lineasEliminadas = 0;
            for (int i = 0; i < canvasAltura; i++)
            {
                bool filaLlena = true;
                for (int j = 0; j < canvasAnchura; j++)
                {
                    if (canvasDotArray[j, i] == 0)
                        filaLlena = false;
                }

                if (filaLlena)
                {
                    lineasEliminadas++;
                    for (int j = i; j > 0; j--)
                    {
                        for (int k = 0; k < canvasAnchura; k++)
                        {
                            canvasDotArray[k, j] = canvasDotArray[k, j - 1];
                        }
                    }

                    for (int j = 0; j < canvasAnchura; j++)
                    {
                        canvasDotArray[j, 0] = 0;
                    }
                }
            }

            if (lineasEliminadas > 0)
            {
                puntuacion += calcularPuntuacion(lineasEliminadas);
                actualizarCanvas(caja);
            }
        }

        private int calcularPuntuacion(int lineasEliminadas)
        {
            switch (lineasEliminadas)
            {
                case 1:
                    return 100;
                case 2:
                    return 200;
                case 3:
                    return 400;
                case 4:
                    return 800;
                default:
                    return 0;
            }
        }

        public void ActualizarPuntuacion(Label l_puntuacion)
        {
            l_puntuacion.Text = "Puntuacion: " + puntuacion;
        }

        public static int GetPuntuacion()
        {
            return puntuacion;
        }

        public void GuardarFigura(PictureBox cajaSiguiente, PictureBox cajaGuardada)
        {
            centrarFiguraActual();
            cambiado = true;

            if (figuraGuardada == null)
            {
                figuraGuardada = figuraActual;
                figuraActual = figuras[++numFigura];
                siguienteFigura = figuras[numFigura + 1];
                dibujarSiguienteFigura(cajaSiguiente);
                dibujarFiguraGuardada(cajaGuardada);
                return;
            }

            Figura temp = figuraGuardada;
            figuraGuardada = figuraActual;
            figuraActual = temp;
            dibujarSiguienteFigura(cajaSiguiente);
            dibujarFiguraGuardada(cajaGuardada);
        }

        // Actualiza el canvasBitmap con el que se está trabajando
        public void GuardarCanvasWorking()
        {
            canvasBitmap = new Bitmap(workingBitmap);
        }

        // Genera las primeras figuras, se utiliza solo al principio
        public void GenerarPrimerasFiguras(PictureBox cajaSiguiente)
        {
            figuras = new List<Figura>(ControladorFiguras.GetFigurasAleatorias());
            numFigura = 0;
            figuraActual = figuras[numFigura];
            siguienteFigura = figuras[numFigura + 1];

            centrarFiguraActual();
            dibujarSiguienteFigura(cajaSiguiente);
        }

        // Se emplea para crear la sensación de movimiento
        private void dibujarFigura(PictureBox caja)
        {
            workingBitmap = new Bitmap(canvasBitmap);
            workingGraphics = Graphics.FromImage(workingBitmap);

            for (int i = 0; i < figuraActual.GetAnchura(); i++)
            {
                for (int j = 0; j < figuraActual.GetAltura(); j++)
                {
                    if (figuraActual.GetDots()[j, i] != 0)
                        workingGraphics.FillRectangle(figuraActual.GetColor(), (xActual + i) * tamanyoBloque, (yActual + j) * tamanyoBloque, tamanyoBloque, tamanyoBloque);
                }
            }

            caja.Image = workingBitmap;
        }

        // Se emplea para mostrar la siguiente figura
        private void dibujarSiguienteFigura(PictureBox cajaSiguinete)
        {
            // Reinicia el Bitmap con un fondo blanco
            graphicsSiguienteFigura.FillRectangle(Brushes.White, 0, 0, previewAnchura * tamanyoBloque, previewAltura * tamanyoBloque);

            for (int i = 0; i < siguienteFigura.GetAnchura(); i++)
            {
                for (int j = 0; j < siguienteFigura.GetAltura(); j++)
                {
                    if (siguienteFigura.GetDots()[j, i] != 0)
                        // Las operaciones se utilizan para centrar la imagen dentro de la caja 4x4
                        graphicsSiguienteFigura.FillRectangle(siguienteFigura.GetColor(),
                            (previewAnchura / 2 - siguienteFigura.GetAnchura() / 2 + i) * tamanyoBloque,
                            (previewAltura / 2 - siguienteFigura.GetAltura() / 2 + j) * tamanyoBloque, tamanyoBloque, tamanyoBloque);
                }
            }

            cajaSiguinete.Image = bitmapSiguienteFigura;
        }

        private void dibujarFiguraGuardada(PictureBox cajaGuardada)
        {
            // Reinicia el Bitmap con un fondo blanco
            graphicsFiguraGuardada.FillRectangle(Brushes.White, 0, 0, previewAnchura * tamanyoBloque, previewAltura * tamanyoBloque);

            for (int i = 0; i < figuraGuardada.GetAnchura(); i++)
            {
                for (int j = 0; j < figuraGuardada.GetAltura(); j++)
                {
                    if (figuraGuardada.GetDots()[j, i] != 0)
                        graphicsFiguraGuardada.FillRectangle(figuraGuardada.GetColor(),
                            (previewAnchura / 2 - figuraGuardada.GetAnchura() / 2 + i) * tamanyoBloque,
                            (previewAltura / 2 - figuraGuardada.GetAltura() / 2 + j) * tamanyoBloque, tamanyoBloque, tamanyoBloque);
                }
            }

            cajaGuardada.Image = bitmapFiguraGuardada;
        }

        // Calcula los valores centrales de x e y para la figura
        private void centrarFiguraActual()
        {
            // yActual es negativo para que la pieza aparezca de manera gradual, no todo de golpe
            xActual = 4;
            yActual = -figuraActual.GetAltura();
        }

        // Colorea el canvasBitmap con los datos del canvasDotArray
        private void actualizarCanvas(PictureBox caja)
        {
            // Reiniciar el Bitmap
            workingBitmap = new Bitmap(canvasBitmap);
            workingGraphics = Graphics.FromImage(workingBitmap);
            workingGraphics.Clear(Color.White);

            for (int i = 0; i < canvasAltura; i++)
            {
                for (int j = 0; j < canvasAnchura; j++)
                {
                    if (canvasDotArray[j, i] != 0)
                        workingGraphics.FillRectangle(ControladorFiguras.GetColorNumero(canvasDotArray[j, i]), j * tamanyoBloque, i * tamanyoBloque, tamanyoBloque, tamanyoBloque);
                }
            }

            caja.Image = workingBitmap;
        }

        // Comprueba si la partida ha acabado
        private bool comprobarPartidaAcabada()
        {
            if (yActual < 0)
            {
                return true;
            }
            return false;
        }

        public Figura GetFiguraActual()
        {
            return figuraActual;
        }

        public bool GetCambiado()
        {
            return cambiado;
        }

        public void ToggleCambiado()
        {
            cambiado = false;
        }
    }
}
