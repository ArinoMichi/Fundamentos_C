namespace Fundamentos
{
    partial class Form04DateTime
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
            txtFechaActual = new TextBox();
            chkCambiarFormato = new CheckBox();
            rdbDias = new RadioButton();
            rdbMeses = new RadioButton();
            rdbAnios = new RadioButton();
            groupBox1 = new GroupBox();
            btnIncrementar = new Button();
            label2 = new Label();
            txtIncremento = new TextBox();
            lblFechaCambiada = new Label();
            txtNuevaFecha = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(58, 27);
            label1.Name = "label1";
            label1.Size = new Size(119, 28);
            label1.TabIndex = 0;
            label1.Text = "Fecha actual";
            // 
            // txtFechaActual
            // 
            txtFechaActual.Location = new Point(58, 58);
            txtFechaActual.Name = "txtFechaActual";
            txtFechaActual.Size = new Size(359, 23);
            txtFechaActual.TabIndex = 1;
            // 
            // chkCambiarFormato
            // 
            chkCambiarFormato.AutoSize = true;
            chkCambiarFormato.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            chkCambiarFormato.Location = new Point(58, 87);
            chkCambiarFormato.Name = "chkCambiarFormato";
            chkCambiarFormato.Size = new Size(239, 32);
            chkCambiarFormato.TabIndex = 2;
            chkCambiarFormato.Text = "Cambiar Formato Fecha";
            chkCambiarFormato.UseVisualStyleBackColor = true;
            chkCambiarFormato.CheckedChanged += chkCambiarFormato_CheckedChanged;
            // 
            // rdbDias
            // 
            rdbDias.AutoSize = true;
            rdbDias.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            rdbDias.Location = new Point(22, 33);
            rdbDias.Name = "rdbDias";
            rdbDias.Size = new Size(67, 32);
            rdbDias.TabIndex = 3;
            rdbDias.TabStop = true;
            rdbDias.Text = "Dias";
            rdbDias.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            rdbMeses.AutoSize = true;
            rdbMeses.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            rdbMeses.Location = new Point(22, 71);
            rdbMeses.Name = "rdbMeses";
            rdbMeses.Size = new Size(84, 32);
            rdbMeses.TabIndex = 4;
            rdbMeses.TabStop = true;
            rdbMeses.Text = "Meses";
            rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbAnios
            // 
            rdbAnios.AutoSize = true;
            rdbAnios.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            rdbAnios.Location = new Point(22, 109);
            rdbAnios.Name = "rdbAnios";
            rdbAnios.Size = new Size(74, 32);
            rdbAnios.TabIndex = 5;
            rdbAnios.TabStop = true;
            rdbAnios.Text = "Años";
            rdbAnios.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnIncrementar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtIncremento);
            groupBox1.Controls.Add(rdbAnios);
            groupBox1.Controls.Add(rdbMeses);
            groupBox1.Controls.Add(rdbDias);
            groupBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(55, 132);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(556, 162);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Incrementar Fecha";
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(310, 108);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(145, 35);
            btnIncrementar.TabIndex = 8;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 30);
            label2.Name = "label2";
            label2.Size = new Size(111, 28);
            label2.TabIndex = 7;
            label2.Text = "Incremento";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(310, 61);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(218, 34);
            txtIncremento.TabIndex = 6;
            // 
            // lblFechaCambiada
            // 
            lblFechaCambiada.AutoSize = true;
            lblFechaCambiada.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaCambiada.Location = new Point(58, 310);
            lblFechaCambiada.Name = "lblFechaCambiada";
            lblFechaCambiada.Size = new Size(123, 28);
            lblFechaCambiada.TabIndex = 7;
            lblFechaCambiada.Text = "Nueva Fecha";
            // 
            // txtNuevaFecha
            // 
            txtNuevaFecha.Location = new Point(58, 350);
            txtNuevaFecha.Name = "txtNuevaFecha";
            txtNuevaFecha.Size = new Size(359, 23);
            txtNuevaFecha.TabIndex = 9;
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNuevaFecha);
            Controls.Add(lblFechaCambiada);
            Controls.Add(groupBox1);
            Controls.Add(chkCambiarFormato);
            Controls.Add(txtFechaActual);
            Controls.Add(label1);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFechaActual;
        private CheckBox chkCambiarFormato;
        private RadioButton rdbDias;
        private RadioButton rdbMeses;
        private RadioButton rdbAnios;
        private GroupBox groupBox1;
        private Button btnIncrementar;
        private Label label2;
        private TextBox txtIncremento;
        private Label lblFechaCambiada;
        private TextBox txtNuevaFecha;
    }
}