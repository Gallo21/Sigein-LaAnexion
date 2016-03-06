using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTENEDORES;
using BS.Interfaces;

namespace BS.Clases
{
    public class BSDepartamento : IBSDepartamento
    {
        DS.Interfaces.IDepartamento cadDepartamento = new DS.ClasesAccesoDatos.CADDepartamento();

        public List<string> DesplegarDepartamentos()
        {
            return cadDepartamento.DesplegarDepartamentos();
        }
     
    }
}
