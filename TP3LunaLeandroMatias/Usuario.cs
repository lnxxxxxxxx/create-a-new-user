using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3LunaLeandroMatias
{
    class Usuario
    {
        private string nombre;
        private string email;
        private int sueldo;
        private string sexo;
        private int peso;
        private float altura;

        public Usuario(string nombre, int sueldo, string sexo, int peso, float altura)
        {
            this.nombre = nombre;
            this.sueldo = sueldo;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;

        }

      // public Email(string email)
        //{
          //  this.email = nombre;
        //}

        public string GetEmail()
        {
            return this.email = nombre + "@superempresa.com.ar";
        }
        public string GetNombre()
        {
            return this.nombre;
        }

        public string GetSueldo()
        {
            return this.sueldo.ToString();
        }

        public string GetSexo()
        {
            return sexo;
        }

        public string GetPeso()
        {
            return this.peso.ToString();
        }

        public string GetAltura()
        {
            return this.altura.ToString();
        }








    }
}
