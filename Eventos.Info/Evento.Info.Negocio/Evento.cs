using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Info.Negocio
{
    public class Evento
    {
        public int EventoId { get; set; }
        public int? OrganizadorId { get; set; }
        public int? CategoriaId { get; set; }
        public string Nombre { get; set; }
        public string Fecha { get; set; }
        public string Lugar { get; set; }
        public string Hora { get; set; }
        public int? Precio { get; set; }
        public string Descripcion { get; set; }
        public string PosterUrl { get; set; }


        public List<Negocio.Evento> LeerUltimosEventos()
        {
            List<Negocio.Evento> listaEventos = new List<Evento>();
            try
            {
                List<Eventos.Info.DAL.Evento> listaDAL = CommonBC.ModeloEvento.Evento.OrderByDescending(res => res.EventoId).OrderByDescending.ToList();
                foreach (DAL.Evento eventod in listaDAL)
                {
                    Negocio.Evento eventon = new Evento();
                    eventon.EventoId = eventod.EventoId;
                    eventon.OrganizadorId = eventod.OrganizadorId;
                    eventon.CategoriaId = eventod.CategoriaId;
                    eventon.Nombre = eventod.Nombre;
                    eventon.Fecha = eventod.Fecha;
                    eventon.Lugar = eventod.Lugar;
                    eventon.Hora = eventod.Hora;
                    eventon.Precio = eventod.Precio;
                    eventon.Descripcion = eventod.Descripcion;
                    eventon.PosterUrl = eventod.PosterUrl;
                    if (listaEventos.Count <= 4)
                    {
                        listaEventos.Add(eventon);
                    }
                    
                }
                return listaEventos;
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return listaEventos;
        }

    }

}
