namespace Biblioteca;
public partial class Form4 : Form
{
    public Form4() { InitializeComponent(); }
    private void btnMostrar_Click(object sender, EventArgs e)
    {
        txtReporte.Text = "Cantidad de libros: " + Datos.Libros.Count;
    }
    private void btnEliminar_Click(object sender, EventArgs e)
    {
        if (Datos.Libros.Count == 0)
        {
            MessageBox.Show("No hay libros para eliminar");
            return;
        }
        Libro eliminado = Datos.Libros.Dequeue();
        txtReporte.Text = "Se eliminó: " + eliminado.Nombre;
    }
    private void btnSalir_Click(object sender, EventArgs e) { Application.Exit(); }
    private void Form4_FormClosed(object sender, FormClosedEventArgs e) { Application.Exit(); }
}
