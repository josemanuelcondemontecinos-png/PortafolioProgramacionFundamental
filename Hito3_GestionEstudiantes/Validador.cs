using System.Net.Mail;
namespace Hito3_GestionEstudiantes;
public static class Validador
{
    public static void Validar(Estudiante e)
    {
        if (e.Id <= 0) throw new ArgumentException("El ID debe ser un número mayor que cero.");
        if (string.IsNullOrWhiteSpace(e.Nombre) || e.Nombre.Length > 60)
            throw new ArgumentException("El nombre es obligatorio y debe tener máximo 60 caracteres.");
        if (string.IsNullOrWhiteSpace(e.Apellido) || e.Apellido.Length > 60)
            throw new ArgumentException("El apellido es obligatorio y debe tener máximo 60 caracteres.");
        if (string.IsNullOrWhiteSpace(e.Carrera) || e.Carrera.Length > 80)
            throw new ArgumentException("La carrera es obligatoria y debe tener máximo 80 caracteres.");
        if (e.Correo.Length > 120 || !MailAddress.TryCreate(e.Correo, out var correo)
            || correo.Address != e.Correo || !e.Correo.Contains('.'))
            throw new ArgumentException("Ingresa un correo electrónico válido.");
    }
}
