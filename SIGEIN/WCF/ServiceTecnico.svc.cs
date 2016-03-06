using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CONTENEDORES;

namespace WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceTecnico" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceTecnico.svc o ServiceTecnico.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceTecnico : IServiceTecnico
    {
        BS.Interfaces.IBSTecnico bsTecnico = new BS.Clases.BSTecnico();

        public void InsertarTecnico(Tecnico tecnico)
        {
            bsTecnico.InsertarTecnico(tecnico);
        }

        public void ActualizarTecnico(Tecnico tecnico)
        {
            bsTecnico.ActualizarTecnico(tecnico);
        }

        public void EliminarTecnico(Tecnico tecnico)
        {
            bsTecnico.EliminarTecnico(tecnico);
        }

        public Tecnico BuscarTecnico(Tecnico tecnico)
        {
            return bsTecnico.BuscarTecnico(tecnico);
        }   

        public List<Tecnico> ListarTecnicos()
        {
            return bsTecnico.ListarTecnicos();
        }
    }
}
