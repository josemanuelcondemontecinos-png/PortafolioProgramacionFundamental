namespace Hito3_GestionEstudiantes;
public partial class Form1 : Form
{
    // Usuario de demostración. Para producción usar usuarios persistentes y contraseñas configurables.
    private readonly Usuario usuario = new("admin", "Admin123!");
    private int intentos;
    public Form1() { InitializeComponent(); }
    private void btnIngresar_Click(object? sender, EventArgs e)
    {
        if (intentos >= 5) { MessageBox.Show("Demasiados intentos. Reinicia la aplicación."); return; }
        if (txtUsuario.Text.Trim() == usuario.Nombre && usuario.Verificar(txtClave.Text))
        {
            intentos = 0;
            txtClave.Clear();
            Hide();
            using (var menu = new Form2()) menu.ShowDialog();
            Show();
        }
        else
        {
            intentos++;
            MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso denegado");
            txtClave.Clear();
        }
    }
}
