using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var listaPersonas = new List<Persona>();
            // Creamos una instancia de la clase Random
            Random numeroRandom = new Random();

            for (int i = 0; i < 1000; i++)
        
            {
                var nuevaPersona = new Persona();

                nuevaPersona.Nombre = "Nombre" + (i + 1);
                nuevaPersona.Apellido = "Apellido" + (i+1);
                nuevaPersona.Edad = numeroRandom.Next(1, 81); // Generamos un número aleatorio en el rango del 1 al 80

                listaPersonas.Add(nuevaPersona);

                //Otra forma más optima de realizar
                //personas.Add(new Persona
                //{
                //    Nombre = "Nombre" + (i + 1),
                //    Apellido = "Apellido" + (i + 1),
                //    Edad = numerorandom.Next(1,81) 
                //}) ;
            }




            foreach (Persona persona in listaPersonas)
            {
                if (persona.Nombre.EndsWith("00"))
                {
                    Console.WriteLine($"Name: {persona.Nombre}, LastName: {persona.Apellido}, Age: {persona.Edad}");

                }
            }

            //Utilizando LINQ

            //foreach (Persona persona in personas.FindAll(x=>x.Nombre.EndsWith("00")))
            //{
               
            //        Console.WriteLine($"Name: {persona.Nombre}, Apellido {persona.Apellido}, Edad: {persona.Edad}");

            //}
            Console.ReadLine();
        }
    }
}
