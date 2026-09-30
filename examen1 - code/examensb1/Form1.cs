using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examensb1
{
    public partial class Form1 : Form
    {
        Vector v1, v2, v3, v4;

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = v1.Descargar();
        }

        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            v2.CargarRnd(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            textBox6.Text = v2.Descargar();
        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox7.Text = v2.Descargar();
        }

        private void cargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            v3.CargarRnd(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            textBox7.Text = v3.Descargar();
        }

        private void descargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox8.Text = v3.Descargar();
        }


        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.CargarRnd(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            textBox5.Text = v1.Descargar();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            v1 = new Vector();
            v2 = new Vector();
            v3 = new Vector();
            v4 = new Vector();
        }

        //Ejercicio1

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.Ejercicio1(ref v2);
        }
        //Ejercicio2

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //v1.ejercicio2(int.Parse(textBox1.Text), int.Parse(textBox2.Text), ref v2, ref v3);
            //textBox7.Text = v2.Descargar(); // valores
            //textBox8.Text = v3.Descargar(); // frecuencias
            int a = int.Parse(textBox2.Text);
            int b = int.Parse(textBox3.Text);

            v1.ejercicio2(a, b, ref v2, ref v3);

            //textBox7.Text = v2.Descargar();
            //textBox8.Text = v3.Descargar();
        }
    }
}
