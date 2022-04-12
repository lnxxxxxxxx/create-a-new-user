using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3LunaLeandroMatias
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string email;
            int sueldo;
            string sexo;
            int peso;
            float altura;

            Console.WriteLine("Bienvenido a la creacion de usuario");
            Console.WriteLine("Ingrese el nombre:");
            nombre = Console.ReadLine();

            

            Console.WriteLine("Ingrese su sueldo:");
            sueldo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su genero:");
            sexo = Console.ReadLine();

            Console.WriteLine("Ingrese su peso:");
            peso = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su altura:");
            altura = float.Parse(Console.ReadLine());


            Usuario miUser = new Usuario(nombre, sueldo, sexo, peso, altura);
            Console.WriteLine("");
            Console.WriteLine("Nombre: " + miUser.GetNombre());
            Console.WriteLine("Email: " + miUser.GetEmail());
            Console.WriteLine("Sueldo: " + miUser.GetSueldo() + "ARS");
            Console.WriteLine("Sexo: " + miUser.GetSexo());
            Console.WriteLine("Peso: " + miUser.GetPeso() + "kg");
            Console.WriteLine("Altura: " + miUser.GetAltura() + "m");



            Console.Read();
        }
    }
}
