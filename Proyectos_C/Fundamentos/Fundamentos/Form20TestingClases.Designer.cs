namespace Fundamentos
{
    partial class Form20TestingClases
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
            lstDatosClases = new ListBox();
            btnCrearPersona = new Button();
            btnCrearEmpleado = new Button();
            btnCrearDirector = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 21);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 0;
            label1.Text = "Datos de clases";
            // 
            // lstDatosClases
            // 
            lstDatosClases.FormattingEnabled = true;
            lstDatosClases.ItemHeight = 21;
            lstDatosClases.Location = new Point(28, 54);
            lstDatosClases.Name = "lstDatosClases";
            lstDatosClases.Size = new Size(427, 277);
            lstDatosClases.TabIndex = 1;
            // 
            // btnCrearPersona
            // 
            btnCrearPersona.Location = new Point(484, 54);
            btnCrearPersona.Name = "btnCrearPersona";
            btnCrearPersona.Size = new Size(150, 43);
            btnCrearPersona.TabIndex = 2;
            btnCrearPersona.Text = "Crear Persona";
            btnCrearPersona.UseVisualStyleBackColor = true;
            btnCrearPersona.Click += btnCrearPersona_Click;
            // 
            // btnCrearEmpleado
            // 
            btnCrearEmpleado.Location = new Point(483, 122);
            btnCrearEmpleado.Name = "btnCrearEmpleado";
            btnCrearEmpleado.Size = new Size(145, 50);
            btnCrearEmpleado.TabIndex = 3;
            btnCrearEmpleado.Text = "Crear Empleado";
            btnCrearEmpleado.UseVisualStyleBackColor = true;
            btnCrearEmpleado.Click += btnCrearEmpleado_Click;
            // 
            // btnCrearDirector
            // 
            btnCrearDirector.Location = new Point(483, 190);
            btnCrearDirector.Name = "btnCrearDirector";
            btnCrearDirector.Size = new Size(153, 47);
            btnCrearDirector.TabIndex = 4;
            btnCrearDirector.Text = "Crear Director";
            btnCrearDirector.UseVisualStyleBackColor = true;
            btnCrearDirector.Click += btnCrearDirector_Click;
            // 
            // Form20TestingClases
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 411);
            Controls.Add(btnCrearDirector);
            Controls.Add(btnCrearEmpleado);
            Controls.Add(btnCrearPersona);
            Controls.Add(lstDatosClases);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form20TestingClases";
            Text = "Form20TestingClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstDatosClases;
        private Button btnCrearPersona;
        private Button btnCrearEmpleado;
        private Button btnCrearDirector;
    }
}