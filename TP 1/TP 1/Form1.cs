using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void btn1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //Al hacer click, se hace visible el formulario.
            Form2 ventana1 = new Form2();
            ventana1.Visible = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //Al hacer click, se hace visible el formulario.
            Form3 ventana2 = new Form3();
            ventana2.Visible = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //Al hacer click, se hace visible el formulario.
            Form4 ventana3 = new Form4();
            ventana3.Visible = true;
        }
    }
}
