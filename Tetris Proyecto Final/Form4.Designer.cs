
namespace Tetris_Proyecto_Final
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.l_puntuaciones = new System.Windows.Forms.Label();
            this.rtb_nombre = new System.Windows.Forms.RichTextBox();
            this.b_atras = new System.Windows.Forms.Button();
            this.rtb_puntuacion = new System.Windows.Forms.RichTextBox();
            this.rtb_fecha = new System.Windows.Forms.RichTextBox();
            this.tetrisLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tetrisLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // l_puntuaciones
            // 
            this.l_puntuaciones.AutoSize = true;
            this.l_puntuaciones.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_puntuaciones.Location = new System.Drawing.Point(177, 144);
            this.l_puntuaciones.Name = "l_puntuaciones";
            this.l_puntuaciones.Size = new System.Drawing.Size(229, 33);
            this.l_puntuaciones.TabIndex = 0;
            this.l_puntuaciones.Text = "Puntuaciones:";
            // 
            // rtb_nombre
            // 
            this.rtb_nombre.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtb_nombre.Location = new System.Drawing.Point(30, 200);
            this.rtb_nombre.Name = "rtb_nombre";
            this.rtb_nombre.Size = new System.Drawing.Size(220, 450);
            this.rtb_nombre.TabIndex = 2;
            this.rtb_nombre.Text = "";
            // 
            // b_atras
            // 
            this.b_atras.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_atras.Location = new System.Drawing.Point(240, 670);
            this.b_atras.Name = "b_atras";
            this.b_atras.Size = new System.Drawing.Size(120, 50);
            this.b_atras.TabIndex = 3;
            this.b_atras.Text = "Atras";
            this.b_atras.UseVisualStyleBackColor = true;
            this.b_atras.Click += new System.EventHandler(this.b_atras_Click);
            // 
            // rtb_puntuacion
            // 
            this.rtb_puntuacion.Location = new System.Drawing.Point(280, 200);
            this.rtb_puntuacion.Name = "rtb_puntuacion";
            this.rtb_puntuacion.Size = new System.Drawing.Size(150, 450);
            this.rtb_puntuacion.TabIndex = 4;
            this.rtb_puntuacion.Text = "";
            // 
            // rtb_fecha
            // 
            this.rtb_fecha.Location = new System.Drawing.Point(460, 200);
            this.rtb_fecha.Name = "rtb_fecha";
            this.rtb_fecha.Size = new System.Drawing.Size(90, 450);
            this.rtb_fecha.TabIndex = 5;
            this.rtb_fecha.Text = "";
            // 
            // tetrisLogo
            // 
            this.tetrisLogo.Image = ((System.Drawing.Image)(resources.GetObject("tetrisLogo.Image")));
            this.tetrisLogo.Location = new System.Drawing.Point(140, 30);
            this.tetrisLogo.Name = "tetrisLogo";
            this.tetrisLogo.Size = new System.Drawing.Size(300, 102);
            this.tetrisLogo.TabIndex = 6;
            this.tetrisLogo.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 753);
            this.Controls.Add(this.tetrisLogo);
            this.Controls.Add(this.rtb_fecha);
            this.Controls.Add(this.rtb_puntuacion);
            this.Controls.Add(this.b_atras);
            this.Controls.Add(this.rtb_nombre);
            this.Controls.Add(this.l_puntuaciones);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.tetrisLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_puntuaciones;
        private System.Windows.Forms.RichTextBox rtb_nombre;
        private System.Windows.Forms.Button b_atras;
        private System.Windows.Forms.RichTextBox rtb_puntuacion;
        private System.Windows.Forms.RichTextBox rtb_fecha;
        private System.Windows.Forms.PictureBox tetrisLogo;
    }
}