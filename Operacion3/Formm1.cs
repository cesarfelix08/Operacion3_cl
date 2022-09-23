using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacion3
{
    public partial class Form1
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operacion3 operacion = new Operacion3(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox3.Text = operacion.multiplicar().ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

