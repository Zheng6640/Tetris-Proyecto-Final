using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tetris_Proyecto_Final
{
    public partial class Form4 : Form
    {
        List<Puntuacion> puntuaciones = new List<Puntuacion>();

        public Form4()
        {
            InitializeComponent();
            leerFicheroPuntuaciones();
            mostrarPuntuaciones();
        }

        private void b_atras_Click(object sender, EventArgs e)
        {
            // Volver al Form anterior
            this.Hide();
            return;
        }

        private void mostrarPuntuaciones()
        {
            foreach (Puntuacion p in puntuaciones)
            {
                rtb_nombre.AppendText(p.GetNombre() + '\n');
                rtb_puntuacion.AppendText(p.GetPuntuacion().ToString() + '\n');
                rtb_fecha.AppendText(p.GetFecha().ToString("dd-MM-yyyy") + '\n');
            }
        }

        private void leerFicheroPuntuaciones()
        {
            if (File.Exists("puntuaciones.txt"))
            {
                string[] contenidoFichero = File.ReadAllLines("puntuaciones.txt");

                foreach (string s in contenidoFichero)
                {
                    string[] datos = s.Split(';');
                    puntuaciones.Add(new Puntuacion(datos[0], int.Parse(datos[1]), DateTime.Parse(datos[2])));
                }
            }
        }
    }
}
