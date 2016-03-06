using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CONTENEDORES;

namespace WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceDepartamento" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceDepartamento.svc o ServiceDepartamento.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceDepartamento : IServiceDepartamento
    {
        BS.Interfaces.IBSDepartamento bsDepar = new BS.Clases.BSDepartamento();
        public List<string> DesplegarDepartamentos()
        {
            return bsDepar.DesplegarDepartamentos();
        }
    }
}
