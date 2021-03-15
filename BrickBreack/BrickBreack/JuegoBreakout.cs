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
    public partial class JuegoBreakout : Form
    {
        private int nivel;
        bool goRight; // es un booleano que se establece en falso de forma predeterminada. Lo configuraremos como verdadero cuando el jugador presione el botón derecho.
        bool goLeft; // es un booleano que se establece en falso como antes, esto también se establecerá en True cuando el jugador presione el botón izquierdo. Ambos booleanos volverán a ser falsos cuando el jugador suelte dichos botones hacia la izquierda o hacia la derecha.
        int speed = 10; // es un número entero con el valor de 5.

        int ballx = 5; //  es un número entero con el valor de 5.
        int bally = 5;// es un número entero con el valor de 5. Ambos números enteros se utilizan para mover la bola en el eje X o Y en el formulario de ventanas.
 
        int score = 0; //es el número entero que mantendrá la puntuación total del juego. Este entero se sumará 1 a sí mismo cuando golpeemos un bloque y lo saquemos de la pantalla.

        private Random rnd = new Random();

        public JuegoBreakout(int nivel)
        {
            InitializeComponent();

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "Block")
                {
                    Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    x.BackColor = randomColor;
                }
            }
            timer1.Interval = nivel;
            
        }

        private void JuegoBreakout_Load(object sender, EventArgs e)
        {

        }

        private void JuegoBreakout_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left && Jugador.Left > 0)
            {
                goLeft = true;
            }

            if (e.KeyCode == Keys.Right && Jugador.Left + Jugador.Width < 920)
            {
                goRight = true;
            }
        }

        private void JuegoBreakout_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pelota.Left += ballx;
            pelota.Top += bally;
            label1.Text = "Score: " + score;

            if (goLeft) { Jugador.Left -= speed; } // move left
            if (goRight) { Jugador.Left += speed; } // move right

            if (Jugador.Left < 1)
            {
                goLeft = false; // stop the car from going off screen
            }
            else if (Jugador.Left + Jugador.Width > 920)
            {
                goRight = false;
            }
            if (pelota.Left + pelota.Width > ClientSize.Width || pelota.Left < 0)
            {
                ballx = -ballx; // this will bounce the object from the left or right border
            }

            if (pelota.Top < 0 || pelota.Bounds.IntersectsWith(Jugador.Bounds))
            {
                bally = -bally; // this will bounce the object from top and bottom border
            }

            if (pelota.Top + pelota.Height > ClientSize.Height)
            {
                gameOver();
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "Block")
                {
                    if (pelota.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        bally = -bally;
                        score++;
                    }
                }
            }

            if (score > 34)
            {
                gameOver();
                MessageBox.Show("You Win");
            }
        }
        private void gameOver()
        {
            timer1.Stop();
            puntajeYguardado puntajejuga = new puntajeYguardado(score.ToString());
            puntajejuga.Show();
            this.Hide();
        }
    }
}
