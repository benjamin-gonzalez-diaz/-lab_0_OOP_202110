using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreack
{
    public partial class puntajeYguardado : Form
    {

        private string puntajeJugador;
        public puntajeYguardado()
        {
            InitializeComponent();
        }
        public puntajeYguardado(string punto)
        {
            InitializeComponent();
            puntaje.Text = $"Su puntaje : {punto} puntos";
            puntajeJugador = punto;
        }
        public puntajeYguardado(string punto, bool visibilidad)
        {
            InitializeComponent();
            puntaje.Text = $"Su puntaje : {punto} puntos";
            puntajeJugador = punto;
            Guardad.Visible = visibilidad;
            Volver.Visible = visibilidad;
        }
        private void Guardad_Click(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream streamPuntajeBreakout = new FileStream("puntajeUnJugadorBrickBreack.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(streamPuntajeBreakout, puntajeJugador);
            streamPuntajeBreakout.Close();
        }

        private void PMenu_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Hide();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Niveles denuevo = new Niveles();
            denuevo.Show();
            this.Hide();
        }
    }
}
