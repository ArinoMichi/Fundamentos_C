namespace Fundamentos
{
    partial class Form13TiendaProductos
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
            btnInsertar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnBorrarTodos = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lstTienda = new ListBox();
            lstProductos = new ListBox();
            btnSeleccion = new Button();
            btnTodos = new Button();
            btnSubir = new Button();
            btnBajar = new Button();
            txtProducto = new TextBox();
            SuspendLayout();
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(30, 102);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(135, 33);
            btnInsertar.TabIndex = 0;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(30, 152);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(135, 32);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(30, 201);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(135, 30);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrarTodos
            // 
            btnBorrarTodos.Location = new Point(33, 247);
            btnBorrarTodos.Name = "btnBorrarTodos";
            btnBorrarTodos.Size = new Size(132, 30);
            btnBorrarTodos.TabIndex = 3;
            btnBorrarTodos.Text = "Borrar Todos";
            btnBorrarTodos.UseVisualStyleBackColor = true;
            btnBorrarTodos.Click += btnBorrarTodos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 36);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 4;
            label1.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 36);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 5;
            label2.Text = "Tienda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(488, 35);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 6;
            label3.Text = "Productos";
            // 
            // lstTienda
            // 
            lstTienda.FormattingEnabled = true;
            lstTienda.ItemHeight = 15;
            lstTienda.Location = new Point(230, 54);
            lstTienda.Name = "lstTienda";
            lstTienda.Size = new Size(158, 274);
            lstTienda.TabIndex = 7;
            // 
            // lstProductos
            // 
            lstProductos.FormattingEnabled = true;
            lstProductos.ItemHeight = 15;
            lstProductos.Location = new Point(488, 53);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(177, 274);
            lstProductos.TabIndex = 8;
            lstProductos.SelectedIndexChanged += lstProductos_SelectedIndexChanged;
            // 
            // btnSeleccion
            // 
            btnSeleccion.Location = new Point(401, 121);
            btnSeleccion.Name = "btnSeleccion";
            btnSeleccion.Size = new Size(81, 35);
            btnSeleccion.TabIndex = 9;
            btnSeleccion.Text = "Seleccion";
            btnSeleccion.UseVisualStyleBackColor = true;
            btnSeleccion.Click += btnSeleccion_Click;
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(401, 162);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(81, 39);
            btnTodos.TabIndex = 10;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // btnSubir
            // 
            btnSubir.Location = new Point(695, 102);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(89, 44);
            btnSubir.TabIndex = 11;
            btnSubir.Text = "Subir";
            btnSubir.UseVisualStyleBackColor = true;
            btnSubir.Click += btnSubir_Click;
            // 
            // btnBajar
            // 
            btnBajar.Location = new Point(695, 161);
            btnBajar.Name = "btnBajar";
            btnBajar.Size = new Size(89, 40);
            btnBajar.TabIndex = 12;
            btnBajar.Text = "Bajar";
            btnBajar.UseVisualStyleBackColor = true;
            btnBajar.Click += btnBajar_Click;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(30, 62);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(135, 23);
            txtProducto.TabIndex = 13;
            // 
            // Form13TiendaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtProducto);
            Controls.Add(btnBajar);
            Controls.Add(btnSubir);
            Controls.Add(btnTodos);
            Controls.Add(btnSeleccion);
            Controls.Add(lstProductos);
            Controls.Add(lstTienda);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBorrarTodos);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Name = "Form13TiendaProductos";
            Text = "Form13TiendaProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsertar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnBorrarTodos;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox lstTienda;
        private ListBox lstProductos;
        private Button btnSeleccion;
        private Button btnTodos;
        private Button btnSubir;
        private Button btnBajar;
        private TextBox txtProducto;
    }
}