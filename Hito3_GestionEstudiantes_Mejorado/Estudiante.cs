namespace Hito3_GestionEstudiantes;
public class Estudiante : Persona
{
    public int Id { get; set; }
    public override string Descripcion() => $"Estudiante: {base.Descripcion()} (ID: {Id})";
    public string Correo { get; set; } = "";
    public string Carrera { get; set; } = "";
}
