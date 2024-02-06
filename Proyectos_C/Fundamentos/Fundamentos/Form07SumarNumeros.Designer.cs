namespace Fundamentos
{
    partial class Form07SumarNumeros
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
            btnSumar = new Button();
            label1 = new Label();
            txtNumeros = new TextBox();
            lblSuma = new Label();
            SuspendLayout();
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(67, 138);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(153, 48);
            btnSumar.TabIndex = 0;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 50);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 1;
            label1.Text = "Introduce unos numeros:";
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(51, 85);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(193, 23);
            txtNumeros.TabIndex = 2;
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.Location = new Point(51, 237);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(43, 15);
            lblSuma.TabIndex = 3;
            lblSuma.Text = "Suma: ";
            // 
            // Form07SumarNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 328);
            Controls.Add(lblSuma);
            Controls.Add(txtNumeros);
            Controls.Add(label1);
            Controls.Add(btnSumar);
            Name = "Form07SumarNumeros";
            Text = "Form07SumarNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSumar;
        private Label label1;
        private TextBox txtNumeros;
        private Label lblSuma;
    }
}