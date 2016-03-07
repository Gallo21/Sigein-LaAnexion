using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTENEDORES
{
    public class Usuario
    {
        private string IdUsuario, NombreUsuario, Contraseña, NombreDepartamento, Ocupacion, Apellido1, Apellido2, Email, TelefonoCelular;
        private int AccesoIntrusos, EstatusBloqueo;
        private DateTime CaducidadContraseña;
        public string idusuario
        {
            get
            {
                return IdUsuario;
            }

            set
            {
                IdUsuario = value;
            }
        }

        public string nombreusuario
        {
            get
            {
                return NombreUsuario;
            }

            set
            {
                NombreUsuario = value;
            }
        }

        public string contraseña
        {
            get
            {
                return Contraseña;
            }

            set
            {
                Contraseña = value;
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

        public string ocupacion
        {
            get
            {
                return Ocupacion;
            }

            set
            {
                Ocupacion = value;
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

        public int accesointrusos
        {
            get
            {
                return AccesoIntrusos;
            }

            set
            {
                AccesoIntrusos = value;
            }
        }

        public int estatusbloqueo
        {
            get
            {
                return EstatusBloqueo;
            }

            set
            {
                EstatusBloqueo = value;
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

        public DateTime caducidadcontraseña
        {
            get
            {
                return CaducidadContraseña;
            }

            set
            {
                CaducidadContraseña = value;
            }
        }
    }
}
