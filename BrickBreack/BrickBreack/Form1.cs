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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CargarRecords_Click(object sender, EventArgs e)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream streamPuntajeBreakout = new FileStream("puntajeUnJugadorBrickBreack.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                string puntaje = (string)formatter.Deserialize(streamPuntajeBreakout);
                streamPuntajeBreakout.Close();
                puntajeYguardado puntajeCargado = new puntajeYguardado(puntaje, false);
                puntajeCargado.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("No hay nada guardado", "Error al Cargar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            //JuegoBrickBreack Game = new JuegoBrickBreack();
            //Game.Show(this);
            //this.Hide();

            //JuegoBreakout GAME = new JuegoBreakout();
            //GAME.Show(this);
            //this.Hide();
            Niveles seleccion = new Niveles();
            seleccion.Show();
            this.Hide();
        }
    }
}
