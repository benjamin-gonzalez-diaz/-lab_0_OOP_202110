namespace BrickBreack
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Play = new System.Windows.Forms.Button();
            this.CargarRecords = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.Location = new System.Drawing.Point(12, 405);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(147, 68);
            this.Play.TabIndex = 3;
            this.Play.Text = "Jugar";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // CargarRecords
            // 
            this.CargarRecords.BackColor = System.Drawing.Color.Transparent;
            this.CargarRecords.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargarRecords.Location = new System.Drawing.Point(312, 407);
            this.CargarRecords.Name = "CargarRecords";
            this.CargarRecords.Size = new System.Drawing.Size(291, 66);
            this.CargarRecords.TabIndex = 4;
            this.CargarRecords.Text = "Cargar Puntajes";
            this.CargarRecords.UseVisualStyleBackColor = false;
            this.CargarRecords.Click += new System.EventHandler(this.CargarRecords_Click);
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(727, 407);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(161, 66);
            this.Close.TabIndex = 5;
            this.Close.Text = "Cerrar";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(714, 62);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bienvenido al juego brick breack";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BrickBreack.Properties.Resources.fondo_brickbreack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(911, 485);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.CargarRecords);
            this.Controls.Add(this.Play);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button CargarRecords;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label1;
    }
}

