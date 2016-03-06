using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CONTENEDORES;

namespace WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceTecnico" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceTecnico
    {

        [OperationContract]
        void InsertarTecnico(CONTENEDORES.Tecnico tecnico);

        [OperationContract]
        void ActualizarTecnico(CONTENEDORES.Tecnico tecnico);

        [OperationContract]
        void EliminarTecnico(CONTENEDORES.Tecnico tecnico);

        [OperationContract]
        CONTENEDORES.Tecnico BuscarTecnico(CONTENEDORES.Tecnico tecnico);

        [OperationContract]
        List<CONTENEDORES.Tecnico> ListarTecnicos();

    }
}
