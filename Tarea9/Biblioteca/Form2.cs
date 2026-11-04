namespace Biblioteca;
public partial class Form2 : Form
{
    public Form2() { InitializeComponent(); }
    private void btnGuardar_Click(object sender, EventArgs e)
    {
        string nombre = txtLibro.Text.Trim();
        string autor = txtAutor.Text.Trim();
        string anioTexto = txtAnio.Text.Trim();
        if (nombre == "" || autor == "" || anioTexto == "")
        {
            MessageBox.Show("Completa todos los campos");
            return;
        }
        foreach (char letra in autor)
        {
            if (!char.IsLetter(letra) && letra != ' ')
            {
                MessageBox.Show("El autor solo puede tener letras");
                return;
            }
        }
        int anio;
        if (!int.TryParse(anioTexto, out anio))
        {
            MessageBox.Show("El año debe ser un número");
            return;
        }
        if (anio < 1450 || anio > DateTime.Now.Year)
        {
            MessageBox.Show("El año debe estar entre 1450 y " + DateTime.Now.Year);
            return;
        }
        foreach (Libro libro in Datos.Libros)
        {
            if (libro.Nombre.ToLower() == nombre.ToLower())
            {
                MessageBox.Show("Ese libro ya está registrado");
                return;
            }
        }
        Libro nuevo = new Libro();
        nuevo.Nombre = nombre;
        nuevo.Autor = autor;
        nuevo.Anio = anio;
        Datos.Libros.Enqueue(nuevo);
        MessageBox.Show("Libro guardado. Total: " + Datos.Libros.Count);
        txtLibro.Clear();
        txtAutor.Clear();
        txtAnio.Clear();
        txtLibro.Focus();
    }
    private void btnSiguiente_Click(object sender, EventArgs e)
    {
        if (Datos.Libros.Count == 0)
        {
            MessageBox.Show("Registra al menos un libro");
            return;
        }
        Form3 form3 = new Form3();
        form3.Show();
        this.Hide();
    }
    private void Form2_FormClosed(object sender, FormClosedEventArgs e) { Application.Exit(); }
}
