namespace BrickBreack
{
    partial class JuegoBrickBreack
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
            this.components = new System.ComponentModel.Container();
            this.raqueta = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pelota = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.raqueta)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pelota)).BeginInit();
            this.SuspendLayout();
            // 
            // raqueta
            // 
            this.raqueta.BackgroundImage = global::BrickBreack.Properties.Resources.raqueta_BrickBreack;
            this.raqueta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.raqueta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.raqueta.Location = new System.Drawing.Point(3, 697);
            this.raqueta.Name = "raqueta";
            this.raqueta.Size = new System.Drawing.Size(138, 34);
            this.raqueta.TabIndex = 1;
            this.raqueta.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::BrickBreack.Properties.Resources.fondo_brickbreack;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Pelota);
            this.panel1.Location = new System.Drawing.Point(3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 693);
            this.panel1.TabIndex = 0;
            // 
            // Pelota
            // 
            this.Pelota.BackgroundImage = global::BrickBreack.Properties.Resources.pelota_brickbreack;
            this.Pelota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pelota.Location = new System.Drawing.Point(227, 186);
            this.Pelota.Name = "Pelota";
            this.Pelota.Size = new System.Drawing.Size(28, 26);
            this.Pelota.TabIndex = 0;
            this.Pelota.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // JuegoBrickBreack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 729);
            this.Controls.Add(this.raqueta);
            this.Controls.Add(this.panel1);
            this.Name = "JuegoBrickBreack";
            this.Text = "JuegoBrickBreack";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JuegoBrickBreack_FormClosing);
            this.Load += new System.EventHandler(this.JuegoBrickBreack_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.JuegoBrickBreack_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.raqueta)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pelota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox raqueta;
        private System.Windows.Forms.PictureBox Pelota;
        private System.Windows.Forms.Timer timer1;
    }
}