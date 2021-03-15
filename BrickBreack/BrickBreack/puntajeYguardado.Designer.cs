namespace BrickBreack
{
    partial class puntajeYguardado
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
            this.puntaje = new System.Windows.Forms.Label();
            this.Volver = new System.Windows.Forms.Button();
            this.PMenu = new System.Windows.Forms.Button();
            this.Guardad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // puntaje
            // 
            this.puntaje.AutoSize = true;
            this.puntaje.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntaje.Location = new System.Drawing.Point(70, 23);
            this.puntaje.Name = "puntaje";
            this.puntaje.Size = new System.Drawing.Size(322, 32);
            this.puntaje.TabIndex = 3;
            this.puntaje.Text = "Su puntaje : X puntos";
            // 
            // Volver
            // 
            this.Volver.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volver.Location = new System.Drawing.Point(12, 101);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(146, 56);
            this.Volver.TabIndex = 4;
            this.Volver.Text = "Volver a intentarlo";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // PMenu
            // 
            this.PMenu.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMenu.Location = new System.Drawing.Point(178, 101);
            this.PMenu.Name = "PMenu";
            this.PMenu.Size = new System.Drawing.Size(137, 56);
            this.PMenu.TabIndex = 5;
            this.PMenu.Text = "Menu Principal";
            this.PMenu.UseVisualStyleBackColor = true;
            this.PMenu.Click += new System.EventHandler(this.PMenu_Click);
            // 
            // Guardad
            // 
            this.Guardad.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardad.Location = new System.Drawing.Point(346, 101);
            this.Guardad.Name = "Guardad";
            this.Guardad.Size = new System.Drawing.Size(120, 56);
            this.Guardad.TabIndex = 6;
            this.Guardad.Text = "Guardar";
            this.Guardad.UseVisualStyleBackColor = true;
            this.Guardad.Click += new System.EventHandler(this.Guardad_Click);
            // 
            // puntajeYguardado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 169);
            this.Controls.Add(this.Guardad);
            this.Controls.Add(this.PMenu);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.puntaje);
            this.Name = "puntajeYguardado";
            this.Text = "puntajeYguardado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label puntaje;
        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Button PMenu;
        private System.Windows.Forms.Button Guardad;
    }
}