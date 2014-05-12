using System.Web;
using System.Web.Optimization;

namespace Eventos.Info.UI
{
    public class BundleConfig
    {
        // Para obtener más información acerca de Bundling, consulte http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                       "~/Scripts/bootstrap"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrapmin").Include(
                       "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrapcarousel").Include(
                       "~/Scripts/bootstrap-carousel"));
            
            bundles.Add(new ScriptBundle("~/bundles/bootstraptransition").Include(
                       "~/Scripts/bootstrap-transition"));
            
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                   "~/Scripts/jquery*"));

            /*bundles.Add(new ScriptBundle("~/bundles/personalizado").Include(
                   "~/Scripts/personalizado*"));*/

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información sobre los formularios. De este modo, estará
            // preparado para la producción y podrá utilizar la herramienta de creación disponible en http://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));

            bundles.Add(new StyleBundle("~/Content/bootstrap").Include("~/Content/bootstrap.css"));
            bundles.Add(new StyleBundle("~/Content/bootstrapmin").Include("~/Content/bootstrap.min.css"));
            bundles.Add(new StyleBundle("~/Content/carousel").Include("~/Content/carousel.css"));
            bundles.Add(new StyleBundle("~/Content/mainStyle").Include("~/Content/MainStyles.css"));


        }
    }
}