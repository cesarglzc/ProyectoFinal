using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eventos.Info.UI.Models;
using System.Net.Mail;
using System.Configuration;
using Eventos.Info.UI.EventoServiceReference;

namespace Eventos.Info.UI.Controllers
{
    public class HomeController : Controller
    {
        private EventosdbEntities1 db = new EventosdbEntities1();

        //
        // GET: /Home/

        public ActionResult Index()
        {
            EventoServiceClient a = new EventoServiceClient();
            List<EventoServiceReference.Evento> b = a.BuscarUltimosEventos().ToList();

            List<Eventos.Info.UI.Models.Evento> listaEventos = new List<Eventos.Info.UI.Models.Evento>();
            

            foreach (var item in b)
            {
                Eventos.Info.UI.Models.Evento evento = new Eventos.Info.UI.Models.Evento();

                evento.CategoriaId= item.CategoriaId;
                evento.Descripcion = item.Descripcion;
                evento.EventoId = item.EventoId;
                evento.Fecha = item.Fecha;
                evento.Hora = item.Hora;
                evento.Lugar = item.Lugar;
                evento.Nombre = item.Nombre;
                evento.OrganizadorId = item.OrganizadorId;
                evento.PosterUrl = item.PosterUrl;
                evento.Precio = item.Precio;

                listaEventos.Add(evento);

            }
           

            return View(listaEventos);
        }

        public ActionResult Eventos()
        {
            var evento = db.Evento.Include(e => e.Categoria).Include(e => e.Organizador);
            return View(evento.ToList());
        }

        //
        // GET: /Home/Details/5

        public ActionResult Details(int id = 0)
        {
            Eventos.Info.UI.Models.Evento evento = db.Evento.Find(id);
            if (evento == null)
            {
                return HttpNotFound();
            }
            return View(evento);
        }

        public ActionResult Contacto()
        {
            return View();
        }

        public ActionResult Contact(int id)
        {
            Organizador organizador = db.Organizador.Find(id);

            return View(organizador);
        }

        public ActionResult Organizadores()
        {
            return View(db.Organizador.ToList());
        }

        public void EnviarCorreo()
        {
/* 
            MailMessage message = new MailMessage();
            message.From = new MailAddress("cesar_eduardo_91@hotmail.com");

            message.To.Add(new MailAddress("alex.car92@gmail.com"));            

            message.CC.Add(new MailAddress("carboncopy@foo.bar.com"));
            message.Subject = "Test";
            message.Body = "Esto tambien es test";

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 25;

            smtp.Credentials = new System.Net.NetworkCredential("alex.car92@gmail.com", "hola123");

            smtp.Send(message);           
*/
        }

    }
}