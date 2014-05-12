using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Eventos.Info.DAL;
namespace Eventos.Info.Negocio
{
    public class CommonBC
    {
        private static EventosdbEntities _modeloEvento;
        public static EventosdbEntities ModeloEvento
        {
            get
            {
                if (_modeloEvento == null)
                    _modeloEvento = new EventosdbEntities();
                return _modeloEvento;
            }
        }
        public CommonBC()
        {

        }
    }
}
