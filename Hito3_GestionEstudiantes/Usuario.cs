using System.Security.Cryptography;
namespace Hito3_GestionEstudiantes;
public class Usuario
{
    public string Nombre { get; }
    private readonly byte[] sal;
    private readonly byte[] hash;
    public Usuario(string nombre, string clave)
    {
        Nombre = nombre;
        sal = RandomNumberGenerator.GetBytes(16);
        hash = Rfc2898DeriveBytes.Pbkdf2(clave, sal, 120000, HashAlgorithmName.SHA256, 32);
    }
    public bool Verificar(string clave)
    {
        byte[] intento = Rfc2898DeriveBytes.Pbkdf2(clave, sal, 120000, HashAlgorithmName.SHA256, 32);
        return CryptographicOperations.FixedTimeEquals(hash, intento);
    }
}
