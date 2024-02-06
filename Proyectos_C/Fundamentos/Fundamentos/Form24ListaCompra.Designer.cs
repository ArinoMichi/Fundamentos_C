namespace Fundamentos
{
    partial class Form24ListaCompra
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
            btnNuevoProducto = new Button();
            btnLeerFichero = new Button();
            btnEscribirFichero = new Button();
            label1 = new Label();
            label2 = new Label();
            lstListaCompra = new ListBox();
            label3 = new Label();
            txtNombre = new TextBox();
            txtCantidad = new TextBox();
            SuspendLayout();
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.Location = new Point(72, 227);
            btnNuevoProducto.Margin = new Padding(3, 4, 3, 4);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(154, 55);
            btnNuevoProducto.TabIndex = 0;
            btnNuevoProducto.Text = "Nuevo Producto";
            btnNuevoProducto.UseVisualStyleBackColor = true;
            btnNuevoProducto.Click += btnNuevoProducto_Click;
            // 
            // btnLeerFichero
            // 
            btnLeerFichero.Location = new Point(73, 307);
            btnLeerFichero.Margin = new Padding(3, 4, 3, 4);
            btnLeerFichero.Name = "btnLeerFichero";
            btnLeerFichero.Size = new Size(153, 57);
            btnLeerFichero.TabIndex = 1;
            btnLeerFichero.Text = "Leer Fichero";
            btnLeerFichero.UseVisualStyleBackColor = true;
            btnLeerFichero.Click += btnLeerFichero_Click;
            // 
            // btnEscribirFichero
            // 
            btnEscribirFichero.Location = new Point(75, 399);
            btnEscribirFichero.Margin = new Padding(3, 4, 3, 4);
            btnEscribirFichero.Name = "btnEscribirFichero";
            btnEscribirFichero.Size = new Size(151, 60);
            btnEscribirFichero.TabIndex = 2;
            btnEscribirFichero.Text = "Guardar Fichero";
            btnEscribirFichero.UseVisualStyleBackColor = true;
            btnEscribirFichero.Click += btnEscribirFichero_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 29);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 29);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 4;
            label2.Text = "Productos";
            // 
            // lstListaCompra
            // 
            lstListaCompra.FormattingEnabled = true;
            lstListaCompra.ItemHeight = 20;
            lstListaCompra.Location = new Point(321, 72);
            lstListaCompra.Name = "lstListaCompra";
            lstListaCompra.Size = new Size(266, 344);
            lstListaCompra.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 116);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 6;
            label3.Text = "Cantidad";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(69, 57);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(142, 27);
            txtNombre.TabIndex = 7;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(72, 148);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(148, 27);
            txtCantidad.TabIndex = 8;
            // 
            // Form24ListaCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 488);
            Controls.Add(txtCantidad);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(lstListaCompra);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEscribirFichero);
            Controls.Add(btnLeerFichero);
            Controls.Add(btnNuevoProducto);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form24ListaCompra";
            Text = "Form24ListaCompra";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevoProducto;
        private Button btnLeerFichero;
        private Button btnEscribirFichero;
        private Label label1;
        private Label label2;
        private ListBox lstListaCompra;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtCantidad;
    }
}