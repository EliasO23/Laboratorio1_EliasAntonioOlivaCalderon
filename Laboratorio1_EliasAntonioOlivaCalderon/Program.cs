// See https://aka.ms/new-console-template for more information
using Laboratorio1_EliasAntonioOlivaCalderon.Negocio;
using Laboratorio1_EliasAntonioOlivaCalderon.Entidades;

Persona persona = new Persona();
ClsPersona clsPersona = new ClsPersona();


Console.WriteLine("\nIngrese su nombre:");
persona.Nombre = Console.ReadLine();
Console.WriteLine("Ingrese su apellido:");
persona.Apellido = Console.ReadLine();
Console.WriteLine("Ingrese su edad:");
persona.Edad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese su sexo (H = Hombre M = Mujer):");
persona.Sexo = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Ingrese su peso (Kg):");
persona.Peso = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese su altura (m):");
persona.Altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\n------------------------------");
Console.WriteLine("Informacion: ");
Console.WriteLine("------------------------------");
Console.WriteLine($"Paciente: {persona.Nombre} {persona.Apellido}");
Console.WriteLine($"Edad: {persona.Edad}");
Console.WriteLine($"Sexo: {persona.Sexo}");
Console.WriteLine($"Peso: {persona.Peso}");
Console.WriteLine($"Altura: {persona.Altura}");
Console.WriteLine("------------------------------");
Console.WriteLine($"Paciente: {persona.Nombre} {persona.Apellido}");
Console.WriteLine(clsPersona.CalcularIMC(persona));
Console.WriteLine(clsPersona.EsMayordeEdad(persona));
Console.WriteLine("------------------------------\n");

