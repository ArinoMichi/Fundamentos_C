namespace Fundamentos
{
    partial class Form14Metodos
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
            btnDobleValor = new Button();
            btnDobleReferencia = new Button();
            btnObjetoReferencia = new Button();
            label1 = new Label();
            txtNumero = new TextBox();
            lblResultado = new Label();
            lblMouse = new Label();
            label3 = new Label();
            label2 = new Label();
            txtSoloNumeros = new TextBox();
            txtSoloLetras = new TextBox();
            SuspendLayout();
            // 
            // btnDobleValor
            // 
            btnDobleValor.Location = new Point(48, 172);
            btnDobleValor.Name = "btnDobleValor";
            btnDobleValor.Size = new Size(141, 47);
            btnDobleValor.TabIndex = 0;
            btnDobleValor.Text = "Doble Valor";
            btnDobleValor.UseVisualStyleBackColor = true;
            btnDobleValor.Click += btnDobleValor_Click;
            // 
            // btnDobleReferencia
            // 
            btnDobleReferencia.Location = new Point(44, 250);
            btnDobleReferencia.Name = "btnDobleReferencia";
            btnDobleReferencia.Size = new Size(162, 49);
            btnDobleReferencia.TabIndex = 1;
            btnDobleReferencia.Text = "Doble Referencia";
            btnDobleReferencia.UseVisualStyleBackColor = true;
            // 
            // btnObjetoReferencia
            // 
            btnObjetoReferencia.Location = new Point(42, 324);
            btnObjetoReferencia.Name = "btnObjetoReferencia";
            btnObjetoReferencia.Size = new Size(165, 48);
            btnObjetoReferencia.TabIndex = 2;
            btnObjetoReferencia.Text = "Objeto Referencia";
            btnObjetoReferencia.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 41);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Numero";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(48, 72);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(122, 23);
            txtNumero.TabIndex = 4;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(48, 130);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(38, 15);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "label2";
            // 
            // lblMouse
            // 
            lblMouse.BackColor = SystemColors.ActiveCaption;
            lblMouse.Location = new Point(249, 219);
            lblMouse.Name = "lblMouse";
            lblMouse.Size = new Size(299, 153);
            lblMouse.TabIndex = 6;
            lblMouse.Text = "label2";
            lblMouse.TextAlign = ContentAlignment.MiddleCenter;
            lblMouse.MouseMove += lblMouse_MouseMove;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 72);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 7;
            label3.Text = "Solo Numeros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 120);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 8;
            label2.Text = "Solo letras";
            // 
            // txtSoloNumeros
            // 
            txtSoloNumeros.Location = new Point(363, 69);
            txtSoloNumeros.Name = "txtSoloNumeros";
            txtSoloNumeros.Size = new Size(158, 23);
            txtSoloNumeros.TabIndex = 9;
            txtSoloNumeros.KeyPress += txtSoloNumeros_KeyPress;
            // 
            // txtSoloLetras
            // 
            txtSoloLetras.Location = new Point(353, 117);
            txtSoloLetras.Name = "txtSoloLetras";
            txtSoloLetras.Size = new Size(168, 23);
            txtSoloLetras.TabIndex = 10;
            // 
            // Form14Metodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSoloLetras);
            Controls.Add(txtSoloNumeros);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lblMouse);
            Controls.Add(lblResultado);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Controls.Add(btnObjetoReferencia);
            Controls.Add(btnDobleReferencia);
            Controls.Add(btnDobleValor);
            Name = "Form14Metodos";
            Text = "Form14Metodos";
            FormClosed += Form14Metodos_FormClosed;
            Load += Form14Metodos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDobleValor;
        private Button btnDobleReferencia;
        private Button btnObjetoReferencia;
        private Label label1;
        private TextBox txtNumero;
        private Label lblResultado;
        private Label lblMouse;
        private Label label3;
        private Label label2;
        private TextBox txtSoloNumeros;
        private TextBox txtSoloLetras;
    }
}