using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Info.Model
{
    public class Evento
    {
        public int EventoId { get; set; }
        public string Nombre { get; set; }
        public int OrganizadorId { get; set; }
        public int CategoriaId { get; set; }
        public string Fecha { get; set; }
        public string Lugar { get; set; }
        public string Hora { get; set; }
        public int Precio { get; set; }
        public string Descripcion { get; set; }
        public string PosterURL { get; set; }
    }
}
