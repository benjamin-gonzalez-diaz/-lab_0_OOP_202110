namespace BrickBreack
{
    partial class Niveles
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
            this.label1 = new System.Windows.Forms.Label();
            this.Facil = new System.Windows.Forms.Button();
            this.Normal = new System.Windows.Forms.Button();
            this.Dificil = new System.Windows.Forms.Button();
            this.MuyDificil = new System.Windows.Forms.Button();
            this.imposible = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(609, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el nivel de dificultad";
            // 
            // Facil
            // 
            this.Facil.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Facil.Location = new System.Drawing.Point(63, 161);
            this.Facil.Name = "Facil";
            this.Facil.Size = new System.Drawing.Size(137, 73);
            this.Facil.TabIndex = 1;
            this.Facil.Text = "Facil";
            this.Facil.UseVisualStyleBackColor = true;
            this.Facil.Click += new System.EventHandler(this.Facil_Click);
            // 
            // Normal
            // 
            this.Normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Normal.Location = new System.Drawing.Point(224, 161);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(110, 73);
            this.Normal.TabIndex = 2;
            this.Normal.Text = "Normal";
            this.Normal.UseVisualStyleBackColor = true;
            this.Normal.Click += new System.EventHandler(this.Normal_Click);
            // 
            // Dificil
            // 
            this.Dificil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dificil.Location = new System.Drawing.Point(358, 161);
            this.Dificil.Name = "Dificil";
            this.Dificil.Size = new System.Drawing.Size(94, 73);
            this.Dificil.TabIndex = 3;
            this.Dificil.Text = "Dificil";
            this.Dificil.UseVisualStyleBackColor = true;
            this.Dificil.Click += new System.EventHandler(this.Dificil_Click);
            // 
            // MuyDificil
            // 
            this.MuyDificil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuyDificil.Location = new System.Drawing.Point(482, 161);
            this.MuyDificil.Name = "MuyDificil";
            this.MuyDificil.Size = new System.Drawing.Size(126, 73);
            this.MuyDificil.TabIndex = 4;
            this.MuyDificil.Text = "muy Dificil";
            this.MuyDificil.UseVisualStyleBackColor = true;
            this.MuyDificil.Click += new System.EventHandler(this.MuyDificil_Click);
            // 
            // imposible
            // 
            this.imposible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imposible.Location = new System.Drawing.Point(628, 161);
            this.imposible.Name = "imposible";
            this.imposible.Size = new System.Drawing.Size(106, 73);
            this.imposible.TabIndex = 5;
            this.imposible.Text = "imposible";
            this.imposible.UseVisualStyleBackColor = true;
            this.imposible.Click += new System.EventHandler(this.imposible_Click);
            // 
            // Niveles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BrickBreack.Properties.Resources.raqueta_BrickBreack;
            this.ClientSize = new System.Drawing.Size(800, 283);
            this.Controls.Add(this.imposible);
            this.Controls.Add(this.MuyDificil);
            this.Controls.Add(this.Dificil);
            this.Controls.Add(this.Normal);
            this.Controls.Add(this.Facil);
            this.Controls.Add(this.label1);
            this.Name = "Niveles";
            this.Text = "Niveles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Facil;
        private System.Windows.Forms.Button Normal;
        private System.Windows.Forms.Button Dificil;
        private System.Windows.Forms.Button MuyDificil;
        private System.Windows.Forms.Button imposible;
    }
}