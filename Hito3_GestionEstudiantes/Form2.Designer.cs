namespace Hito3_GestionEstudiantes;
partial class Form2
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblTitulo = null!, lblDescripcion = null!;
    private Button btnEstudiantes = null!, btnSalir = null!;
    protected override void Dispose(bool disposing) { if (disposing) components?.Dispose(); base.Dispose(disposing); }
    private void InitializeComponent()
    {
        lblTitulo = new Label(); lblDescripcion = new Label();
        btnEstudiantes = new Button(); btnSalir = new Button();
        SuspendLayout();
        lblTitulo.Text = "MENÚ PRINCIPAL"; lblTitulo.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
        lblTitulo.Location = new Point(65, 22); lblTitulo.Size = new Size(350, 45); lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
        lblDescripcion.Text = "Sistema de gestión académica"; lblDescripcion.Location = new Point(65, 78);
        lblDescripcion.Size = new Size(350, 30); lblDescripcion.TextAlign = ContentAlignment.MiddleCenter;
        btnEstudiantes.Text = "Gestionar estudiantes"; btnEstudiantes.Location = new Point(130, 140);
        btnEstudiantes.Size = new Size(220, 45); btnEstudiantes.Click += btnEstudiantes_Click;
        btnSalir.Text = "Cerrar sesión"; btnSalir.Location = new Point(130, 210);
        btnSalir.Size = new Size(220, 45); btnSalir.Click += btnSalir_Click;
        ClientSize = new Size(480, 320);
        Controls.AddRange(new Control[] { lblTitulo, lblDescripcion, btnEstudiantes, btnSalir });
        Font = new Font("Segoe UI", 10F); StartPosition = FormStartPosition.CenterScreen;
        Text = "Form2"; FormBorderStyle = FormBorderStyle.FixedSingle; MaximizeBox = false;
        ResumeLayout(false);
    }
}
