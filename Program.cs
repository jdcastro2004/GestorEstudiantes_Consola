using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices.Swift;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{

    //Lista de estudiantes
        static List<Estudiante> estudiantes = new();
    static void Main()
    {

        bool salir = false;

        //Si es distinto de salir
        while (!salir)
        {
            //Menu
            System.Console.WriteLine("Gestor de estudiantes");
            System.Console.WriteLine("1. Registrar estudiantes");
            System.Console.WriteLine("2. Listar estudiantes");
            System.Console.WriteLine("3. Buscar estudiantes");
            System.Console.WriteLine("4. Registrar profesor");
            System.Console.WriteLine("5. Listar profesor");
            System.Console.WriteLine("6. Buscar profesor");
            System.Console.WriteLine("7. Salir");
            System.Console.WriteLine("Elige una opcion");

            try
            {
                //Elegir opcion
                int opcion = int.Parse(Console.ReadLine()!);

                switch (opcion)
                {
                    case 1:
                        // Console.WriteLine("Funcion registrar estudiantes");
                        RegistrarEstudiante();
                        break;
                    case 2:
                        // Console.WriteLine("Funcion para listar estudiantes");
                        ListarEstudiante();
                        break;
                    case 3:
                        // Console.WriteLine("Funcion para buscar estudiantes");
                        BucarEstudiante();
                        break;
                    case 4:
                        salir = true;
                        break;
                    //Opcion invalida
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
            catch(FormatException)
            {
                System.Console.WriteLine("Error al ingresar el numero");
            }

            //Funcion registrar
            static void RegistrarEstudiante()
            {
                Console.WriteLine("Nombre:");
                string nombre = Console.ReadLine()!;
                Console.WriteLine("Apellido:");
                string apellido = Console.ReadLine()!;
                Console.WriteLine("Edad:");
                int edad = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Carrera:");
                string carrera = Console.ReadLine()!;

                estudiantes.Add(new Estudiante(nombre, apellido, edad, carrera));
                Console.WriteLine("Estudiante registrado de forma correcta");
            }

            //Funcion Listar
            static void ListarEstudiante()
            {
                Console.WriteLine("LISTA DE ESTUDIANTES:");
                //Recorre lista de estudiantes
                foreach (var i in estudiantes)
                {
                    i.MostrarInfo();
                }
            }

            // Funcion para buscar estudiantes por medio de nombres
            static void BucarEstudiante()
            {
                Console.WriteLine("Busar estudiante:  ");
                string nombre = Console.ReadLine()!;


                foreach (var e in estudiantes)
                {
                    //Si el Nombre es igual al nombre ignorando si las letras son mayusculas o minusculas
                    if (e.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Estudiante encontrado: ");
                        e.MostrarInfo();
                        return;
                    } 
                    //Si no se encontro
                    else
                    {
                        Console.WriteLine("Estudiante no encontrado");
                    }

                }
            }

        }

    }
}

//Clase persona
public abstract class Persona
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }

    public abstract void MostrarInfo();
}


public class Estudiante : Persona
{
    //Propiedades
    // public string Nombre { get; set; }
    // public string Apellido { get; set; }
    // public int Edad { get; set; }
    public string Carrera { get; set; }

    public Estudiante(string nombre, string apellido, int edad, string carrera)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
        Carrera = carrera;
    }

    public override void MostrarInfo()
    {
        Console.WriteLine($"Estudiante: {Nombre},Apellido: {Apellido}, Edad: {Edad}, Carrera: {Carrera}");
    }

}

public class Profesor : Persona
{
    string Materia { get; set; }
    Profesor(string nombre, string apellido, int edad, string materia)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
        Materia = materia;
    }
    public override void MostrarInfo()
    {
        System.Console.WriteLine($"Nombre: {Nombre}, Apellido: {Apellido}, Edad: {Edad}, Materia: {Materia}");
    }

}





