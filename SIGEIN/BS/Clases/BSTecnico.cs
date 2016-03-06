using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTENEDORES;
using BS.Interfaces;

namespace BS.Clases
{
    public class BSTecnico : IBSTecnico
    {
        DS.Interfaces.ITecnico cadTecnico = new DS.ClasesAccesoDatos.CADTecnico();

        public void InsertarTecnico(Tecnico tecnico)
        {
            cadTecnico.InsertarTecnico(tecnico);
        }

        public void ActualizarTecnico(Tecnico tecnico)
        {
            cadTecnico.ActualizarTecnico(tecnico);
        }

        public void EliminarTecnico(Tecnico tecnico)
        {
            cadTecnico.EliminarTecnico(tecnico);
        }

        public Tecnico BuscarTecnico(Tecnico tecnico)
        {
            return cadTecnico.BuscarTecnico(tecnico);
        }

        public List<Tecnico> ListarTecnicos()
        {
            return cadTecnico.ListarTecnicos();
        }

    }
}
