using System;
using System.Collections.Generic;
using System.IO;

class CuentaBancaria
{
    private string titular;
    private int saldo;
    public CuentaBancaria(string titular, int saldoInicial) { this.titular = titular; saldo = saldoInicial; }
    public int Saldo { get { return saldo; } }
    public void Depositar(int monto)
    {
        if (monto <= 0) { Console.WriteLine("El deposito debe ser mayor a 0"); return; }
        saldo += monto;
        Console.WriteLine("Deposito de " + monto + " Bs. Saldo: " + saldo + " Bs");
    }
    public void Retirar(int monto)
    {
        if (monto <= 0) { Console.WriteLine("El retiro debe ser mayor a 0"); return; }
        if (monto > saldo) { Console.WriteLine("Saldo insuficiente. Saldo: " + saldo + " Bs"); return; }
        saldo -= monto;
        Console.WriteLine("Retiro de " + monto + " Bs. Saldo: " + saldo + " Bs");
    }
    public void MostrarResumen() { Console.WriteLine("Cuenta de " + titular + " | Saldo final: " + saldo + " Bs"); }
}

class Libro
{
    private string titulo;
    private bool disponible;
    public Libro(string titulo) { this.titulo = titulo; disponible = true; }
    public string Titulo { get { return titulo; } }
    public bool Disponible { get { return disponible; } }
    public bool Prestar()
    {
        if (!disponible) return false;
        disponible = false;
        return true;
    }
}

class Contacto
{
    private string nombre;
    private string telefono;
    public Contacto(string nombre, string telefono) { this.nombre = nombre; this.telefono = telefono; }
    public string ALinea() { return nombre + ";" + telefono; }
}

class Personaje
{
    private string nombre;
    private string clase;
    private int nivel;
    public Personaje(string nombre, string clase, int nivel)
    {
        this.nombre = nombre;
        this.clase = clase;
        Nivel = nivel;
    }
    public int Nivel
    {
        get { return nivel; }
        set
        {
            if (value < 1) throw new ArgumentOutOfRangeException("nivel");
            nivel = value;
        }
    }
    public void SubirNivel() { Nivel++; }
    public string MostrarFicha() { return nombre + " - " + clase + " - Nivel " + nivel; }
    public string ALinea() { return nombre + ";" + clase + ";" + nivel; }
}

class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n===== TAREA 7: CLASES Y ARCHIVOS =====");
            Console.WriteLine("Estudiante: Jose Conde");
            Console.WriteLine("1. Cuenta bancaria");
            Console.WriteLine("2. Prestamo de libros");
            Console.WriteLine("3. Agenda de contactos con archivo");
            Console.WriteLine("4. Personajes de videojuegos");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opcion: ");
            if (!int.TryParse(Console.ReadLine(), out opcion)) opcion = -1;
            switch (opcion)
            {
                case 1: Ejercicio1(); break;
                case 2: Ejercicio2(); break;
                case 3: Ejercicio3(); break;
                case 4: Ejercicio4(); break;
                case 0: Console.WriteLine("Hasta luego"); break;
                default: Console.WriteLine("Opcion no valida"); break;
            }
        } while (opcion != 0);
    }

    static int LeerEntero(string mensaje)
    {
        int numero;
        Console.Write(mensaje);
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.Write("Ingresa un numero entero: ");
        }
        return numero;
    }

    static void Ejercicio1()
    {
        Console.Write("Titular: ");
        string titular = Console.ReadLine();
        int inicial = LeerEntero("Saldo inicial: ");
        CuentaBancaria cuenta = new CuentaBancaria(titular, inicial);
        int deposito = LeerEntero("Deposito: ");
        int retiro = LeerEntero("Retiro: ");
        cuenta.Depositar(deposito);
        cuenta.Retirar(retiro);
        cuenta.MostrarResumen();
    }

    static void Ejercicio2()
    {
        List<Libro> libros = new List<Libro>
        {
            new Libro("El Principito"), new Libro("Don Quijote"), new Libro("Rayuela")
        };
        for (int i = 0; i < 2; i++)
        {
            Console.Write("Titulo solicitado: ");
            string buscado = Console.ReadLine() ?? "";
            Libro encontrado = null;
            foreach (Libro libro in libros)
            {
                if (string.Equals(libro.Titulo, buscado.Trim(), StringComparison.OrdinalIgnoreCase))
                { encontrado = libro; break; }
            }
            if (encontrado == null) Console.WriteLine("No existe el libro " + buscado);
            else if (encontrado.Prestar()) Console.WriteLine("Prestado: " + encontrado.Titulo);
            else Console.WriteLine(encontrado.Titulo + " ya esta prestado");
        }
        Console.WriteLine("Estado de la biblioteca:");
        foreach (Libro libro in libros)
            Console.WriteLine(libro.Titulo + " - " + (libro.Disponible ? "Disponible" : "Prestado"));
    }

    static void Ejercicio3()
    {
        int cantidad = LeerEntero("Cantidad de contactos: ");
        if (cantidad < 0) { Console.WriteLine("Cantidad no valida"); return; }
        List<Contacto> contactos = new List<Contacto>();
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Telefono: ");
            string telefono = Console.ReadLine();
            contactos.Add(new Contacto(nombre, telefono));
        }
        List<string> lineas = new List<string>();
        foreach (Contacto contacto in contactos) lineas.Add(contacto.ALinea());
        File.WriteAllLines("contactos.txt", lineas);
        Console.WriteLine("Contactos guardados: " + cantidad);
        Console.WriteLine("Leyendo contactos.txt:");
        foreach (string linea in File.ReadAllLines("contactos.txt"))
        {
            string[] partes = linea.Split(';');
            if (partes.Length >= 2) Console.WriteLine(partes[0] + " - Tel: " + partes[1]);
        }
    }

    static void Ejercicio4()
    {
        List<Personaje> personajes = new List<Personaje>
        {
            new Personaje("Akari", "Maga de fuego", 8),
            new Personaje("Hideo", "Guerrero", 5),
            new Personaje("Sophi", "Sanadora", 12)
        };

        Console.WriteLine("Personajes disponibles:");
        for (int i = 0; i < personajes.Count; i++)
            Console.WriteLine((i + 1) + ". " + personajes[i].MostrarFicha());

        int elegido = LeerEntero("Elige un personaje para subir de nivel (1-3): ");
        if (elegido >= 1 && elegido <= 3)
        {
            personajes[elegido - 1].SubirNivel();
            Console.WriteLine("Nivel aumentado: " + personajes[elegido - 1].MostrarFicha());
        }
        else Console.WriteLine("Personaje no valido. No se subio ningun nivel.");

        int nuevoNivel = LeerEntero("Escribe un nuevo nivel para Akari (minimo 1): ");
        try
        {
            personajes[0].Nivel = nuevoNivel;
            Console.WriteLine("Nivel actualizado correctamente: " + personajes[0].MostrarFicha());
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Validacion correcta: no se permiten niveles menores a 1.");
        }

        List<string> lineas = new List<string>();
        foreach (Personaje p in personajes) lineas.Add(p.ALinea());
        File.WriteAllLines("personajes.txt", lineas);
        Console.WriteLine("Personajes guardados: " + personajes.Count);
        Console.WriteLine("Leyendo personajes.txt:");
        foreach (string linea in File.ReadAllLines("personajes.txt"))
        {
            string[] partes = linea.Split(';');
            if (partes.Length == 3)
                Console.WriteLine(partes[0] + " - " + partes[1] + " - Nivel " + partes[2]);
        }
    }
}
