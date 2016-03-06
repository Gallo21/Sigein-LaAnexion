using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTENEDORES
{
    public class Departamento
    {
        private string CodigoDepartamento, NombreDepartamento, Descripcion;

        public string codigodepartamento
        {
            get
            {
                return CodigoDepartamento;
            }

            set
            {
                CodigoDepartamento = value;
            }
        }

        public string nombredepartamento
        {
            get
            {
                return NombreDepartamento;
            }

            set
            {
                NombreDepartamento = value;
            }
        }

        public string descripcion
        {
            get
            {
                return Descripcion;
            }

            set
            {
                Descripcion = value;
            }
        }

    }
}
