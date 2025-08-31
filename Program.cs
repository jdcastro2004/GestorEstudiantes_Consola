using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices.Swift;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{

    //Lista de estudiantes
        static List<Estudiante> estudiantes=new();
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
            System.Console.WriteLine("4. Salir");
            System.Console.WriteLine("Elige una opcion");

            //Elegir opcion
            int opcion = int.Parse(Console.ReadLine()!);
            
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Funcion registrar estudiantes");
                    break;
                case 2:
                    Console.WriteLine("Funcion para listar estudiantes");
                    break;
                case 3:
                    Console.WriteLine("Funcion para buscar estudiantes");
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

    }
}

public class Estudiante
{
    //Propiedades
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Edad { get; set; }
    public string Carrera { get; set; }

    //Constructor
    public Estudiante(string nombre, string apellido, string edad, string carrera)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
        Carrera = carrera;
    }

    //Metodo
    public void MostrarInfo()
    {
        System.Console.WriteLine($"Nombre: {Nombre}, Apellido: {Apellido}, Edad: {Edad}, Carrera: {Carrera}");
    }

}


