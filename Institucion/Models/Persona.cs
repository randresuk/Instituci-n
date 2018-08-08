using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion.Models
{
    public abstract class Persona:IEnteInstituto
    {
        public static int Contadorpersonas = 0;    

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public short Edad { get; set; }
        public string Telefono { get; set; }
        protected int Inasistencias { get; set; }

        public virtual string NombreCompleto
        {
            get
            {
                //return string.Format("{0} {1}", Nombre, Apellido);
                return $"{Nombre} {Apellido}";
            }

        }

        string IEnteInstituto.CodigoInterno { get; set; }

        public Persona()
        {
            Contadorpersonas++;
            //Contadorpersonas += 1;
            //Contadorpersonas = Contadorpersonas + 1; todas las opciones son validas, la primera es la mejor.
        }

        public abstract string ConstruirResumen();

        string IEnteInstituto.CostruirLlaveSecreta(string nombreEnte)
        {
            var rnd = new Random();
            return rnd.Next(1,89238447).ToString(); 
        }
    }
}
