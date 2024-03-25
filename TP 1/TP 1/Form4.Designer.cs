
namespace TP_1
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.clbOficio = new System.Windows.Forms.CheckedListBox();
            this.rbSex1 = new System.Windows.Forms.RadioButton();
            this.rbSex2 = new System.Windows.Forms.RadioButton();
            this.rbCivil1 = new System.Windows.Forms.RadioButton();
            this.rbCivil2 = new System.Windows.Forms.RadioButton();
            this.btn1 = new System.Windows.Forms.Button();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb6 = new System.Windows.Forms.Label();
            this.lbOficio = new System.Windows.Forms.Label();
            this.lbCivil = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(7, 16);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(31, 13);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Sexo";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(469, 16);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(62, 13);
            this.lb2.TabIndex = 1;
            this.lb2.Text = "Estado Civil";
            // 
            // clbOficio
            // 
            this.clbOficio.CheckOnClick = true;
            this.clbOficio.FormattingEnabled = true;
            this.clbOficio.Items.AddRange(new object[] {
            "Data Entry",
            "Operador PC",
            "Programador",
            "Reparador PC",
            "Tester"});
            this.clbOficio.Location = new System.Drawing.Point(197, 132);
            this.clbOficio.Name = "clbOficio";
            this.clbOficio.Size = new System.Drawing.Size(120, 94);
            this.clbOficio.TabIndex = 3;
            this.clbOficio.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // rbSex1
            // 
            this.rbSex1.AutoCheck = false;
            this.rbSex1.AutoSize = true;
            this.rbSex1.Checked = true;
            this.rbSex1.Location = new System.Drawing.Point(10, 42);
            this.rbSex1.Name = "rbSex1";
            this.rbSex1.Size = new System.Drawing.Size(71, 17);
            this.rbSex1.TabIndex = 8;
            this.rbSex1.TabStop = true;
            this.rbSex1.Text = "Femenino";
            this.rbSex1.UseVisualStyleBackColor = true;
            this.rbSex1.CheckedChanged += new System.EventHandler(this.rbSex1_CheckedChanged);
            this.rbSex1.Click += new System.EventHandler(this.rbSex1_Click);
            // 
            // rbSex2
            // 
            this.rbSex2.AutoCheck = false;
            this.rbSex2.AutoSize = true;
            this.rbSex2.Location = new System.Drawing.Point(10, 79);
            this.rbSex2.Name = "rbSex2";
            this.rbSex2.Size = new System.Drawing.Size(73, 17);
            this.rbSex2.TabIndex = 9;
            this.rbSex2.Text = "Masculino";
            this.rbSex2.UseVisualStyleBackColor = true;
            this.rbSex2.Click += new System.EventHandler(this.rbSex2_Click);
            // 
            // rbCivil1
            // 
            this.rbCivil1.AutoCheck = false;
            this.rbCivil1.AutoSize = true;
            this.rbCivil1.Checked = true;
            this.rbCivil1.Location = new System.Drawing.Point(472, 42);
            this.rbCivil1.Name = "rbCivil1";
            this.rbCivil1.Size = new System.Drawing.Size(61, 17);
            this.rbCivil1.TabIndex = 10;
            this.rbCivil1.Text = "Casado";
            this.rbCivil1.UseVisualStyleBackColor = true;
            this.rbCivil1.CheckedChanged += new System.EventHandler(this.rbCivil1_CheckedChanged);
            this.rbCivil1.Click += new System.EventHandler(this.rbCivil1_Click);
            // 
            // rbCivil2
            // 
            this.rbCivil2.AutoCheck = false;
            this.rbCivil2.AutoSize = true;
            this.rbCivil2.Location = new System.Drawing.Point(472, 75);
            this.rbCivil2.Name = "rbCivil2";
            this.rbCivil2.Size = new System.Drawing.Size(58, 17);
            this.rbCivil2.TabIndex = 11;
            this.rbCivil2.Text = "Soltero";
            this.rbCivil2.UseVisualStyleBackColor = true;
            this.rbCivil2.CheckedChanged += new System.EventHandler(this.rbCivil2_CheckedChanged);
            this.rbCivil2.Click += new System.EventHandler(this.rbCivil2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(115, 245);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(281, 23);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "Mostrar lo que se selecciono.";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.Location = new System.Drawing.Point(-4, 280);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(355, 20);
            this.lb3.TabIndex = 13;
            this.lb3.Text = "Usted selecciono los siguientes elementos:";
            this.lb3.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.Location = new System.Drawing.Point(-3, 314);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(47, 16);
            this.lb4.TabIndex = 14;
            this.lb4.Text = "Sexo:";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5.Location = new System.Drawing.Point(-3, 339);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(93, 16);
            this.lb5.TabIndex = 15;
            this.lb5.Text = "Estado civil:";
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb6.Location = new System.Drawing.Point(-3, 365);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(52, 16);
            this.lb6.TabIndex = 16;
            this.lb6.Text = "Oficio:";
            // 
            // lbOficio
            // 
            this.lbOficio.AutoSize = true;
            this.lbOficio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOficio.Location = new System.Drawing.Point(50, 365);
            this.lbOficio.Name = "lbOficio";
            this.lbOficio.Size = new System.Drawing.Size(0, 16);
            this.lbOficio.TabIndex = 19;
            // 
            // lbCivil
            // 
            this.lbCivil.AutoSize = true;
            this.lbCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCivil.Location = new System.Drawing.Point(96, 339);
            this.lbCivil.Name = "lbCivil";
            this.lbCivil.Size = new System.Drawing.Size(0, 16);
            this.lbCivil.TabIndex = 18;
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSex.Location = new System.Drawing.Point(50, 314);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(0, 16);
            this.lbSex.TabIndex = 17;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.lbOficio);
            this.Controls.Add(this.lbCivil);
            this.Controls.Add(this.lbSex);
            this.Controls.Add(this.lb6);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.rbCivil2);
            this.Controls.Add(this.rbCivil1);
            this.Controls.Add(this.rbSex2);
            this.Controls.Add(this.rbSex1);
            this.Controls.Add(this.clbOficio);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Name = "Form4";
            this.Text = "Ejercicio 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.CheckedListBox clbOficio;
        private System.Windows.Forms.RadioButton rbSex1;
        private System.Windows.Forms.RadioButton rbSex2;
        private System.Windows.Forms.RadioButton rbCivil1;
        private System.Windows.Forms.RadioButton rbCivil2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lbOficio;
        private System.Windows.Forms.Label lbCivil;
        private System.Windows.Forms.Label lbSex;
    }
}