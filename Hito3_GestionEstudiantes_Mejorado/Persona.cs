namespace Hito3_GestionEstudiantes;
// Clase base para mostrar herencia y polimorfismo.
public abstract class Persona
{
    public string Nombre { get; set; } = "";
    public string Apellido { get; set; } = "";
    public virtual string Descripcion() => $"{Nombre} {Apellido}".Trim();
}
