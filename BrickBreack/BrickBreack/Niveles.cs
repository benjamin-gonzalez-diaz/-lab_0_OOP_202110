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
    public partial class Niveles : Form
    {
        public Niveles()
        {
            InitializeComponent();
        }

        private void Facil_Click(object sender, EventArgs e)
        {
            JuegoBreakout juegoF = new JuegoBreakout(30);
            juegoF.Show();
            this.Hide();
        }

        private void Normal_Click(object sender, EventArgs e)
        {
            JuegoBreakout juegoN = new JuegoBreakout(20);
            juegoN.Show();
            this.Hide();
        }

        private void Dificil_Click(object sender, EventArgs e)
        {
            JuegoBreakout juegoD = new JuegoBreakout(11);
            juegoD.Show();
            this.Hide();
        }

        private void MuyDificil_Click(object sender, EventArgs e)
        {
            JuegoBreakout juegoMD = new JuegoBreakout(6);
            juegoMD.Show();
            this.Hide();
        }

        private void imposible_Click(object sender, EventArgs e)
        {
            JuegoBreakout juegoI = new JuegoBreakout(1);
            juegoI.Show();
            this.Hide();
        }
    }
}
