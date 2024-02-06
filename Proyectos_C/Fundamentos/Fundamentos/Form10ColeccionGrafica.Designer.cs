namespace Fundamentos
{
    partial class Form10ColeccionGrafica
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
            lstElementos = new ListBox();
            label1 = new Label();
            lblSeleccionado = new Label();
            lblIndiceSeleccionado = new Label();
            label4 = new Label();
            txtNuevoElemento = new TextBox();
            btnInsertar = new Button();
            btnEliminar = new Button();
            btnBorrarTodo = new Button();
            SuspendLayout();
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.ItemHeight = 15;
            lstElementos.Location = new Point(47, 62);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(206, 229);
            lstElementos.TabIndex = 0;
            lstElementos.SelectedIndexChanged += lstElementos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 38);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "Elementos";
            // 
            // lblSeleccionado
            // 
            lblSeleccionado.AutoSize = true;
            lblSeleccionado.Location = new Point(47, 322);
            lblSeleccionado.Name = "lblSeleccionado";
            lblSeleccionado.Size = new Size(90, 15);
            lblSeleccionado.TabIndex = 2;
            lblSeleccionado.Text = "lblSeleccionado";
            // 
            // lblIndiceSeleccionado
            // 
            lblIndiceSeleccionado.AutoSize = true;
            lblIndiceSeleccionado.Location = new Point(47, 357);
            lblIndiceSeleccionado.Name = "lblIndiceSeleccionado";
            lblIndiceSeleccionado.Size = new Size(122, 15);
            lblIndiceSeleccionado.TabIndex = 3;
            lblIndiceSeleccionado.Text = "lblIndiceSeleccionado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(297, 35);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 4;
            label4.Text = "Nuevo Elemento";
            // 
            // txtNuevoElemento
            // 
            txtNuevoElemento.AccessibleName = "txtNuevoElemento";
            txtNuevoElemento.Location = new Point(296, 62);
            txtNuevoElemento.Name = "txtNuevoElemento";
            txtNuevoElemento.Size = new Size(267, 23);
            txtNuevoElemento.TabIndex = 5;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(313, 126);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(236, 42);
            btnInsertar.TabIndex = 6;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(313, 174);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(236, 47);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(313, 227);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(236, 44);
            btnBorrarTodo.TabIndex = 8;
            btnBorrarTodo.Text = "Borrar todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // Form10ColeccionGrafica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 399);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(txtNuevoElemento);
            Controls.Add(label4);
            Controls.Add(lblIndiceSeleccionado);
            Controls.Add(lblSeleccionado);
            Controls.Add(label1);
            Controls.Add(lstElementos);
            Name = "Form10ColeccionGrafica";
            Text = "Form10ColeccionGrafica";
            Load += Form10ColeccionGrafica_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstElementos;
        private Label label1;
        private Label lblSeleccionado;
        private Label lblIndiceSeleccionado;
        private Label label4;
        private TextBox txtNuevoElemento;
        private Button btnInsertar;
        private Button btnEliminar;
        private Button btnBorrarTodo;
    }
}