using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTENEDORES
{
    public class Tecnico
    {
        private string IdTecnico, NombreTecnico, Apellido1, Apellido2, Email, TelefonoCelular;


        public string idtecnico
        {
            get
            {
                return IdTecnico;
            }

            set
            {
                IdTecnico = value;
            }
        }

        public string nombretecnico
        {
            get
            {
                return NombreTecnico;
            }

            set
            {
                NombreTecnico = value;
            }
        }

        public string apellido1
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

        public string apellido2
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

        public string telefonocelular
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
