using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace diez_notas_forms
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal[] notas;
            notas = new decimal[10];

            notas[0] = decimal.Parse(textBox1.Text);
            notas[1] = decimal.Parse(textBox2.Text);
            notas[2] = decimal.Parse(textBox3.Text);
            notas[3] = decimal.Parse(textBox4.Text);
            notas[4] = decimal.Parse(textBox5.Text);
            notas[5] = decimal.Parse(textBox6.Text);
            notas[6] = decimal.Parse(textBox7.Text);
            notas[7] = decimal.Parse(textBox8.Text);
            notas[8] = decimal.Parse(textBox9.Text);
            notas[9] = decimal.Parse(textBox10.Text);
            decimal aprobado = 7;
            int mayor_igual = 0;
            int menor = 0;

            for (int i = 0; i < 10; i++)
            {
                if (notas[i]>=aprobado)
                {
                    mayor_igual++;

                }
                else
                {
                    menor++;
                }
            }

            label2.Text = $@"Los aprobados fueron: {mayor_igual}
Los reprobados fueron: {menor}";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";

            // Limpiar el Label de resultados
            label2.Text = "";

            // Colocar el cursor en el primer TextBox
            textBox1.Focus();

        }
    }
}
