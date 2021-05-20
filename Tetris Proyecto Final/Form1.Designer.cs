
namespace Tetris_Proyecto_Final
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.caja = new System.Windows.Forms.PictureBox();
            this.cajaSiguiente = new System.Windows.Forms.PictureBox();
            this.cajaGuardada = new System.Windows.Forms.PictureBox();
            this.l_puntuacion = new System.Windows.Forms.Label();
            this.tetrisLogo = new System.Windows.Forms.PictureBox();
            this.l_siguiente = new System.Windows.Forms.Label();
            this.l_guardada = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.caja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajaSiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajaGuardada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetrisLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // caja
            // 
            this.caja.Location = new System.Drawing.Point(30, 120);
            this.caja.Name = "caja";
            this.caja.Size = new System.Drawing.Size(300, 600);
            this.caja.TabIndex = 0;
            this.caja.TabStop = false;
            // 
            // cajaSiguiente
            // 
            this.cajaSiguiente.Location = new System.Drawing.Point(420, 260);
            this.cajaSiguiente.Name = "cajaSiguiente";
            this.cajaSiguiente.Size = new System.Drawing.Size(120, 120);
            this.cajaSiguiente.TabIndex = 1;
            this.cajaSiguiente.TabStop = false;
            // 
            // cajaGuardada
            // 
            this.cajaGuardada.Location = new System.Drawing.Point(420, 480);
            this.cajaGuardada.Name = "cajaGuardada";
            this.cajaGuardada.Size = new System.Drawing.Size(120, 120);
            this.cajaGuardada.TabIndex = 2;
            this.cajaGuardada.TabStop = false;
            // 
            // l_puntuacion
            // 
            this.l_puntuacion.AutoSize = true;
            this.l_puntuacion.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_puntuacion.Location = new System.Drawing.Point(360, 87);
            this.l_puntuacion.Name = "l_puntuacion";
            this.l_puntuacion.Size = new System.Drawing.Size(180, 27);
            this.l_puntuacion.TabIndex = 3;
            this.l_puntuacion.Text = "Puntuacion: 0";
            // 
            // tetrisLogo
            // 
            this.tetrisLogo.Image = ((System.Drawing.Image)(resources.GetObject("tetrisLogo.Image")));
            this.tetrisLogo.Location = new System.Drawing.Point(30, 12);
            this.tetrisLogo.Name = "tetrisLogo";
            this.tetrisLogo.Size = new System.Drawing.Size(300, 102);
            this.tetrisLogo.TabIndex = 4;
            this.tetrisLogo.TabStop = false;
            // 
            // l_siguiente
            // 
            this.l_siguiente.AutoSize = true;
            this.l_siguiente.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_siguiente.Location = new System.Drawing.Point(420, 220);
            this.l_siguiente.Name = "l_siguiente";
            this.l_siguiente.Size = new System.Drawing.Size(102, 21);
            this.l_siguiente.TabIndex = 5;
            this.l_siguiente.Text = "Siguiente";
            // 
            // l_guardada
            // 
            this.l_guardada.AutoSize = true;
            this.l_guardada.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_guardada.Location = new System.Drawing.Point(420, 436);
            this.l_guardada.Name = "l_guardada";
            this.l_guardada.Size = new System.Drawing.Size(103, 21);
            this.l_guardada.TabIndex = 6;
            this.l_guardada.Text = "Guardada";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 753);
            this.Controls.Add(this.l_guardada);
            this.Controls.Add(this.l_siguiente);
            this.Controls.Add(this.tetrisLogo);
            this.Controls.Add(this.l_puntuacion);
            this.Controls.Add(this.cajaGuardada);
            this.Controls.Add(this.cajaSiguiente);
            this.Controls.Add(this.caja);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.caja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajaSiguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajaGuardada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetrisLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox caja;
        private System.Windows.Forms.PictureBox cajaSiguiente;
        private System.Windows.Forms.PictureBox cajaGuardada;
        private System.Windows.Forms.Label l_puntuacion;
        private System.Windows.Forms.PictureBox tetrisLogo;
        private System.Windows.Forms.Label l_siguiente;
        private System.Windows.Forms.Label l_guardada;
    }
}

