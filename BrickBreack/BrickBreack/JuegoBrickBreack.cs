using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreack
{
    public partial class JuegoBrickBreack : Form
    {
        public JuegoBrickBreack()
        {
            InitializeComponent();
        }

        int velocidad = 10;
        int count = 0; //medir el puntaje
        int puntaje;

        bool Arriba;
        bool Izquierda;

        private void JuegoBrickBreack_MouseMove(object sender, MouseEventArgs e)
        {
            raqueta.Left = e.X;
        }

        private void JuegoBrickBreack_Load(object sender, EventArgs e)
        {
            this.Text = "puntaje: 0";
            Random aleatorio = new Random();
            //Pelota.Location = new Point(0, aleatorio.Next(this.Height));
            Pelota.Location = new Point(aleatorio.Next(this.Width), 0);
            Arriba = true;
            Izquierda = true;
            timer1.Enabled = true;
            puntaje = 0;
        }

        private void JuegoBrickBreack_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.Owner.Show(); //  muestro el owner
                MessageBox.Show("Saliendo de la aplicacion", "SALIENDO", MessageBoxButtons.OK);
            }
            catch
            {
                Form1 MenuPrincipal = new Form1();
                MenuPrincipal.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Pelota.Top > raqueta.Top) // se pierde
            {
                timer1.Enabled = false;
                puntajeYguardado nuevoPuntaje = new puntajeYguardado(puntaje.ToString());
                nuevoPuntaje.Show();
                this.Hide();
                puntaje = 0;
                velocidad = 5;
                count = 0;
            }

            // rebote de la pelota
            if(Pelota.Left + Pelota.Width >= raqueta.Left && // verifica el choque con la raqueta
               Pelota.Left + Pelota.Width <= raqueta.Left + raqueta.Width &&// que no pase de la posicion de la raqueta
               Pelota.Top + Pelota.Height >= raqueta.Top && // que no se pase de la parte de arriba de la raqueta
               Pelota.Top + Pelota.Height <= raqueta.Top + raqueta.Height) // que no se pase de la parte de abajo de la raqueta

           //         if (Pelota.Left + Pelota.Width >= raqueta.Left && // verifica el choque con la raqueta
           //Pelota.Left + Pelota.Width <= raqueta.Left + raqueta.Width &&// que no pase de la posicion de la raqueta
           //Pelota.Top + Pelota.Height >= raqueta.Top && // que no se pase de la parte de arriba de la raqueta
           //Pelota.Top + Pelota.Height <= raqueta.Top + raqueta.Height) // que no se pase de la parte de abajo de la raqueta
                {
                Izquierda = false;
                puntaje += 1;
                this.Text = $"puntuacion: {puntaje}";
                count += 1;
                if (count >= 2)
                {
                    velocidad += 1;
                    count = 0;
                }
            }
            #region Movimiento de la pelota
            if (Izquierda)
            {
                Pelota.Left += velocidad; // va para la derecha

            }
            else
            {
                Pelota.Left -= velocidad; // va para la izquierda
            }
            if (Arriba)
            {
                Pelota.Top += velocidad; // va para abajo
            }
            else
            {
                Pelota.Top -= velocidad; // va para arriba
            }
            //if (Pelota.Top >= this.Height - 60) // si pega en la pared de abajo
            //{
            //    Arriba = false;
            //}
            if (Pelota.Top <= 0) // si pega en la pared de arriba
            {
                Arriba = true;
            }

            if (Pelota.Left <= 0) // si pega en la pared de la izquierda
            {
                Izquierda = true;
            }

            if (Pelota.Left >= this.Width - 60) // si pega en la pared de la derecha
            {
                Izquierda = false;
            }

            #endregion
        }
    }
}
