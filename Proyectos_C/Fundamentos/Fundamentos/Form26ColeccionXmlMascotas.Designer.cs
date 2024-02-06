namespace Fundamentos
{
    partial class Form26ColeccionXmlMascotas
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombe = new TextBox();
            txtRaza = new TextBox();
            txtAnios = new TextBox();
            btnNuevaMascota = new Button();
            label4 = new Label();
            lstMascotas = new ListBox();
            btnLeerDatos = new Button();
            btnGuardarDatos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 21);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 121);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 1;
            label2.Text = "Raza";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 210);
            label3.Name = "label3";
            label3.Size = new Size(45, 21);
            label3.TabIndex = 2;
            label3.Text = "Años";
            // 
            // txtNombe
            // 
            txtNombe.Location = new Point(32, 65);
            txtNombe.Name = "txtNombe";
            txtNombe.Size = new Size(116, 29);
            txtNombe.TabIndex = 3;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(32, 159);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(111, 29);
            txtRaza.TabIndex = 4;
            // 
            // txtAnios
            // 
            txtAnios.Location = new Point(32, 251);
            txtAnios.Name = "txtAnios";
            txtAnios.Size = new Size(105, 29);
            txtAnios.TabIndex = 5;
            // 
            // btnNuevaMascota
            // 
            btnNuevaMascota.Location = new Point(32, 302);
            btnNuevaMascota.Name = "btnNuevaMascota";
            btnNuevaMascota.Size = new Size(165, 38);
            btnNuevaMascota.TabIndex = 6;
            btnNuevaMascota.Text = "Nueva Mascota";
            btnNuevaMascota.UseVisualStyleBackColor = true;
            btnNuevaMascota.Click += btnNuevaMascota_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 21);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 7;
            label4.Text = "Mascotas";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.ItemHeight = 21;
            lstMascotas.Location = new Point(244, 59);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(183, 235);
            lstMascotas.TabIndex = 8;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // btnLeerDatos
            // 
            btnLeerDatos.Location = new Point(472, 54);
            btnLeerDatos.Name = "btnLeerDatos";
            btnLeerDatos.Size = new Size(121, 51);
            btnLeerDatos.TabIndex = 9;
            btnLeerDatos.Text = "Leer Datos";
            btnLeerDatos.UseVisualStyleBackColor = true;
            btnLeerDatos.Click += btnLeerDatos_Click;
            // 
            // btnGuardarDatos
            // 
            btnGuardarDatos.Location = new Point(472, 121);
            btnGuardarDatos.Name = "btnGuardarDatos";
            btnGuardarDatos.Size = new Size(121, 49);
            btnGuardarDatos.TabIndex = 10;
            btnGuardarDatos.Text = "Guardar Datos";
            btnGuardarDatos.UseVisualStyleBackColor = true;
            btnGuardarDatos.Click += btnGuardarDatos_Click;
            // 
            // Form26ColeccionXmlMascotas
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 369);
            Controls.Add(btnGuardarDatos);
            Controls.Add(btnLeerDatos);
            Controls.Add(lstMascotas);
            Controls.Add(label4);
            Controls.Add(btnNuevaMascota);
            Controls.Add(txtAnios);
            Controls.Add(txtRaza);
            Controls.Add(txtNombe);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form26ColeccionXmlMascotas";
            Text = "Form26ColeccionXmlMascotas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombe;
        private TextBox txtRaza;
        private TextBox txtAnios;
        private Button btnNuevaMascota;
        private Label label4;
        private ListBox lstMascotas;
        private Button btnLeerDatos;
        private Button btnGuardarDatos;
    }
}