namespace Login
{
    partial class Form3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Boton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 455);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(814, 60);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "\r\n";
            // 
            // Boton
            // 
            this.Boton.Location = new System.Drawing.Point(1035, 464);
            this.Boton.Name = "Boton";
            this.Boton.Size = new System.Drawing.Size(91, 36);
            this.Boton.TabIndex = 1;
            this.Boton.Text = "Enviar";
            this.Boton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Peticiones anteriores:",
            "",
            "- ¿Cuando se fundó OOHRD?",
            "",
            "- Como puedo solicitar",
            "un envio de elementos?"});
            this.listBox1.Location = new System.Drawing.Point(18, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 498);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.AllowDrop = true;
            this.listBox2.BackColor = System.Drawing.Color.SeaShell;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Hola! Hazme una pregunta para comenzar...",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "Claro que si, la empresa fue fundada en el año 2010.",
            "OOH Redes Digitales tiene más de 14 años de experiencia en el sector de la señali" +
                "zación digital. ",
            "",
            "",
            "",
            "",
            "",
            "Claro!",
            "Para realizar un envio de elemento es necesario que envies los siguientes datos a" +
                " los correos de los encargados",
            "de logistica Felipe Chiappe, Maria Fernanda Baron y Albeiro Ramirez:",
            "",
            "Ubicacion",
            "Horario de recepcion de paqueteria",
            "Contacto y nombre de quien recibe",
            "",
            "",
            "Y debes entregar este elemento al área de logistica.",
            "Ellos se encargarán de enviar el elemento solicitado compartiendo la guia para su" +
                " seguimiento."});
            this.listBox2.Location = new System.Drawing.Point(180, 19);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(814, 407);
            this.listBox2.TabIndex = 3;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(732, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cuando se fundó la empresa OOHRD?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(656, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Como realizo un envio de elementos para un punto?";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 529);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Boton);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Boton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}