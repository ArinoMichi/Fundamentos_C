namespace Fundamentos
{
    partial class Form27ColeccionBinaryMascotas
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
            btnGuardarDatos = new Button();
            btnLeerDatos = new Button();
            lstMascotas = new ListBox();
            label4 = new Label();
            btnNuevaMascota = new Button();
            txtAnios = new TextBox();
            txtRaza = new TextBox();
            txtNombe = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnGuardarDatos
            // 
            btnGuardarDatos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardarDatos.Location = new Point(495, 133);
            btnGuardarDatos.Name = "btnGuardarDatos";
            btnGuardarDatos.Size = new Size(121, 49);
            btnGuardarDatos.TabIndex = 21;
            btnGuardarDatos.Text = "Guardar Datos";
            btnGuardarDatos.UseVisualStyleBackColor = true;
            btnGuardarDatos.Click += btnGuardarDatos_Click;
            // 
            // btnLeerDatos
            // 
            btnLeerDatos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLeerDatos.Location = new Point(495, 66);
            btnLeerDatos.Name = "btnLeerDatos";
            btnLeerDatos.Size = new Size(121, 51);
            btnLeerDatos.TabIndex = 20;
            btnLeerDatos.Text = "Leer Datos";
            btnLeerDatos.UseVisualStyleBackColor = true;
            btnLeerDatos.Click += btnLeerDatos_Click;
            // 
            // lstMascotas
            // 
            lstMascotas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstMascotas.FormattingEnabled = true;
            lstMascotas.ItemHeight = 21;
            lstMascotas.Location = new Point(267, 71);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(183, 235);
            lstMascotas.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(271, 33);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 18;
            label4.Text = "Mascotas";
            // 
            // btnNuevaMascota
            // 
            btnNuevaMascota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevaMascota.Location = new Point(55, 314);
            btnNuevaMascota.Name = "btnNuevaMascota";
            btnNuevaMascota.Size = new Size(165, 38);
            btnNuevaMascota.TabIndex = 17;
            btnNuevaMascota.Text = "Nueva Mascota";
            btnNuevaMascota.UseVisualStyleBackColor = true;
            btnNuevaMascota.Click += btnNuevaMascota_Click;
            // 
            // txtAnios
            // 
            txtAnios.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAnios.Location = new Point(55, 263);
            txtAnios.Name = "txtAnios";
            txtAnios.Size = new Size(105, 29);
            txtAnios.TabIndex = 16;
            // 
            // txtRaza
            // 
            txtRaza.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRaza.Location = new Point(55, 171);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(111, 29);
            txtRaza.TabIndex = 15;
            // 
            // txtNombe
            // 
            txtNombe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombe.Location = new Point(55, 77);
            txtNombe.Name = "txtNombe";
            txtNombe.Size = new Size(116, 29);
            txtNombe.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(55, 222);
            label3.Name = "label3";
            label3.Size = new Size(45, 21);
            label3.TabIndex = 13;
            label3.Text = "Años";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(55, 133);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 12;
            label2.Text = "Raza";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 33);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 11;
            label1.Text = "Nombre";
            // 
            // Form27ColeccionBinaryMascotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 382);
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
            Name = "Form27ColeccionBinaryMascotas";
            Text = "Form27ColeccionBinaryMascotas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardarDatos;
        private Button btnLeerDatos;
        private ListBox lstMascotas;
        private Label label4;
        private Button btnNuevaMascota;
        private TextBox txtAnios;
        private TextBox txtRaza;
        private TextBox txtNombe;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}