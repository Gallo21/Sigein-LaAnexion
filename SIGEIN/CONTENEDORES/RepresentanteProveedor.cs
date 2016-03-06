using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTENEDORES
{
   public class RepresentanteProveedor
    {
        private string IdRepresentante, CedulaJuridica, Nombre, Apellido1, Apellido2, Email, TelefonoCelular;

        public string IdRProvee
        {
            get
            {
                return IdRepresentante;
            }

            set
            {
                IdRepresentante = value;
            }
        }

        public string Cedjuridica
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

        public string Nom
        {
            get
            {
                return Nombre;
            }

            set
            {
                Nombre = value;
            }
        }

        public string Ape1
        {
            get
            {
                return Apellido1;
            }
            set
            {
                Apellido1 = value;
            }
        }

        public string Ape2
        {
            get
            {
                return Apellido2;
            }

            set
            {
                Apellido2 = value;
            }
        }

        public string email
        {
            get
            {
                return Email;
            }

            set
            {
                Email = value;
            }
        }

        public string TCelular
        {
            get
            {
                return TelefonoCelular;
            }

            set
            {
                TelefonoCelular = value;
            }
        }

    }
}
