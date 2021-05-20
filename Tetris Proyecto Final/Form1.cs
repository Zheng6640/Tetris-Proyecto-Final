using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris_Proyecto_Final
{
    public partial class Form1 : Form
    {
        // Controlador del juego
        Controlador juego = new Controlador();

        // Velocidad del juego
        Timer timer = new Timer();

        public Form1()
        {
            InitializeComponent();
            juego.CargarCanvas(caja, cajaSiguiente, cajaGuardada);

            juego.GenerarPrimerasFiguras(cajaSiguiente);

            timer.Tick += Timer_Tick;
            timer.Interval = 200;
            timer.Start();

            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int movVertical = 0;
            int movHorizontal = 0;

            // calculate the vertical and horizontal move values
            // based on the key pressed
            switch (e.KeyCode)
            {
                // Mover figura izquierda
                case Keys.Left:
                    movVertical--;
                    break;

                // Mover figura derecha
                case Keys.Right:
                    movVertical++;
                    break;

                // Mover figura abajo más rápido
                case Keys.Down:
                    movHorizontal++;
                    break;

                // Rotar la figura en sentido horario
                case Keys.Up:
                    juego.GetFiguraActual().Rotar();
                    break;

                // Guardar la pieza actual
                case Keys.ShiftKey when !juego.GetCambiado():
                    juego.GuardarFigura(cajaSiguiente, cajaGuardada);
                    break;

                // Si el usuario pulsa cualquier otra tecla
                default:
                    return;
            }

            bool movimientoValido = juego.IntentarMoverFigura(caja, movHorizontal, movVertical);

            // if the player was trying to rotate the shape, but
            // that move was not possible - rollback the shape
            if (!movimientoValido && e.KeyCode == Keys.Up)
                juego.GetFiguraActual().Retroceso();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            bool movimientoValido = juego.IntentarMoverFigura(caja, movVertical: 1);

            // if shape reached bottom or touched any other shapes
            if (!movimientoValido)
            {
                if (juego.ActualizarCanvasDotArray()) // has game ended?
                {
                    timer.Stop();

                    this.Hide();
                    Form3 f = new Form3();
                    f.ShowDialog();

                    // Vuelve al Form anterior
                    return;
                }

                // Comprobar si se llenado alguna fila
                juego.EliminarFilasLlenas(caja);

                // Actualizar puntuacion
                l_puntuacion.Text = "Puntuacion: " + Controlador.GetPuntuacion();

                // Copiar la imagen temporal a canvasBitmap
                juego.GuardarCanvasWorking();

                // Obtener la siguiente figura
                juego.ActualizarInformacionFiguras(cajaSiguiente);

                // Reiniciar la variable cambiado
                juego.ToggleCambiado();
            }
        }
    }
}
