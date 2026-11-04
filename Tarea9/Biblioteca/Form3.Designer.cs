namespace Biblioteca;
partial class Form3
{
    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.Button btnSiguiente;
    private void InitializeComponent()
    {
        listView1 = new ListView();
        btnSiguiente = new Button();
        label1 = new Label();
        columnHeader1 = new ColumnHeader();
        columnHeader2 = new ColumnHeader();
        columnHeader3 = new ColumnHeader();
        SuspendLayout();
        // 
        // listView1
        // 
        listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
        listView1.FullRowSelect = true;
        listView1.GridLines = true;
        listView1.Location = new Point(20, 42);
        listView1.Name = "listView1";
        listView1.Size = new Size(490, 240);
        listView1.TabIndex = 0;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.View = View.Details;
        // 
        // btnSiguiente
        // 
        btnSiguiente.Location = new Point(415, 302);
        btnSiguiente.Name = "btnSiguiente";
        btnSiguiente.Size = new Size(95, 32);
        btnSiguiente.TabIndex = 1;
        btnSiguiente.Text = "Sgte";
        btnSiguiente.UseVisualStyleBackColor = true;
        btnSiguiente.Click += btnSiguiente_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(218, 9);
        label1.Name = "label1";
        label1.Size = new Size(79, 15);
        label1.TabIndex = 2;
        label1.Text = "Lista de libros";
        // 
        // columnHeader1
        // 
        columnHeader1.Text = "Nombre";
        columnHeader1.Width = 170;
        // 
        // columnHeader2
        // 
        columnHeader2.Text = "Autor";
        columnHeader2.Width = 170;
        // 
        // columnHeader3
        // 
        columnHeader3.Text = "Año";
        columnHeader3.Width = 100;
        // 
        // Form3
        // 
        ClientSize = new Size(540, 385);
        Controls.Add(label1);
        Controls.Add(listView1);
        Controls.Add(btnSiguiente);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form3";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form3";
        FormClosed += Form3_FormClosed;
        Load += Form3_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private Label label1;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
}
