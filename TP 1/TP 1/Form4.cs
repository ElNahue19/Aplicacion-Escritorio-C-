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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        private void btn1_Click(object sender, EventArgs e)
        { 
            //Vemos si el primer check de sexo esta activado
            if (rbSex1.Checked)
            {
                lbSex.Text = rbSex1.Text;
            }
            //Sino lo esta, el otro lo esta
            else
            {
                lbSex.Text = rbSex2.Text;
            }
            //Lo mismo para civil
            if (rbCivil1.Checked)
            {
                lbCivil.Text = rbCivil1.Text;
            }
            else
            {
                lbCivil.Text = rbCivil2.Text;
            }
            int cant = clbOficio.CheckedItems.Count; 
            lbOficio.Text = "";
            for(int i = 0; i < cant; i++)
            {
                lbOficio.Text =  lbOficio.Text + '\n' + "- " + clbOficio.CheckedItems[i]; 
            }
            
        }

        private void rbSex1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbSex2_Click(object sender, EventArgs e)
        {
             rbSex1.Checked = false;
             rbSex2.Checked = true;
        }

        private void rbCivil1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbCivil2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbSex1_Click(object sender, EventArgs e)
        {
            rbSex1.Checked = true;
            rbSex2.Checked = false;
        }

        private void rbCivil1_Click(object sender, EventArgs e)
        {
            rbCivil1.Checked = true;
            rbCivil2.Checked = false;
        }

        private void rbCivil2_Click(object sender, EventArgs e)
        {
            rbCivil1.Checked = false;
            rbCivil2.Checked = true;
        }
    }
}
