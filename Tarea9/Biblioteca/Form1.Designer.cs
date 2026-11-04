namespace Biblioteca;
partial class Form1
{
    private System.Windows.Forms.Label lblUsuario;
    private System.Windows.Forms.TextBox txtUsuario;
    private System.Windows.Forms.Label lblClave;
    private System.Windows.Forms.TextBox txtClave;
    private System.Windows.Forms.Button btnEntrar;
    private void InitializeComponent()
    {
        lblUsuario = new Label();
        txtUsuario = new TextBox();
        lblClave = new Label();
        txtClave = new TextBox();
        btnEntrar = new Button();
        label1 = new Label();
        SuspendLayout();
        // 
        // lblUsuario
        // 
        lblUsuario.Location = new Point(25, 75);
        lblUsuario.Name = "lblUsuario";
        lblUsuario.Size = new Size(105, 24);
        lblUsuario.TabIndex = 0;
        lblUsuario.Text = "Usuario";
        // 
        // txtUsuario
        // 
        txtUsuario.Location = new Point(145, 73);
        txtUsuario.Name = "txtUsuario";
        txtUsuario.Size = new Size(210, 23);
        txtUsuario.TabIndex = 1;
        // 
        // lblClave
        // 
        lblClave.Location = new Point(25, 119);
        lblClave.Name = "lblClave";
        lblClave.Size = new Size(105, 24);
        lblClave.TabIndex = 2;
        lblClave.Text = "Contraseña";
        // 
        // txtClave
        // 
        txtClave.Location = new Point(145, 117);
        txtClave.Name = "txtClave";
        txtClave.Size = new Size(210, 23);
        txtClave.TabIndex = 3;
        txtClave.UseSystemPasswordChar = true;
        // 
        // btnEntrar
        // 
        btnEntrar.Location = new Point(150, 175);
        btnEntrar.Name = "btnEntrar";
        btnEntrar.Size = new Size(95, 32);
        btnEntrar.TabIndex = 4;
        btnEntrar.Text = "Entrar";
        btnEntrar.UseVisualStyleBackColor = true;
        btnEntrar.Click += btnEntrar_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(100, 28);
        label1.Name = "label1";
        label1.Size = new Size(133, 15);
        label1.TabIndex = 5;
        label1.Text = "Bienvenido al programa";
        label1.Click += label1_Click;
        // 
        // Form1
        // 
        ClientSize = new Size(405, 255);
        Controls.Add(label1);
        Controls.Add(lblUsuario);
        Controls.Add(txtUsuario);
        Controls.Add(lblClave);
        Controls.Add(txtClave);
        Controls.Add(btnEntrar);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        FormClosed += Form1_FormClosed;
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private Label label1;
}
