namespace Hito3_GestionEstudiantes;
internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.ThreadException += (_, e) => GestorErrores.Mostrar(e.Exception);
        AppDomain.CurrentDomain.UnhandledException += (_, e) =>
            GestorErrores.Registrar(e.ExceptionObject as Exception ?? new Exception("Error desconocido"));
        Application.Run(new Form1());
    }
}
