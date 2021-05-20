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
    public partial class Form3 : Form
    {
        List<Puntuacion> puntuaciones = new List<Puntuacion>();

        public Form3()
        {
            InitializeComponent();
            l_puntuacion.Text = "Puntuacion: " + Controlador.GetPuntuacion();
            leerFicheroPuntuaciones();
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

        private void b_confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (t_nombre.Text != null && t_nombre.Text.Trim() != "" && !t_nombre.Text.Contains(';') && t_nombre.Text.Length <= 23)
                {
                    puntuaciones.Add(new Puntuacion(t_nombre.Text.Trim(), Controlador.GetPuntuacion(), DateTime.Parse(DateTime.Now.ToString("dd-MM-yyyy"))));
                    puntuaciones.Sort();

                    StreamWriter writer = new StreamWriter("puntuaciones.txt");
                    for (int i = 0; i < puntuaciones.Count; i++)
                    {
                        writer.WriteLine(puntuaciones[i]);
                    }
                    writer.Close();

                    // Vuelve al Form anterior
                    this.Hide();
                    return;
                }
                else if (t_nombre.Text.Contains(';'))
                {
                    MessageBox.Show("El nombre no puede contener el caracter ;");
                }
                else if (t_nombre.Text.Length > 23)
                {
                    MessageBox.Show("El nombre es demasiado largo");
                }
                else
                {
                    MessageBox.Show("El nombre no puede estar vacio");
                }
            }
            catch (IOException excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
        }
    }
}
