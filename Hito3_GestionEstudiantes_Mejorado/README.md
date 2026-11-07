# Evaluación Procesual Hito 3 — Gestión de Estudiantes

Proyecto académico C# Windows Forms (.NET 8), con tres formularios **Form1, Form2 y Form3**.

## Abrir
1. Instalar Visual Studio 2022 con desarrollo de escritorio .NET y SDK .NET 8.
2. Abrir `Hito3_GestionEstudiantes.csproj`.
3. Ejecutar con F5 (en Windows).

## Acceso de demostración
Usuario: `admin` — Clave: `Admin123!`.

**Solo para evaluación:** la cuenta demo se crea en memoria al iniciar. En producción se necesita registro de usuarios, credenciales configurables y protección de intentos entre sesiones.

## Funciones
- Form1: acceso con contraseña verificada mediante PBKDF2 y límite de intentos por sesión.
- Form2: menú y cierre de sesión.
- Form3: agregar, buscar, editar, eliminar y consultar estudiantes. Buscador independiente en tiempo real por ID, nombre, apellido, correo o carrera.
- Diccionario `Dictionary<int, Estudiante>` para búsquedas rápidas por ID.
- Validaciones, correo único y control de excepciones.
- Datos en JSON en `%LOCALAPPDATA%\Hito3_GestionEstudiantes\estudiantes.json`.
- Registro básico de errores en la misma carpeta.

## Sistemas legados
Prototipo de modernización de un registro académico antiguo: reemplaza consultas manuales por una interfaz con validaciones, búsqueda por clave y almacenamiento estructurado. No se conecta a un sistema legado real.

## Seguridad y limitaciones
- La contraseña no se almacena en texto plano en memoria como hash; se deriva mediante PBKDF2 con sal aleatoria. La clave demo aparece en el código por ser una prueba académica.
- Validación de ID, nombres, carrera y correo; se rechazan IDs y correos duplicados.
- Excepciones centralizadas en `GestorErrores`; errores técnicos registrados sin contraseñas.
- Escritura en archivo temporal antes de reemplazar JSON.
- El JSON local **no está cifrado**; depende de permisos de Windows y no debe usarse para datos personales reales.
- No hay permisos por rol ni base de datos multiusuario. Es un prototipo, no un sistema de producción.

## Pruebas sugeridas
1. Entrar con usuario incorrecto y luego con el correcto.
2. Registrar ID 1, nombre, apellido, correo y carrera.
3. Intentar repetir el ID o el correo (debe rechazarlo).
4. Buscar ID 1, editar sus datos y verificar la tabla.
5. Cerrar y abrir el programa: el estudiante debe mantenerse.
6. Eliminar el estudiante y comprobar que desaparece.

## Herencia y polimorfismo
`Persona` es una clase abstracta con propiedades `Nombre` y `Apellido` y un método virtual `Descripcion()`. `Estudiante : Persona` hereda esos datos y sobrescribe `Descripcion()`. En `Form3`, una referencia de tipo `Persona` llama a `Descripcion()` del objeto `Estudiante`, demostrando polimorfismo real.

## Caso de sistema legado (escenario ficticio)
Una institución usaba registros manuales con IDs repetidos, correos mal escritos y archivos que se perdían al cerrar el programa. Se migró conceptualmente a un prototipo Windows Forms con validación, almacenamiento JSON, búsqueda rápida mediante Dictionary y manejo centralizado de errores. La migración real requeriría importar y depurar registros antiguos, respaldar los originales, probar equivalencia de resultados y controlar permisos de acceso. Este proyecto demuestra una propuesta de modernización; no conecta ni migra un sistema antiguo real.

## Nota de seguridad
La clave de demostración continúa definida en el código fuente para pruebas académicas; no usar este proyecto para datos reales sin implementar gestión segura de credenciales. No se muestra en la pantalla de inicio de sesión.
