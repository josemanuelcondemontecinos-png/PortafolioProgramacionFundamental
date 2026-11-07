namespace Hito3_GestionEstudiantes;
public class GestorEstudiantes
{
    private readonly Dictionary<int, Estudiante> registros = new();
    private readonly ArchivoDatos archivo = new();

    public GestorEstudiantes()
    {
        foreach (var e in archivo.Cargar())
        {
            Validador.Validar(e);
            if (!registros.TryAdd(e.Id, e))
                throw new InvalidDataException("Hay IDs duplicados en el archivo.");
        }
    }
    public List<Estudiante> Listar() => registros.Values.OrderBy(e => e.Id).ToList();
    public Estudiante? Buscar(int id) => registros.GetValueOrDefault(id);

    public void Agregar(Estudiante e)
    {
        Validador.Validar(e);
        if (registros.ContainsKey(e.Id)) throw new ArgumentException("Ese ID ya existe.");
        if (registros.Values.Any(x => x.Correo.Equals(e.Correo, StringComparison.OrdinalIgnoreCase)))
            throw new ArgumentException("Ese correo ya está registrado.");
        registros.Add(e.Id, e);
        try { archivo.Guardar(Listar()); }
        catch { registros.Remove(e.Id); throw; }
    }
    public void Actualizar(Estudiante e)
    {
        Validador.Validar(e);
        if (!registros.TryGetValue(e.Id, out var anterior)) throw new ArgumentException("No existe ese ID.");
        if (registros.Values.Any(x => x.Id != e.Id &&
            x.Correo.Equals(e.Correo, StringComparison.OrdinalIgnoreCase)))
            throw new ArgumentException("Ese correo ya está registrado.");
        registros[e.Id] = e;
        try { archivo.Guardar(Listar()); }
        catch { registros[e.Id] = anterior; throw; }
    }
    public void Eliminar(int id)
    {
        if (!registros.Remove(id, out var anterior)) throw new ArgumentException("No existe ese ID.");
        try { archivo.Guardar(Listar()); }
        catch { registros[id] = anterior; throw; }
    }
}
