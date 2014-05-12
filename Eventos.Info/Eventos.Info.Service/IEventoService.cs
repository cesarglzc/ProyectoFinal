using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Eventos.Info.Service
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IEventoService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IEventoService
    {
        [OperationContract]
        List<Negocio.Evento> BuscarUltimosEventos();
    }
}
