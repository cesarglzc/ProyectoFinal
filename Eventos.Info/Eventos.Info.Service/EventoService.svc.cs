using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Eventos.Info.Service
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "EventoService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione EventoService.svc o EventoService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class EventoService : IEventoService
    {
      
        public List<Negocio.Evento> BuscarUltimosEventos()
        {
            
            List<Negocio.Evento> listaEventos = new List<Negocio.Evento>();
            
            Eventos.Info.Negocio.Evento evento = new Eventos.Info.Negocio.Evento();
            listaEventos = evento.LeerUltimosEventos();
            
            return listaEventos;

        }
    }
}
