using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTENEDORES;

namespace DS.Interfaces
{
    public interface ITecnico
    {
        void InsertarTecnico(CONTENEDORES.Tecnico tecnico);

        void ActualizarTecnico(CONTENEDORES.Tecnico tecnico);

        void EliminarTecnico(CONTENEDORES.Tecnico tecnico);

        CONTENEDORES.Tecnico BuscarTecnico(Tecnico tecnico);

        List<CONTENEDORES.Tecnico> ListarTecnicos();
    }
}
