namespace Biblioteca;
partial class Form4
{
    private System.Windows.Forms.Label lblCantidad;
    private System.Windows.Forms.Button btnMostrar;
    private System.Windows.Forms.Label lblEliminar;
    private System.Windows.Forms.Button btnEliminar;
    private System.Windows.Forms.TextBox txtReporte;
    private System.Windows.Forms.Button btnSalir;
    private void InitializeComponent()
    {
        lblCantidad = new Label();
        btnMostrar = new Button();
        lblEliminar = new Label();
        btnEliminar = new Button();
        txtReporte = new TextBox();
        btnSalir = new Button();
        label1 = new Label();
        SuspendLayout();
        // 
        // lblCantidad
        // 
        lblCantidad.Location = new Point(25, 40);
        lblCantidad.Name = "lblCantidad";
        lblCantidad.Size = new Size(145, 24);
        lblCantidad.TabIndex = 0;
        lblCantidad.Text = "Cantidad Libros";
        // 
        // btnMostrar
        // 
        btnMostrar.Location = new Point(195, 40);
        btnMostrar.Name = "btnMostrar";
        btnMostrar.Size = new Size(110, 32);
        btnMostrar.TabIndex = 1;
        btnMostrar.Text = "Mostrar";
        btnMostrar.UseVisualStyleBackColor = true;
        btnMostrar.Click += btnMostrar_Click;
        // 
        // lblEliminar
        // 
        lblEliminar.Location = new Point(25, 91);
        lblEliminar.Name = "lblEliminar";
        lblEliminar.Size = new Size(155, 24);
        lblEliminar.TabIndex = 2;
        lblEliminar.Text = "Eliminar primer libro";
        // 
        // btnEliminar
        // 
        btnEliminar.Location = new Point(195, 83);
        btnEliminar.Name = "btnEliminar";
        btnEliminar.Size = new Size(110, 32);
        btnEliminar.TabIndex = 3;
        btnEliminar.Text = "Eliminar";
        btnEliminar.UseVisualStyleBackColor = true;
        btnEliminar.Click += btnEliminar_Click;
        // 
        // txtReporte
        // 
        txtReporte.Location = new Point(25, 135);
        txtReporte.Multiline = true;
        txtReporte.Name = "txtReporte";
        txtReporte.ReadOnly = true;
        txtReporte.ScrollBars = ScrollBars.Vertical;
        txtReporte.Size = new Size(390, 160);
        txtReporte.TabIndex = 4;
        // 
        // btnSalir
        // 
        btnSalir.Location = new Point(320, 310);
        btnSalir.Name = "btnSalir";
        btnSalir.Size = new Size(95, 32);
        btnSalir.TabIndex = 5;
        btnSalir.Text = "Salir";
        btnSalir.UseVisualStyleBackColor = true;
        btnSalir.Click += btnSalir_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(165, 9);
        label1.Name = "label1";
        label1.Size = new Size(53, 15);
        label1.TabIndex = 6;
        label1.Text = "Reportes";
        // 
        // Form4
        // 
        ClientSize = new Size(460, 395);
        Controls.Add(label1);
        Controls.Add(lblCantidad);
        Controls.Add(btnMostrar);
        Controls.Add(lblEliminar);
        Controls.Add(btnEliminar);
        Controls.Add(txtReporte);
        Controls.Add(btnSalir);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form4";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form4";
        FormClosed += Form4_FormClosed;
        ResumeLayout(false);
        PerformLayout();
    }

    private Label label1;
}
