namespace Hito3_GestionEstudiantes;
public partial class Form3 : Form
{
    private readonly GestorEstudiantes gestor = new();
    public Form3()
    {
        InitializeComponent();
        Refrescar();
    }
    private Estudiante Leer()
    {
        if (!int.TryParse(txtId.Text.Trim(), out int id))
            throw new ArgumentException("Ingresa un ID numérico.");
        return new Estudiante
        {
            Id = id, Nombre = txtNombre.Text.Trim(), Apellido = txtApellido.Text.Trim(),
            Correo = txtCorreo.Text.Trim(), Carrera = txtCarrera.Text.Trim()
        };
    }
    private void Ejecutar(Action accion)
    {
        try { accion(); Refrescar(); }
        catch (Exception ex) { GestorErrores.Mostrar(ex); }
    }
    private void Refrescar()
    {
        tabla.DataSource = null;
        string busqueda = txtBuscar.Text.Trim();
        var lista = gestor.Listar();
        if (!string.IsNullOrWhiteSpace(busqueda))
            lista = lista.Where(e => e.Id.ToString().Contains(busqueda, StringComparison.OrdinalIgnoreCase)
                || e.Nombre.Contains(busqueda, StringComparison.OrdinalIgnoreCase)
                || e.Apellido.Contains(busqueda, StringComparison.OrdinalIgnoreCase)
                || e.Correo.Contains(busqueda, StringComparison.OrdinalIgnoreCase)
                || e.Carrera.Contains(busqueda, StringComparison.OrdinalIgnoreCase)).ToList();
        tabla.DataSource = lista;
        tabla.ClearSelection();
    }
    private void Limpiar()
    {
        txtId.Clear(); txtNombre.Clear(); txtApellido.Clear(); txtCorreo.Clear(); txtCarrera.Clear();
        txtId.Focus();
    }
    private void btnAgregar_Click(object? sender, EventArgs e) =>
        Ejecutar(() => { Persona persona = Leer(); gestor.Agregar((Estudiante)persona); MessageBox.Show(persona.Descripcion() + " agregado correctamente."); Limpiar(); });
    private void btnEditar_Click(object? sender, EventArgs e) =>
        Ejecutar(() => { gestor.Actualizar(Leer()); MessageBox.Show("Estudiante actualizado."); Limpiar(); });
    private void btnEliminar_Click(object? sender, EventArgs e) => Ejecutar(() =>
    {
        if (!int.TryParse(txtId.Text.Trim(), out int id)) throw new ArgumentException("Ingresa un ID numérico.");
        if (MessageBox.Show("¿Eliminar este estudiante?", "Confirmar", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
        gestor.Eliminar(id); MessageBox.Show("Estudiante eliminado."); Limpiar();
    });
    private void txtBuscar_TextChanged(object? sender, EventArgs e) => Refrescar();
    private void btnLimpiarBusqueda_Click(object? sender, EventArgs e) => txtBuscar.Clear();
    private void btnLimpiar_Click(object? sender, EventArgs e) => Limpiar();
    private void tabla_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || tabla.Rows[e.RowIndex].DataBoundItem is not Estudiante est) return;
        txtId.Text = est.Id.ToString(); txtNombre.Text = est.Nombre;
        txtApellido.Text = est.Apellido; txtCorreo.Text = est.Correo; txtCarrera.Text = est.Carrera;
    }
}
