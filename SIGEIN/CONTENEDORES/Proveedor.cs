using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTENEDORES
{
    public class Proveedor
    {

        private string NombreEmpresa, DescripcionEmpresa, Telefono, SitioWeb, CedulaJuridica;
        public string NomEmpresa
        {
            get
            {
                return NombreEmpresa;
            }

            set
            {
                NombreEmpresa = value;
            }
        }

        public string DesEmpresa
        {
            get
            {
                return DescripcionEmpresa;
            }

            set
            {
                DescripcionEmpresa = value;
            }
        }

        public string Tel
        {
            get
            {
                return Telefono;
            }

            set
            {
                Telefono = value;
            }
        }

        public string sitio
        {
            get
            {
                return SitioWeb;
            }

            set
            {
                SitioWeb = value;
            }
        }

        public string cedJuri
        {
            get
            {
                return CedulaJuridica;
            }

            set
            {
                CedulaJuridica = value;
            }
        }

    }
}
