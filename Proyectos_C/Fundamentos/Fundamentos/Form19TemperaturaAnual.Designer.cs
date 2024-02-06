namespace Fundamentos
{
    partial class Form19TemperaturaAnual
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
            btnGenerarTemperaturas = new Button();
            btnMostrarDatos = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMaxima = new TextBox();
            txtMinima = new TextBox();
            txtMedia = new TextBox();
            label4 = new Label();
            lstTemperaturas = new ListBox();
            SuspendLayout();
            // 
            // btnGenerarTemperaturas
            // 
            btnGenerarTemperaturas.Location = new Point(436, 46);
            btnGenerarTemperaturas.Margin = new Padding(4);
            btnGenerarTemperaturas.Name = "btnGenerarTemperaturas";
            btnGenerarTemperaturas.Size = new Size(193, 64);
            btnGenerarTemperaturas.TabIndex = 0;
            btnGenerarTemperaturas.Text = "Generar Temperaturas";
            btnGenerarTemperaturas.UseVisualStyleBackColor = true;
            btnGenerarTemperaturas.Click += btnGenerarMeses_Click;
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(436, 137);
            btnMostrarDatos.Margin = new Padding(4);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(193, 59);
            btnMostrarDatos.TabIndex = 1;
            btnMostrarDatos.Text = "Mostrar Datos";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(439, 213);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 2;
            label1.Text = "Temperatura Maxima";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(439, 300);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 20);
            label2.TabIndex = 3;
            label2.Text = "Temperatura Minima";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(439, 393);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 4;
            label3.Text = "Media Anual";
            // 
            // txtMaxima
            // 
            txtMaxima.Location = new Point(441, 249);
            txtMaxima.Margin = new Padding(4);
            txtMaxima.Name = "txtMaxima";
            txtMaxima.Size = new Size(134, 27);
            txtMaxima.TabIndex = 5;
            // 
            // txtMinima
            // 
            txtMinima.Location = new Point(442, 342);
            txtMinima.Margin = new Padding(4);
            txtMinima.Name = "txtMinima";
            txtMinima.Size = new Size(133, 27);
            txtMinima.TabIndex = 6;
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(442, 434);
            txtMedia.Margin = new Padding(4);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(133, 27);
            txtMedia.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 55);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 8;
            label4.Text = "Temperaturas";
            // 
            // lstTemperaturas
            // 
            lstTemperaturas.FormattingEnabled = true;
            lstTemperaturas.ItemHeight = 20;
            lstTemperaturas.Location = new Point(37, 90);
            lstTemperaturas.Name = "lstTemperaturas";
            lstTemperaturas.Size = new Size(236, 364);
            lstTemperaturas.TabIndex = 9;
            // 
            // Form19TemperaturaAnual
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lstTemperaturas);
            Controls.Add(label4);
            Controls.Add(txtMedia);
            Controls.Add(txtMinima);
            Controls.Add(txtMaxima);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMostrarDatos);
            Controls.Add(btnGenerarTemperaturas);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form19TemperaturaAnual";
            Text = "Form19TemperaturaAnual";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerarTemperaturas;
        private Button btnMostrarDatos;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMaxima;
        private TextBox txtMinima;
        private TextBox txtMedia;
        private Label label4;
        private ListBox lstTemperaturas;
    }
}