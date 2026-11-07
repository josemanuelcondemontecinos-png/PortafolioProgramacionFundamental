namespace Hito3_GestionEstudiantes;
public partial class Form2 : Form
{
    public Form2() { InitializeComponent(); }
    private void btnEstudiantes_Click(object? sender, EventArgs e)
    {
        try
        {
            using var pantalla = new Form3();
            Hide();
            try { pantalla.ShowDialog(); }
            finally { Show(); }
        }
        catch (Exception ex) { GestorErrores.Mostrar(ex); }
    }
    private void btnSalir_Click(object? sender, EventArgs e) => Close();
}
