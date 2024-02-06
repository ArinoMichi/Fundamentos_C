namespace Fundamentos
{
    partial class Form22Files
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
            txtContenidoFile = new TextBox();
            txtNombre = new TextBox();
            btnNuevoNombre = new Button();
            label1 = new Label();
            label2 = new Label();
            lstNombres = new ListBox();
            label3 = new Label();
            btnReadFile = new Button();
            btnWriteFile = new Button();
            SuspendLayout();
            // 
            // txtContenidoFile
            // 
            txtContenidoFile.Location = new Point(51, 64);
            txtContenidoFile.Margin = new Padding(3, 4, 3, 4);
            txtContenidoFile.Multiline = true;
            txtContenidoFile.Name = "txtContenidoFile";
            txtContenidoFile.Size = new Size(235, 293);
            txtContenidoFile.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(305, 92);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(169, 27);
            txtNombre.TabIndex = 1;
            // 
            // btnNuevoNombre
            // 
            btnNuevoNombre.Location = new Point(322, 145);
            btnNuevoNombre.Margin = new Padding(3, 4, 3, 4);
            btnNuevoNombre.Name = "btnNuevoNombre";
            btnNuevoNombre.Size = new Size(128, 42);
            btnNuevoNombre.TabIndex = 2;
            btnNuevoNombre.Text = "Nuevo Nombre";
            btnNuevoNombre.UseVisualStyleBackColor = true;
            btnNuevoNombre.Click += btnNuevoNombre_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 40);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 3;
            label1.Text = "Contenido File";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(496, 40);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Nombres";
            // 
            // lstNombres
            // 
            lstNombres.FormattingEnabled = true;
            lstNombres.ItemHeight = 20;
            lstNombres.Location = new Point(496, 64);
            lstNombres.Margin = new Padding(3, 4, 3, 4);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(209, 304);
            lstNombres.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(300, 44);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 6;
            label3.Text = "Nombre";
            // 
            // btnReadFile
            // 
            btnReadFile.Location = new Point(322, 203);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(128, 49);
            btnReadFile.TabIndex = 7;
            btnReadFile.Text = "Read File";
            btnReadFile.UseVisualStyleBackColor = true;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // btnWriteFile
            // 
            btnWriteFile.Location = new Point(318, 278);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(134, 43);
            btnWriteFile.TabIndex = 8;
            btnWriteFile.Text = "Write File";
            btnWriteFile.UseVisualStyleBackColor = true;
            btnWriteFile.Click += btnWriteFile_Click;
            // 
            // Form22Files
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 507);
            Controls.Add(btnWriteFile);
            Controls.Add(btnReadFile);
            Controls.Add(label3);
            Controls.Add(lstNombres);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnNuevoNombre);
            Controls.Add(txtNombre);
            Controls.Add(txtContenidoFile);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form22Files";
            Text = "Form22Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContenidoFile;
        private TextBox txtNombre;
        private Button btnNuevoNombre;
        private Label label1;
        private Label label2;
        private ListBox lstNombres;
        private Label label3;
        private Button btnReadFile;
        private Button btnWriteFile;
    }
}