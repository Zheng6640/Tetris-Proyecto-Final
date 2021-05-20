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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void b_jugar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();

            this.Show();
        }

        private void b_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_ranking_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f = new Form4();
            f.ShowDialog();

            this.Show();
        }
    }
}
