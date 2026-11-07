namespace Hito3_GestionEstudiantes;
partial class Form3
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblTitulo = null!;
    private TextBox txtId = null!, txtNombre = null!, txtApellido = null!, txtCorreo = null!, txtCarrera = null!;
    private Button btnAgregar = null!, btnEditar = null!, btnEliminar = null!, btnLimpiar = null!;
    private DataGridView tabla = null!;
    private TextBox txtBuscar = null!;
    private Label lblBuscar = null!;
    private Button btnLimpiarBusqueda = null!;
    protected override void Dispose(bool disposing) { if (disposing) components?.Dispose(); base.Dispose(disposing); }
    private void InitializeComponent()
    {
        SuspendLayout();
        lblTitulo = new Label { Text = "GESTIÓN DE ESTUDIANTES", Font = new Font("Segoe UI", 17F, FontStyle.Bold),
            Location = new Point(30, 12), Size = new Size(840, 48), TextAlign = ContentAlignment.MiddleCenter };
        Controls.Add(lblTitulo);
        string[] nombres = { "ID:", "Nombre:", "Apellido:", "Correo:", "Carrera:" };
        TextBox[] cajas = { txtId = new TextBox(), txtNombre = new TextBox(), txtApellido = new TextBox(),
            txtCorreo = new TextBox(), txtCarrera = new TextBox() };
        for (int i = 0; i < nombres.Length; i++)
        {
            int x = i < 3 ? 35 : 465, y = i < 3 ? 78 + i * 48 : 78 + (i - 3) * 48;
            Controls.Add(new Label { Text = nombres[i], Location = new Point(x, y), Size = new Size(85, 25) });
            cajas[i].Location = new Point(x + 95, y - 2);
            cajas[i].Size = new Size(240, 27);
            Controls.Add(cajas[i]);
        }
        btnAgregar = new Button { Text = "Agregar" };
        btnEditar = new Button { Text = "Editar" };
        btnEliminar = new Button { Text = "Eliminar" };
        btnLimpiar = new Button { Text = "Limpiar" };
        Button[] botones = { btnAgregar, btnEditar, btnEliminar, btnLimpiar };
        for (int i = 0; i < botones.Length; i++)
        {
            botones[i].Location = new Point(100 + i * 190, 250);
            botones[i].Size = new Size(145, 35);
            Controls.Add(botones[i]);
        }
        btnAgregar.Click += btnAgregar_Click; btnEditar.Click += btnEditar_Click;
        btnEliminar.Click += btnEliminar_Click;
        btnLimpiar.Click += btnLimpiar_Click;
        lblBuscar = new Label { Text = "Buscar por ID, nombre, apellido, correo o carrera:",
            Location = new Point(35, 310), Size = new Size(420, 25) };
        txtBuscar = new TextBox { Location = new Point(35, 340), Size = new Size(660, 27) };
        btnLimpiarBusqueda = new Button { Text = "Mostrar todos", Location = new Point(710, 338), Size = new Size(155, 31) };
        txtBuscar.TextChanged += txtBuscar_TextChanged;
        btnLimpiarBusqueda.Click += btnLimpiarBusqueda_Click;
        Controls.AddRange(new Control[] { lblBuscar, txtBuscar, btnLimpiarBusqueda });
        tabla = new DataGridView { Location = new Point(35, 390), Size = new Size(830, 270),
            ReadOnly = true, AllowUserToAddRows = false, AllowUserToDeleteRows = false,
            MultiSelect = false, SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill };
        tabla.CellClick += tabla_CellClick;
        Controls.Add(tabla);
        ClientSize = new Size(900, 690); Font = new Font("Segoe UI", 10F);
        StartPosition = FormStartPosition.CenterScreen; Text = "Form3";
        FormBorderStyle = FormBorderStyle.FixedSingle; MaximizeBox = false;
        ResumeLayout(false);
    }
}
