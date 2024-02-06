namespace Fundamentos
{
    partial class Form11ColeccionMultiple
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
            btnBorrarTodo = new Button();
            btnEliminar = new Button();
            btnInsertar = new Button();
            txtNuevoElemento = new TextBox();
            label4 = new Label();
            lblIndiceSeleccionado = new Label();
            lblSeleccionado = new Label();
            label1 = new Label();
            lstElementos = new ListBox();
            btnSeleccionados = new Button();
            SuspendLayout();
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(278, 264);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(236, 44);
            btnBorrarTodo.TabIndex = 17;
            btnBorrarTodo.Text = "Borrar todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.ForeColor = Color.DarkRed;
            btnEliminar.Location = new Point(278, 164);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(236, 47);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(278, 116);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(236, 42);
            btnInsertar.TabIndex = 15;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtNuevoElemento
            // 
            txtNuevoElemento.AccessibleName = "txtNuevoElemento";
            txtNuevoElemento.Location = new Point(278, 52);
            txtNuevoElemento.Name = "txtNuevoElemento";
            txtNuevoElemento.Size = new Size(244, 23);
            txtNuevoElemento.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 28);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 13;
            label4.Text = "Nuevo Elemento";
            // 
            // lblIndiceSeleccionado
            // 
            lblIndiceSeleccionado.AutoSize = true;
            lblIndiceSeleccionado.Location = new Point(12, 347);
            lblIndiceSeleccionado.Name = "lblIndiceSeleccionado";
            lblIndiceSeleccionado.Size = new Size(122, 15);
            lblIndiceSeleccionado.TabIndex = 12;
            lblIndiceSeleccionado.Text = "lblIndiceSeleccionado";
            // 
            // lblSeleccionado
            // 
            lblSeleccionado.AutoSize = true;
            lblSeleccionado.Location = new Point(12, 312);
            lblSeleccionado.Name = "lblSeleccionado";
            lblSeleccionado.Size = new Size(90, 15);
            lblSeleccionado.TabIndex = 11;
            lblSeleccionado.Text = "lblSeleccionado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 10;
            label1.Text = "Elementos";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.ItemHeight = 15;
            lstElementos.Location = new Point(12, 52);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(206, 229);
            lstElementos.TabIndex = 9;
            // 
            // btnSeleccionados
            // 
            btnSeleccionados.Location = new Point(278, 217);
            btnSeleccionados.Name = "btnSeleccionados";
            btnSeleccionados.Size = new Size(236, 41);
            btnSeleccionados.TabIndex = 18;
            btnSeleccionados.Text = "Seleccionados";
            btnSeleccionados.UseVisualStyleBackColor = true;
            btnSeleccionados.Click += btnSeleccionados_Click;
            // 
            // Form11ColeccionMultiple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 419);
            Controls.Add(btnSeleccionados);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(txtNuevoElemento);
            Controls.Add(label4);
            Controls.Add(lblIndiceSeleccionado);
            Controls.Add(lblSeleccionado);
            Controls.Add(label1);
            Controls.Add(lstElementos);
            Name = "Form11ColeccionMultiple";
            Text = "Form11ColeccionMultiple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBorrarTodo;
        private Button btnEliminar;
        private Button btnInsertar;
        private TextBox txtNuevoElemento;
        private Label label4;
        private Label lblIndiceSeleccionado;
        private Label lblSeleccionado;
        private Label label1;
        private ListBox lstElementos;
        private Button btnSeleccionados;
    }
}