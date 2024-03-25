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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(lb1.SelectedIndex != -1)
            {
                int band = 0;
                int cont = lb2.Items.Count;
                string aux;
                string aux2;

                aux = (string)lb1.SelectedItem;

                for(int i=0; i<cont; i++)
                {
                    aux2 = (string)lb2.Items[i];
                    if(aux.ToUpper() == aux2.ToUpper())
                    {
                        band = 1;
                    }
                }
                if(band != 1)
                {
                    lb2.Items.Add(lb1.SelectedItem);
                    lb1.Items.Remove(lb1.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Ya se encuentra ese dato.");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar algun dato.");
            }
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(tb1.Text.Trim() != "")
            {
                int cont = lb1.Items.Count;
                int band = 0;
                string aux;

                //Validacion de nombre existente en listbox.
                for (int i = 0; i < cont; i++)
                {
                    aux = (string)lb1.Items[i];
                    if (aux.ToUpper() == tb1.Text.ToUpper())
                    {
                        band = 1;
                    }
                }

                if(band == 0)
                {
                    lb1.Items.Add(tb1.Text);
                    tb1.Text = "";
                }
                else
                {
                    MessageBox.Show("Ya se encuentra ese item.");
                    tb1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Ingrese algun nombre.");
                tb1.Text = "";
            }
            
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int cant = lb1.Items.Count;
            for(int i = 0; i < cant; i++)
            {
                int cont = lb2.Items.Count;
                int band = 0;
                string aux;
                string aux2;

                for (int x = 0; x < cont; x++)
                {
                    aux = (string)lb1.Items[i];
                    aux2 = (string)lb2.Items[x];
                    if (aux.ToUpper() == aux2.ToUpper())
                    {
                        band = 1;
                    }
                }

                if (band == 0)
                {
                    lb2.Items.Add(lb1.Items[i]);
                }
                else
                {
                    MessageBox.Show("Ya se encuentra ese item.");
                }
            }
            lb1.Items.Clear();
        }
    }
}
