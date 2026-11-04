namespace Biblioteca;

public partial class Form1 : Form
{
    int intentos = 0;
    public Form1() { InitializeComponent(); }
    private void btnEntrar_Click(object sender, EventArgs e)
    {
        if (txtUsuario.Text.Trim() == "" || txtClave.Text == "")
        {
            MessageBox.Show("Completa usuario y contraseña");
            return;
        }
        if (txtUsuario.Text.Trim() == "jose" && txtClave.Text == "1234")
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
        else
        {
            intentos++;
            if (intentos >= 3)
            {
                MessageBox.Show("Demasiados intentos");
                Application.Exit();
            }
            else MessageBox.Show("Usuario o contraseña incorrectos");
        }
    }
    private void Form1_FormClosed(object sender, FormClosedEventArgs e) { Application.Exit(); }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }
}
