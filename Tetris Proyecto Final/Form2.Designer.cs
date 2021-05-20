
namespace Tetris_Proyecto_Final
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tetrisLogo = new System.Windows.Forms.PictureBox();
            this.b_jugar = new System.Windows.Forms.Button();
            this.b_salir = new System.Windows.Forms.Button();
            this.b_ranking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tetrisLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tetrisLogo
            // 
            this.tetrisLogo.Image = ((System.Drawing.Image)(resources.GetObject("tetrisLogo.Image")));
            this.tetrisLogo.Location = new System.Drawing.Point(140, 30);
            this.tetrisLogo.Name = "tetrisLogo";
            this.tetrisLogo.Size = new System.Drawing.Size(300, 102);
            this.tetrisLogo.TabIndex = 0;
            this.tetrisLogo.TabStop = false;
            // 
            // b_jugar
            // 
            this.b_jugar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.b_jugar.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_jugar.Location = new System.Drawing.Point(240, 220);
            this.b_jugar.Name = "b_jugar";
            this.b_jugar.Size = new System.Drawing.Size(120, 50);
            this.b_jugar.TabIndex = 1;
            this.b_jugar.Text = "Jugar";
            this.b_jugar.UseVisualStyleBackColor = true;
            this.b_jugar.Click += new System.EventHandler(this.b_jugar_Click);
            // 
            // b_salir
            // 
            this.b_salir.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_salir.Location = new System.Drawing.Point(240, 500);
            this.b_salir.Name = "b_salir";
            this.b_salir.Size = new System.Drawing.Size(120, 50);
            this.b_salir.TabIndex = 2;
            this.b_salir.Text = "Salir";
            this.b_salir.UseVisualStyleBackColor = true;
            this.b_salir.Click += new System.EventHandler(this.b_salir_Click);
            // 
            // b_ranking
            // 
            this.b_ranking.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_ranking.Location = new System.Drawing.Point(240, 363);
            this.b_ranking.Name = "b_ranking";
            this.b_ranking.Size = new System.Drawing.Size(120, 50);
            this.b_ranking.TabIndex = 3;
            this.b_ranking.Text = "Ranking";
            this.b_ranking.UseVisualStyleBackColor = true;
            this.b_ranking.Click += new System.EventHandler(this.b_ranking_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 753);
            this.Controls.Add(this.b_ranking);
            this.Controls.Add(this.b_salir);
            this.Controls.Add(this.b_jugar);
            this.Controls.Add(this.tetrisLogo);
            this.Name = "Form2";
            this.Text = "Tetris";
            ((System.ComponentModel.ISupportInitialize)(this.tetrisLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox tetrisLogo;
        private System.Windows.Forms.Button b_jugar;
        private System.Windows.Forms.Button b_salir;
        private System.Windows.Forms.Button b_ranking;
    }
}