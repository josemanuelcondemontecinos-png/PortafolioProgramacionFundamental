using System.Text.Json;
namespace Hito3_GestionEstudiantes;
public class ArchivoDatos
{
    private readonly string carpeta = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
        "Hito3_GestionEstudiantes");
    private string Ruta => Path.Combine(carpeta, "estudiantes.json");

    public List<Estudiante> Cargar()
    {
        if (!File.Exists(Ruta)) return new List<Estudiante>();
        string json = File.ReadAllText(Ruta);
        return JsonSerializer.Deserialize<List<Estudiante>>(json)
            ?? throw new InvalidDataException("El archivo de estudiantes está vacío o dañado.");
    }
    public void Guardar(IEnumerable<Estudiante> estudiantes)
    {
        Directory.CreateDirectory(carpeta);
        string temporal = Ruta + ".tmp";
        string json = JsonSerializer.Serialize(estudiantes, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(temporal, json);
        File.Move(temporal, Ruta, true);
    }
}
