namespace Fundamentos
{
    partial class Form02PosicionColores
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
            txtPosicionX = new TextBox();
            txtPosicionY = new TextBox();
            btnPosicion = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtRojo = new TextBox();
            txtVerde = new TextBox();
            txtAzul = new TextBox();
            btnBgColor = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 24);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Posicion de la x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 51);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 1;
            label2.Text = "Poscicion de la y";
            // 
            // txtPosicionX
            // 
            txtPosicionX.Location = new Point(160, 21);
            txtPosicionX.Name = "txtPosicionX";
            txtPosicionX.Size = new Size(74, 23);
            txtPosicionX.TabIndex = 2;
            // 
            // txtPosicionY
            // 
            txtPosicionY.Location = new Point(160, 48);
            txtPosicionY.Name = "txtPosicionY";
            txtPosicionY.Size = new Size(74, 23);
            txtPosicionY.TabIndex = 3;
            // 
            // btnPosicion
            // 
            btnPosicion.Location = new Point(80, 92);
            btnPosicion.Name = "btnPosicion";
            btnPosicion.Size = new Size(139, 49);
            btnPosicion.TabIndex = 4;
            btnPosicion.Text = "Pulsa!";
            btnPosicion.UseVisualStyleBackColor = true;
            btnPosicion.Click += btnPosicion_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 214);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 5;
            label3.Text = "Rojo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 255);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 6;
            label4.Text = "Verde:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 297);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 7;
            label5.Text = "Azul:";
            // 
            // txtRojo
            // 
            txtRojo.Location = new Point(121, 213);
            txtRojo.Name = "txtRojo";
            txtRojo.Size = new Size(107, 23);
            txtRojo.TabIndex = 8;
            // 
            // txtVerde
            // 
            txtVerde.Location = new Point(121, 255);
            txtVerde.Name = "txtVerde";
            txtVerde.Size = new Size(108, 23);
            txtVerde.TabIndex = 9;
            // 
            // txtAzul
            // 
            txtAzul.Location = new Point(121, 291);
            txtAzul.Name = "txtAzul";
            txtAzul.Size = new Size(107, 23);
            txtAzul.TabIndex = 10;
            // 
            // btnBgColor
            // 
            btnBgColor.Location = new Point(76, 339);
            btnBgColor.Name = "btnBgColor";
            btnBgColor.Size = new Size(123, 60);
            btnBgColor.TabIndex = 11;
            btnBgColor.Text = "Cambia el color del fondo";
            btnBgColor.UseVisualStyleBackColor = true;
            btnBgColor.Click += btnBgColor_Click;
            // 
            // Form02PosicionColores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 429);
            Controls.Add(btnBgColor);
            Controls.Add(txtAzul);
            Controls.Add(txtVerde);
            Controls.Add(txtRojo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnPosicion);
            Controls.Add(txtPosicionY);
            Controls.Add(txtPosicionX);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form02PosicionColores";
            Text = "Form02PosicionColores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPosicionX;
        private TextBox txtPosicionY;
        private Button btnPosicion;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtRojo;
        private TextBox txtVerde;
        private TextBox txtAzul;
        private Button btnBgColor;
    }
}