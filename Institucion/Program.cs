using Institucion.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList listaPersonas = new ArrayList();

            listaPersonas.Add(new Alumno("tori", "bio") { NickName = "cubito" });
            listaPersonas.Add(new Profesor() { Nombre = "casi", Apellido = "miro" });
            listaPersonas.Add(new Alumno("cala", "mardo"));
            listaPersonas.Add(new Profesor() { Nombre = "logan", Apellido = "oso" });
            listaPersonas.Add(new Alumno("super", "hero"));


            foreach (var obj in listaPersonas)
            {
                if (obj is Alumno)
                {
                    var al = (Alumno)obj;
                    Console.WriteLine(al.NickName != null ? al.NickName : al.NombreCompleto);
                }
                else
                {
                    var per = obj as Persona;

                    if (per != null)
                        Console.WriteLine(per.NombreCompleto);

                }
            }

            Console.ReadLine();

        }

        private static void Rutina2()
        {
            Persona[] arregloPersonas = new Persona[5];

            var tamañano = arregloPersonas.Length;

            arregloPersonas[0] = new Alumno("tori", "bio") { NickName = "cubito" };
            arregloPersonas[1] = new Profesor() { Nombre = "casi", Apellido = "miro" };
            arregloPersonas[2] = new Alumno("cala", "mardo");
            arregloPersonas[3] = new Profesor() { Nombre = "logan", Apellido = "oso" };
            arregloPersonas[4] = new Alumno("super", "hero");

            //arregloPersonas[5] = new Profesor() { Nombre = "cristiano", Apellido = "romualdo" };

            for (int i = 0; i < arregloPersonas.Length; i++)
            {
                if (arregloPersonas[i] is Alumno)
                {
                    var al = (Alumno)arregloPersonas[i];
                    Console.WriteLine(al.NickName != null ? al.NickName : al.NombreCompleto);
                }
                else
                {
                    Console.WriteLine(arregloPersonas[i].NombreCompleto);

                }
            }

            Console.ReadLine();
        }

        private static void Rutina1()
        {
            Console.WriteLine("GESTIÓN DE INSTITUCIÓN");

            Persona[] lista = new Persona[4];

            lista[0] = new Alumno("ricardo", "urrego")
            {
                Id = 1,
                Edad = 29,
                Telefono = "3133456789",
                Correo = "andres@andres.com",
                NickName = "Barbas"
            };

            lista[1] = new Profesor()
            {
                Id = 2,
                Apellido = "urrego",
                Edad = 20,
                Nombre = "Daniela",
                Telefono = "3123455678",
                Catedra = "matematicas"
            };

            lista[2] = new Profesor()
            {
                Id = 2,
                Apellido = "Ojo de Pato",
                Edad = 20,
                Nombre = "Canoso",
                Telefono = "31238",
                Catedra = "Programación"
            };

            lista[3] = new Profesor()
            {
                Id = 2,
                Apellido = "Ojo de Pato",
                Edad = 20,
                Nombre = "Canoso",
                Telefono = "31238",
                Catedra = "cuantica"

            };



            Console.WriteLine(Persona.Contadorpersonas);

            foreach (Persona p in lista)
            {

                Console.WriteLine((p.ConstruirResumen()));
                Console.WriteLine((p.GetType()));

                IEnteInstituto ente = p;

                ente.CostruirLlaveSecreta("hola");

            }

            Console.ReadLine();

            Console.WriteLine("S T R U C T-STACK- parametros por valor");
            var c = new CursoStruct(80);
            c.Curso = ("100-A");

            var cNew = new CursoStruct(80);
            cNew.Curso = ("777-B");

            var cLoco = c;
            cLoco.Curso = ("9090-C");

            Console.WriteLine($"EL VALOR DE C ES:{c.Curso}");
            Console.WriteLine($"El VALOR DE CLOCO ES: {cLoco.Curso}");

            Console.ReadLine();


            Console.WriteLine("C L A S S-HEAP-parametros por referencia");
            var cClass = new CursoClass(80);
            cClass.Curso = ("100-A");

            var cNewClass = new CursoClass(80);
            cNewClass.Curso = ("777-B");

            var cLocoClass = cClass;
            cLocoClass.Curso = ("9090-C");

            Console.WriteLine($"EL VALOR DE C ES:{cClass.Curso}");
            Console.WriteLine($"El VALOR DE CLOCO ES: {cLocoClass.Curso}");


            Console.ReadLine();

            Console.WriteLine("E N U M E R A C I O N");


            var alumnoEstado = new Alumno("joha", "rod")
            {

                Edad = 25,
                Telefono = "313789",
                Correo = "joha@joha.com",
                NickName = "IOA",
                Estado = EstadosAlumno.Matriculado
            };

            Console.WriteLine($"El estado es: {alumnoEstado.Estado}");
            Console.WriteLine($"El tipo es: {typeof(EstadosAlumno)}");
            Console.WriteLine($"El tipo es: {typeof(Alumno)}");
            Console.WriteLine($"El nombre es: {nameof(Alumno)}");
            Console.WriteLine($"El tamaño es: {sizeof(int)}");

            Console.WriteLine($"El tipo es: {alumnoEstado.GetType()}");

            var personax = alumnoEstado;
            Console.WriteLine($"El tipo es: {personax.GetType()}");

            IEnteInstituto iei = alumnoEstado;
            Console.WriteLine($"El tipo es: {iei.GetType()}");

            Console.ReadLine();

            /* EJEMPLO DE CASTING CON VARIBLES

           var alumno = new Alumno("victor", "Perez");
           var profesor = new Profesor();
           Persona persona = profesor;

           alumno = (Alumno) persona;

           if (persona is Profesor)
           {
               var profe = (Profesor)persona;
           }

           var tmpProfe = persona as Profesor;

           if (tmpProfe != null) 
           {
               //...
           }

           */



            // alumno1.Inasistencias = 90;


            //var alumno2 = new Alumno(){};
            //alumno2 = profesor1;  no se puede igualar porque los dos tienen diferentes atributos aunque hereden de la mismca clase.

            //Persona a = profesor1; 
            //Persona b = alumno1;
            //a = b; cumplen la condición ya que son igualados a un nivel de personas y no con los atributos de cada uno.  

            // Alumno almuno3 = a; No se puede realizar ya que alumno 3 es clase alumno y a es clase persona, no tienen los mismos atributos

            //persona1 = alumno1;

            // alumno1 = persona1; no se puede realizar ya que las funcionalidades y campos que no estan, no se aplica herencia
            // alumno1.Id; forma de llamar las propiedades 
        }
    }
}
