using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.WebPages.OAuth;
using Eventos.Info.UI.Models;

namespace Eventos.Info.UI
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            // Para permitir que los usuarios de este sitio inicien sesión con sus cuentas de otros sitios como, por ejemplo, Microsoft, Facebook y Twitter,
            // es necesario actualizar este sitio. Para obtener más información, visite http://go.microsoft.com/fwlink/?LinkID=252166

            //OAuthWebSecurity.RegisterMicrosoftClient(
            //    clientId: "",
            //    clientSecret: "");

            //OAuthWebSecurity.RegisterTwitterClient(
            //    consumerKey: "",
            //    consumerSecret: "");

            OAuthWebSecurity.RegisterFacebookClient(
                appId: "1434194346834335",
                appSecret: "c0984bfd065898d42edbc63e859100b4");

            //OAuthWebSecurity.RegisterGoogleClient();
        }
    }
}
