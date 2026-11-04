namespace Biblioteca;
public partial class Form3 : Form
{
    public Form3() { InitializeComponent(); }
    private void Form3_Load(object sender, EventArgs e)
    {
        listView1.Items.Clear();
        foreach (Libro libro in Datos.Libros)
        {
            ListViewItem fila = new ListViewItem(libro.Nombre);
            fila.SubItems.Add(libro.Autor);
            fila.SubItems.Add(libro.Anio.ToString());
            listView1.Items.Add(fila);
        }
    }
    private void btnSiguiente_Click(object sender, EventArgs e)
    {
        Form4 form4 = new Form4();
        form4.Show();
        this.Hide();
    }
    private void Form3_FormClosed(object sender, FormClosedEventArgs e) { Application.Exit(); }
}
