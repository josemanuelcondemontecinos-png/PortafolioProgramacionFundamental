namespace Hito3_GestionEstudiantes;
public static class GestorErrores
{
    public static void Registrar(Exception ex)
    {
        try
        {
            string carpeta = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "Hito3_GestionEstudiantes");
            Directory.CreateDirectory(carpeta);
            File.AppendAllText(Path.Combine(carpeta, "errores.log"),
                $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {ex.GetType().Name}: {ex.Message}{Environment.NewLine}");
        }
        catch { /* Evitar errores secundarios al registrar. */ }
    }
    public static void Mostrar(Exception ex)
    {
        Registrar(ex);
        MessageBox.Show(ex is ArgumentException ? ex.Message :
            "Ocurrió un error. Revisa los datos o el archivo de almacenamiento.",
            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
