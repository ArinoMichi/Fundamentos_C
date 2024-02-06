namespace Fundamentos
{
    partial class Form21TemperaturasClases
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
            txtTemperaturaMaxima = new TextBox();
            txtTemperaturaMinima = new TextBox();
            txtMedia = new TextBox();
            label4 = new Label();
            lstTemperaturas = new ListBox();
            SuspendLayout();
            // 
            // btnGenerarTemperaturas
            // 
            btnGenerarTemperaturas.Location = new Point(371, 6);
            btnGenerarTemperaturas.Margin = new Padding(3, 4, 3, 4);
            btnGenerarTemperaturas.Name = "btnGenerarTemperaturas";
            btnGenerarTemperaturas.Size = new Size(182, 49);
            btnGenerarTemperaturas.TabIndex = 0;
            btnGenerarTemperaturas.Text = "Generar Temperaturas";
            btnGenerarTemperaturas.UseVisualStyleBackColor = true;
            btnGenerarTemperaturas.Click += btnGenerarTemperaturas_Click;
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(371, 74);
            btnMostrarDatos.Margin = new Padding(3, 4, 3, 4);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(182, 49);
            btnMostrarDatos.TabIndex = 1;
            btnMostrarDatos.Text = "Mostrar Datos";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(371, 143);
            label1.Name = "label1";
            label1.Size = new Size(181, 20);
            label1.TabIndex = 2;
            label1.Text = "Temperatura Maxima Mes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(371, 216);
            label2.Name = "label2";
            label2.Size = new Size(178, 20);
            label2.TabIndex = 3;
            label2.Text = "Temperatura Minima Mes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(371, 285);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 4;
            label3.Text = "Media Mensual";
            // 
            // txtTemperaturaMaxima
            // 
            txtTemperaturaMaxima.Location = new Point(378, 173);
            txtTemperaturaMaxima.Name = "txtTemperaturaMaxima";
            txtTemperaturaMaxima.Size = new Size(173, 27);
            txtTemperaturaMaxima.TabIndex = 5;
            // 
            // txtTemperaturaMinima
            // 
            txtTemperaturaMinima.Location = new Point(377, 245);
            txtTemperaturaMinima.Name = "txtTemperaturaMinima";
            txtTemperaturaMinima.Size = new Size(174, 27);
            txtTemperaturaMinima.TabIndex = 6;
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(378, 324);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(177, 27);
            txtMedia.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 20);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 8;
            label4.Text = "Temperaturas";
            // 
            // lstTemperaturas
            // 
            lstTemperaturas.FormattingEnabled = true;
            lstTemperaturas.ItemHeight = 20;
            lstTemperaturas.Location = new Point(32, 52);
            lstTemperaturas.Name = "lstTemperaturas";
            lstTemperaturas.Size = new Size(288, 304);
            lstTemperaturas.TabIndex = 9;
            // 
            // Form21TemperaturasClases
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 382);
            Controls.Add(lstTemperaturas);
            Controls.Add(label4);
            Controls.Add(txtMedia);
            Controls.Add(txtTemperaturaMinima);
            Controls.Add(txtTemperaturaMaxima);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMostrarDatos);
            Controls.Add(btnGenerarTemperaturas);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form21TemperaturasClases";
            Text = "Form21TemperaturasClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerarTemperaturas;
        private Button btnMostrarDatos;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTemperaturaMaxima;
        private TextBox txtTemperaturaMinima;
        private TextBox txtMedia;
        private Label label4;
        private ListBox lstTemperaturas;
    }
}