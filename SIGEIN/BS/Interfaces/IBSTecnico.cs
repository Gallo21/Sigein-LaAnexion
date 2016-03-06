using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CONTENEDORES;

namespace BS.Interfaces
{
    public interface IBSTecnico
    {
        void InsertarTecnico(CONTENEDORES.Tecnico tecnico);

        void ActualizarTecnico(CONTENEDORES.Tecnico tecnico);

        void EliminarTecnico(CONTENEDORES.Tecnico tecnico);

        CONTENEDORES.Tecnico BuscarTecnico(CONTENEDORES.Tecnico tecnico);

        List<Tecnico> ListarTecnicos();

    }
}
