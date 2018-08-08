using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion.Models
{
    class Salon:IEnteInstituto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }


        string IEnteInstituto.CodigoInterno { get;  set; }

        string IEnteInstituto.CostruirLlaveSecreta(string nombreEnte)
        {
            return ("SAL ON");
        }
    }
        
}
