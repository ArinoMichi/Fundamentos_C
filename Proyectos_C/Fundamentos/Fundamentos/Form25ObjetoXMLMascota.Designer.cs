namespace Fundamentos
{
    partial class Form25ObjetoXMLMascota
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
            txtNombre = new TextBox();
            txtRaza = new TextBox();
            txtAnios = new TextBox();
            btnLeerDato = new Button();
            btnGuardarDato = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 49);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 130);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "Raza";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 207);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 2;
            label3.Text = "Años";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(44, 82);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(131, 27);
            txtNombre.TabIndex = 3;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(43, 166);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(130, 27);
            txtRaza.TabIndex = 4;
            // 
            // txtAnios
            // 
            txtAnios.Location = new Point(43, 246);
            txtAnios.Name = "txtAnios";
            txtAnios.Size = new Size(132, 27);
            txtAnios.TabIndex = 5;
            // 
            // btnLeerDato
            // 
            btnLeerDato.Location = new Point(318, 98);
            btnLeerDato.Name = "btnLeerDato";
            btnLeerDato.Size = new Size(176, 52);
            btnLeerDato.TabIndex = 6;
            btnLeerDato.Text = "Leer Dato";
            btnLeerDato.UseVisualStyleBackColor = true;
            btnLeerDato.Click += btnLeerDato_Click;
            // 
            // btnGuardarDato
            // 
            btnGuardarDato.Location = new Point(318, 185);
            btnGuardarDato.Name = "btnGuardarDato";
            btnGuardarDato.Size = new Size(176, 65);
            btnGuardarDato.TabIndex = 7;
            btnGuardarDato.Text = "Guardar Dato";
            btnGuardarDato.UseVisualStyleBackColor = true;
            btnGuardarDato.Click += btnGuardarDato_Click;
            // 
            // Form25ObjetoXMLMascota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 396);
            Controls.Add(btnGuardarDato);
            Controls.Add(btnLeerDato);
            Controls.Add(txtAnios);
            Controls.Add(txtRaza);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form25ObjetoXMLMascota";
            Text = "Form25ObjetoXMLMascota";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtRaza;
        private TextBox txtAnios;
        private Button btnLeerDato;
        private Button btnGuardarDato;
    }
}