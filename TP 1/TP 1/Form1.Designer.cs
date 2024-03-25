
namespace TP_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(93, 40);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(163, 69);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "EJERCICIO 1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            this.btn1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn1_MouseClick);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(553, 40);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(163, 69);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "EJERCICIO  3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(317, 40);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(163, 69);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "EJERCICIO 2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(103, 200);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(125, 25);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Integrantes:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(282, 204);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(289, 180);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "- Nahuel Balk\r\n\r\n- Daniel Castro\r\n\r\n- Juan Carlos de Guayana Muñoz Salas\r\n\r\n- Luc" +
    "as Ezequiel Arturo Nuñez\r\n\r\n- Lucas Alejandro De Marchi";
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
    }
}

