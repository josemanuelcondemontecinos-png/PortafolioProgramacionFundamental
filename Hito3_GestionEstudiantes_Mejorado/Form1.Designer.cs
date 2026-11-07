namespace Hito3_GestionEstudiantes;
partial class Form1
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblTitulo = null!, lblUsuario = null!, lblClave = null!, lblAyuda = null!;
    private TextBox txtUsuario = null!, txtClave = null!;
    private Button btnIngresar = null!;
    protected override void Dispose(bool disposing) { if (disposing) components?.Dispose(); base.Dispose(disposing); }
    private void InitializeComponent()
    {
        lblTitulo = new Label(); lblUsuario = new Label(); lblClave = new Label(); lblAyuda = new Label();
        txtUsuario = new TextBox(); txtClave = new TextBox(); btnIngresar = new Button();
        SuspendLayout();
        lblTitulo.Text = "INICIO DE SESIÓN"; lblTitulo.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
        lblTitulo.Location = new Point(75, 20); lblTitulo.Size = new Size(310, 45); lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
        lblUsuario.Text = "Usuario:"; lblUsuario.Location = new Point(80, 94); lblUsuario.AutoSize = true;
        txtUsuario.Location = new Point(80, 117); txtUsuario.Size = new Size(300, 27);
        lblClave.Text = "Contraseña:"; lblClave.Location = new Point(80, 160); lblClave.AutoSize = true;
        txtClave.Location = new Point(80, 183); txtClave.Size = new Size(300, 27); txtClave.UseSystemPasswordChar = true;
        btnIngresar.Text = "Ingresar"; btnIngresar.Location = new Point(160, 232); btnIngresar.Size = new Size(140, 35);
        btnIngresar.Click += btnIngresar_Click;
        lblAyuda.Text = "Acceso exclusivo para usuarios autorizados"; lblAyuda.Location = new Point(80, 285);
        lblAyuda.Size = new Size(300, 24); lblAyuda.TextAlign = ContentAlignment.MiddleCenter;
        AcceptButton = btnIngresar; ClientSize = new Size(460, 340);
        Controls.AddRange(new Control[] { lblTitulo, lblUsuario, txtUsuario, lblClave, txtClave, btnIngresar, lblAyuda });
        Font = new Font("Segoe UI", 10F); StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1"; FormBorderStyle = FormBorderStyle.FixedSingle; MaximizeBox = false;
        ResumeLayout(false); PerformLayout();
    }
}
