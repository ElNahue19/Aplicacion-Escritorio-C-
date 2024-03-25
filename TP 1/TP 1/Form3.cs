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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ordenar()
        {
            listBox1.Sorted = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "")
            {
                int cant = listBox1.Items.Count;
                int band = 0;
                string aux;
                

                //Buscar coincidencias en el listbox
                for (int i = 0; i < cant; i++)
                {
                    aux = (string)listBox1.Items[i];
                    if(textBox1.Text + " " + textBox2.Text == aux)
                    {
                        band = 1;
                    }

                }

                if (band != 1)
                {
                    listBox1.Items.Add(textBox1.Text + " " + textBox2.Text);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    ordenar();
                }
                else
                {
                    MessageBox.Show("Ya existe ese registro.");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                
            }
            else
            {
                MessageBox.Show("Debe ingresar el Nombre y Apellido.");
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ind = listBox1.SelectedIndex;
            if(ind != -1)
            {
                listBox1.Items.RemoveAt(ind);
            }
            else
            {
                MessageBox.Show("Debe seleccionar algun elemento.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
