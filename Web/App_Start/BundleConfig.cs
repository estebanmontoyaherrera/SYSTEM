using System.Web;
using System.Web.Optimization;

namespace Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new Bundle("~/bundles/jquery").Include(
                               "~/Scripts/jquery-{version}.js"));

            bundles.Add(new Bundle("~/bundles/complementos").Include(

                       "~/Scripts/scripts.js",
                        "~/Scripts/fontawesome/all.js",
                        "~/Scripts/fontawesome/feather.min.js",
                        "~/Scripts/DataTables/jquery.dataTables.js",
                        "~/Scripts/DataTables/dataTables.bootstrap5.min.js",
                         "~/Scripts/DataTables/dataTables.buttons.js",
                         "~/Scripts/DataTables/jszip.min.js",
                         "~/Scripts/DataTables/buttons.html5.js",
                         "~/Scripts/DataTables/pdfmake.min.js",
                         "~/Scripts/DataTables/vfs_fonts.js",
                         "~/Scripts/DataTables/buttons.print.js",
                         "~/Scripts/DataTables/dataTables.fixedHeader.js",
                        "~/Scripts/DataTables/dataTables.responsive.js",
                        "~/Scripts/Loadingoverlay/loadingoverlay.min.js",
                        "~/Scripts/sweetalert.min.js",
                        "~/Scripts/select2.min.js",
                        "~/Scripts/jquery-ui.js",
                        "~/Scripts/jquery.validate.js"
                        ));



            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            //// para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.bundle.js",
                      "~/Scripts/Chart.min.js"

                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/styles.css",
                 "~/Content/DataTables/css/responsive.dataTables.css",
                  "~/Content/DataTables/css/dataTables.bootstrap5.min.css",
                  "~/Content/DataTables/css/buttons.dataTables.css",
                  "~/Content/DataTables/css/fixedHeader.dataTables.css",
                 "~/Content/jquery-ui.css",
                 "~/Content/select2.min.css",
                 "~/Content/Chart.min.css",
                 "~/Content/sweetalert.css"
                ));
        }
    }
}
