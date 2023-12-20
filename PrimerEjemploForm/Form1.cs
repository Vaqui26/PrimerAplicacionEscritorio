using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerEjemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int contador;


        private void button1_Click(object sender, EventArgs e)
        {
            contador++;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string text = textNombre.Text;
            MessageBox.Show("Total de " + text + " clicks son : " + contador);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Ingrese su nombre el cuadro blanco por favor.");
        }
    }
}
