
namespace Tetris_Proyecto_Final
{
    partial class Form3
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
            this.t_nombre = new System.Windows.Forms.TextBox();
            this.l_puntuacion = new System.Windows.Forms.Label();
            this.l_nombre = new System.Windows.Forms.Label();
            this.b_confirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // t_nombre
            // 
            this.t_nombre.Location = new System.Drawing.Point(41, 137);
            this.t_nombre.Name = "t_nombre";
            this.t_nombre.Size = new System.Drawing.Size(199, 27);
            this.t_nombre.TabIndex = 0;
            // 
            // l_puntuacion
            // 
            this.l_puntuacion.AutoSize = true;
            this.l_puntuacion.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_puntuacion.Location = new System.Drawing.Point(41, 26);
            this.l_puntuacion.Name = "l_puntuacion";
            this.l_puntuacion.Size = new System.Drawing.Size(131, 21);
            this.l_puntuacion.TabIndex = 1;
            this.l_puntuacion.Text = "Puntuacion: ";
            // 
            // l_nombre
            // 
            this.l_nombre.AutoSize = true;
            this.l_nombre.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_nombre.Location = new System.Drawing.Point(41, 100);
            this.l_nombre.Name = "l_nombre";
            this.l_nombre.Size = new System.Drawing.Size(89, 21);
            this.l_nombre.TabIndex = 2;
            this.l_nombre.Text = "Nombre:";
            // 
            // b_confirmar
            // 
            this.b_confirmar.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_confirmar.Location = new System.Drawing.Point(76, 267);
            this.b_confirmar.Name = "b_confirmar";
            this.b_confirmar.Size = new System.Drawing.Size(130, 29);
            this.b_confirmar.TabIndex = 3;
            this.b_confirmar.Text = "Confirmar";
            this.b_confirmar.UseVisualStyleBackColor = true;
            this.b_confirmar.Click += new System.EventHandler(this.b_confirmar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 353);
            this.Controls.Add(this.b_confirmar);
            this.Controls.Add(this.l_nombre);
            this.Controls.Add(this.l_puntuacion);
            this.Controls.Add(this.t_nombre);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_nombre;
        private System.Windows.Forms.Label l_puntuacion;
        private System.Windows.Forms.Label l_nombre;
        private System.Windows.Forms.Button b_confirmar;
    }
}