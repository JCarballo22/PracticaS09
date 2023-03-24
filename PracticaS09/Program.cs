using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaS09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            empleado emple = new empleado();
            emple.capturarDatos(); 

            Personas persona = new Personas();
           // persona.Caminar();
            //persona.capturarDatos();
            persona.mostrarDatos();



            

            

            

            
            
            Console.ReadKey();
        }
    }
}
