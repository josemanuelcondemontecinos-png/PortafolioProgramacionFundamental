using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine();
            Console.WriteLine("===== TAREA 4: EXCEPCIONES =====");
            Console.WriteLine("Estudiante: Jose Manuel Conde Montecinos");
            Console.WriteLine("1. Division segura");
            Console.WriteLine("2. Consulta segura de notas");
            Console.WriteLine("3. Cola de atencion en el consultorio");
            Console.WriteLine("4. Registro de edad");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opcion: ");
            try
            {
                opcion = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                opcion = -1;
            }

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

    // Ejercicio 1: Division segura
    static void Ejercicio1()
    {
        try
        {
            Console.Write("Dividendo: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Divisor: ");
            int b = int.Parse(Console.ReadLine());

            int resultado = a / b;
            Console.WriteLine("Resultado: " + resultado);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: debes escribir numeros enteros");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: no se puede dividir entre cero");
        }
        finally
        {
            Console.WriteLine("Operacion finalizada");
        }
    }
    // Ejercicio 2: Consulta segura de notas
    static void Ejercicio2()
    {
        int[] notas = { 70, 85, 90, 60, 100 };
        try
        {
            Console.Write("Numero de estudiante (1 a 5): ");
            int posicion = int.Parse(Console.ReadLine());

            Console.WriteLine("Nota del estudiante " + posicion + ": " + notas[posicion - 1]);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: debes escribir un numero");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Error: el estudiante debe estar entre 1 y 5");
        }
        finally
        {
            Console.WriteLine("Consulta terminada");
        }
    }
    // Ejercicio 3: Cola de atencion en el consultorio
    static void Ejercicio3()
    {
        Queue<string> cola = new Queue<string>();
        try
        {
            Console.Write("Cantidad de pacientes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nombre del paciente " + (i + 1) + ": ");
                string nombre = Console.ReadLine();
                cola.Enqueue(nombre);
            }

            Console.Write("Turnos a atender: ");
            int turnos = int.Parse(Console.ReadLine());
            int atendidos = 0;
            int intentados = 0;

            for (int t = 1; t <= turnos; t++)
            {
                try
                {
                    string paciente = cola.Dequeue();
                    Console.WriteLine("Turno " + t + ": atendiendo a " + paciente);
                    atendidos++;
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("Turno " + t + ": no hay pacientes en espera");
                }
                finally
                {
                    intentados++;
                }
            }

            Console.WriteLine("Atendidos: " + atendidos + " de " + turnos + " turnos");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: debes escribir un numero entero");
        }
    }
