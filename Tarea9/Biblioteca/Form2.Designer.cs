namespace Biblioteca;
partial class Form2
{
    private System.Windows.Forms.Label lblLibro;
    private System.Windows.Forms.TextBox txtLibro;
    private System.Windows.Forms.Label lblAutor;
    private System.Windows.Forms.TextBox txtAutor;
    private System.Windows.Forms.Label lblAnio;
    private System.Windows.Forms.TextBox txtAnio;
    private System.Windows.Forms.Button btnGuardar;
    private System.Windows.Forms.Button btnSiguiente;
    private void InitializeComponent()
    {
        lblLibro = new Label();
        txtLibro = new TextBox();
        lblAutor = new Label();
        txtAutor = new TextBox();
        lblAnio = new Label();
        txtAnio = new TextBox();
        btnGuardar = new Button();
        btnSiguiente = new Button();
        label1 = new Label();
        SuspendLayout();
        // 
        // lblLibro
        // 
        lblLibro.Location = new Point(25, 45);
        lblLibro.Name = "lblLibro";
        lblLibro.Size = new Size(125, 24);
        lblLibro.TabIndex = 0;
        lblLibro.Text = "Nombre Libro";
        // 
        // txtLibro
        // 
        txtLibro.Location = new Point(160, 43);
        txtLibro.Name = "txtLibro";
        txtLibro.Size = new Size(235, 23);
        txtLibro.TabIndex = 1;
        // 
        // lblAutor
        // 
        lblAutor.Location = new Point(25, 88);
        lblAutor.Name = "lblAutor";
        lblAutor.Size = new Size(125, 24);
        lblAutor.TabIndex = 2;
        lblAutor.Text = "Nombre autor";
        // 
        // txtAutor
        // 
        txtAutor.Location = new Point(160, 86);
        txtAutor.Name = "txtAutor";
        txtAutor.Size = new Size(235, 23);
        txtAutor.TabIndex = 3;
        // 
        // lblAnio
        // 
        lblAnio.Location = new Point(25, 131);
        lblAnio.Name = "lblAnio";
        lblAnio.Size = new Size(125, 24);
        lblAnio.TabIndex = 4;
        lblAnio.Text = "Año";
        // 
        // txtAnio
        // 
        txtAnio.Location = new Point(160, 129);
        txtAnio.Name = "txtAnio";
        txtAnio.Size = new Size(235, 23);
        txtAnio.TabIndex = 5;
        // 
        // btnGuardar
        // 
        btnGuardar.Location = new Point(160, 190);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(100, 32);
        btnGuardar.TabIndex = 6;
        btnGuardar.Text = "Guardar";
        btnGuardar.UseVisualStyleBackColor = true;
        btnGuardar.Click += btnGuardar_Click;
        // 
        // btnSiguiente
        // 
        btnSiguiente.Location = new Point(285, 190);
        btnSiguiente.Name = "btnSiguiente";
        btnSiguiente.Size = new Size(100, 32);
        btnSiguiente.TabIndex = 7;
        btnSiguiente.Text = "Sgte";
        btnSiguiente.UseVisualStyleBackColor = true;
        btnSiguiente.Click += btnSiguiente_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(171, 9);
        label1.Name = "label1";
        label1.Size = new Size(59, 15);
        label1.TabIndex = 8;
        label1.Text = "Biblioteca";
        // 
        // Form2
        // 
        ClientSize = new Size(435, 275);
        Controls.Add(label1);
        Controls.Add(lblLibro);
        Controls.Add(txtLibro);
        Controls.Add(lblAutor);
        Controls.Add(txtAutor);
        Controls.Add(lblAnio);
        Controls.Add(txtAnio);
        Controls.Add(btnGuardar);
        Controls.Add(btnSiguiente);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form2";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form2";
        FormClosed += Form2_FormClosed;
        ResumeLayout(false);
        PerformLayout();
    }

    private Label label1;
}
