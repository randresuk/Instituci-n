using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion.Models
{
    public struct CursoStruct
    {
        private string curso;

        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }
        const string NOMBRE_DEF_CURSO = ("NO DEFINIDO");

        public readonly short Max_capacidad;

        public CursoStruct(short max_cap)
        {
            Max_capacidad = max_cap;
            curso = NOMBRE_DEF_CURSO;
        }


    }


}
