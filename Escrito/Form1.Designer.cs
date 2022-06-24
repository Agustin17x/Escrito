namespace Escrito24_06_2022
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
            this.lbAmateur = new System.Windows.Forms.ListBox();
            this.btnAmateurAgregar = new System.Windows.Forms.Button();
            this.btnProfesionalAgregar = new System.Windows.Forms.Button();
            this.lbProfesional = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCiAmateur = new System.Windows.Forms.TextBox();
            this.txtNombreAmateur = new System.Windows.Forms.TextBox();
            this.txtFechaNacAmateur = new System.Windows.Forms.TextBox();
            this.txtCantHorasAmateur = new System.Windows.Forms.TextBox();
            this.txtAntiguedad = new System.Windows.Forms.TextBox();
            this.txtCiProfesional = new System.Windows.Forms.TextBox();
            this.txtNomProfesional = new System.Windows.Forms.TextBox();
            this.txtFechaNacProfesional = new System.Windows.Forms.TextBox();
            this.txtCantHorasProfesional = new System.Windows.Forms.TextBox();
            this.txtSueldoProfesional = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLimpiarAmateur = new System.Windows.Forms.Button();
            this.btnLimpiarProfesionales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAmateur
            // 
            this.lbAmateur.FormattingEnabled = true;
            this.lbAmateur.Location = new System.Drawing.Point(40, 307);
            this.lbAmateur.Name = "lbAmateur";
            this.lbAmateur.Size = new System.Drawing.Size(558, 225);
            this.lbAmateur.TabIndex = 0;
            // 
            // btnAmateurAgregar
            // 
            this.btnAmateurAgregar.Location = new System.Drawing.Point(208, 264);
            this.btnAmateurAgregar.Name = "btnAmateurAgregar";
            this.btnAmateurAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAmateurAgregar.TabIndex = 1;
            this.btnAmateurAgregar.Text = "Agregar";
            this.btnAmateurAgregar.UseVisualStyleBackColor = true;
            this.btnAmateurAgregar.Click += new System.EventHandler(this.btnAmateurAgregar_Click);
            // 
            // btnProfesionalAgregar
            // 
            this.btnProfesionalAgregar.Location = new System.Drawing.Point(855, 264);
            this.btnProfesionalAgregar.Name = "btnProfesionalAgregar";
            this.btnProfesionalAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnProfesionalAgregar.TabIndex = 3;
            this.btnProfesionalAgregar.Text = "Agregar";
            this.btnProfesionalAgregar.UseVisualStyleBackColor = true;
            this.btnProfesionalAgregar.Click += new System.EventHandler(this.btnProfesionalAgregar_Click);
            // 
            // lbProfesional
            // 
            this.lbProfesional.FormattingEnabled = true;
            this.lbProfesional.Location = new System.Drawing.Point(663, 307);
            this.lbProfesional.Name = "lbProfesional";
            this.lbProfesional.Size = new System.Drawing.Size(447, 225);
            this.lbProfesional.TabIndex = 6;
            this.lbProfesional.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Deportistas Amateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(874, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Deportistas Profesionales";
            // 
            // txtCiAmateur
            // 
            this.txtCiAmateur.Location = new System.Drawing.Point(259, 79);
            this.txtCiAmateur.Name = "txtCiAmateur";
            this.txtCiAmateur.Size = new System.Drawing.Size(100, 20);
            this.txtCiAmateur.TabIndex = 9;
            // 
            // txtNombreAmateur
            // 
            this.txtNombreAmateur.Location = new System.Drawing.Point(259, 117);
            this.txtNombreAmateur.Name = "txtNombreAmateur";
            this.txtNombreAmateur.Size = new System.Drawing.Size(100, 20);
            this.txtNombreAmateur.TabIndex = 10;
            // 
            // txtFechaNacAmateur
            // 
            this.txtFechaNacAmateur.Location = new System.Drawing.Point(259, 152);
            this.txtFechaNacAmateur.Name = "txtFechaNacAmateur";
            this.txtFechaNacAmateur.Size = new System.Drawing.Size(100, 20);
            this.txtFechaNacAmateur.TabIndex = 11;
            // 
            // txtCantHorasAmateur
            // 
            this.txtCantHorasAmateur.Location = new System.Drawing.Point(259, 190);
            this.txtCantHorasAmateur.Name = "txtCantHorasAmateur";
            this.txtCantHorasAmateur.Size = new System.Drawing.Size(100, 20);
            this.txtCantHorasAmateur.TabIndex = 12;
            // 
            // txtAntiguedad
            // 
            this.txtAntiguedad.Location = new System.Drawing.Point(259, 224);
            this.txtAntiguedad.Name = "txtAntiguedad";
            this.txtAntiguedad.Size = new System.Drawing.Size(100, 20);
            this.txtAntiguedad.TabIndex = 13;
            // 
            // txtCiProfesional
            // 
            this.txtCiProfesional.Location = new System.Drawing.Point(900, 79);
            this.txtCiProfesional.Name = "txtCiProfesional";
            this.txtCiProfesional.Size = new System.Drawing.Size(100, 20);
            this.txtCiProfesional.TabIndex = 14;
            // 
            // txtNomProfesional
            // 
            this.txtNomProfesional.Location = new System.Drawing.Point(900, 117);
            this.txtNomProfesional.Name = "txtNomProfesional";
            this.txtNomProfesional.Size = new System.Drawing.Size(100, 20);
            this.txtNomProfesional.TabIndex = 15;
            // 
            // txtFechaNacProfesional
            // 
            this.txtFechaNacProfesional.Location = new System.Drawing.Point(900, 152);
            this.txtFechaNacProfesional.Name = "txtFechaNacProfesional";
            this.txtFechaNacProfesional.Size = new System.Drawing.Size(100, 20);
            this.txtFechaNacProfesional.TabIndex = 16;
            // 
            // txtCantHorasProfesional
            // 
            this.txtCantHorasProfesional.Location = new System.Drawing.Point(900, 190);
            this.txtCantHorasProfesional.Name = "txtCantHorasProfesional";
            this.txtCantHorasProfesional.Size = new System.Drawing.Size(100, 20);
            this.txtCantHorasProfesional.TabIndex = 17;
            // 
            // txtSueldoProfesional
            // 
            this.txtSueldoProfesional.Location = new System.Drawing.Point(900, 224);
            this.txtSueldoProfesional.Name = "txtSueldoProfesional";
            this.txtSueldoProfesional.Size = new System.Drawing.Size(100, 20);
            this.txtSueldoProfesional.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "CI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Cantidad Horas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Antiguedad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(798, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Cantidad Horas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(834, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Nombre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(834, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Sueldo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(772, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Fecha de nacimiento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(861, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "CI";
            // 
            // btnLimpiarAmateur
            // 
            this.btnLimpiarAmateur.Location = new System.Drawing.Point(321, 264);
            this.btnLimpiarAmateur.Name = "btnLimpiarAmateur";
            this.btnLimpiarAmateur.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarAmateur.TabIndex = 29;
            this.btnLimpiarAmateur.Text = "Limpiar";
            this.btnLimpiarAmateur.UseVisualStyleBackColor = true;
            this.btnLimpiarAmateur.Click += new System.EventHandler(this.btnLimpiarAmateur_Click);
            // 
            // btnLimpiarProfesionales
            // 
            this.btnLimpiarProfesionales.Location = new System.Drawing.Point(966, 264);
            this.btnLimpiarProfesionales.Name = "btnLimpiarProfesionales";
            this.btnLimpiarProfesionales.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarProfesionales.TabIndex = 30;
            this.btnLimpiarProfesionales.Text = "Limpiar";
            this.btnLimpiarProfesionales.UseVisualStyleBackColor = true;
            this.btnLimpiarProfesionales.Click += new System.EventHandler(this.btnLimpiarProfesionales_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 591);
            this.Controls.Add(this.btnLimpiarProfesionales);
            this.Controls.Add(this.btnLimpiarAmateur);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSueldoProfesional);
            this.Controls.Add(this.txtCantHorasProfesional);
            this.Controls.Add(this.txtFechaNacProfesional);
            this.Controls.Add(this.txtNomProfesional);
            this.Controls.Add(this.txtCiProfesional);
            this.Controls.Add(this.txtAntiguedad);
            this.Controls.Add(this.txtCantHorasAmateur);
            this.Controls.Add(this.txtFechaNacAmateur);
            this.Controls.Add(this.txtNombreAmateur);
            this.Controls.Add(this.txtCiAmateur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbProfesional);
            this.Controls.Add(this.btnProfesionalAgregar);
            this.Controls.Add(this.btnAmateurAgregar);
            this.Controls.Add(this.lbAmateur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAmateur;
        private System.Windows.Forms.Button btnAmateurAgregar;
        private System.Windows.Forms.Button btnProfesionalAgregar;
        private System.Windows.Forms.ListBox lbProfesional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCiAmateur;
        private System.Windows.Forms.TextBox txtNombreAmateur;
        private System.Windows.Forms.TextBox txtFechaNacAmateur;
        private System.Windows.Forms.TextBox txtCantHorasAmateur;
        private System.Windows.Forms.TextBox txtAntiguedad;
        private System.Windows.Forms.TextBox txtCiProfesional;
        private System.Windows.Forms.TextBox txtNomProfesional;
        private System.Windows.Forms.TextBox txtFechaNacProfesional;
        private System.Windows.Forms.TextBox txtCantHorasProfesional;
        private System.Windows.Forms.TextBox txtSueldoProfesional;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnLimpiarAmateur;
        private System.Windows.Forms.Button btnLimpiarProfesionales;
    }
}

