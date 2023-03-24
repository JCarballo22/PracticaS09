using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaS09
{
    class Personas
    {
        string nombre;
        string apellidos;
        string sexo;
        int edad;

        private string nacionalidad;

        public void setNacionalidad(string naconalidad)
        {
            this.nacionalidad = naconalidad;
        }

        public string getNacionalidad() { return nacionalidad; }

        protected void Caminar()
        {
            Console.WriteLine("Esta persona camina con elegancia");
        }

        public void capturarDatos()
        {
            Console.WriteLine("Digite los datos de usuario");
            nombre = Console.ReadLine();
            apellidos = Console.ReadLine();
            sexo = Console.ReadLine();
            edad = int.Parse(Console.ReadLine());
        }

        public void mostrarDatos()
        {
            
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Apellidos: {apellidos}");
            Console.WriteLine($"Sexo: {sexo}");
            Console.WriteLine($"Edad: {edad}");

            Personas per = new Personas();
            per.Caminar();
        }



    }

    class empleado : Personas
    {
        string cargo = "Vendedor";
        string departamento = "Deportes";

        void Mensaje()
        {
            Personas perso= new Personas();
            perso.capturarDatos();
        }
        
    }
}
