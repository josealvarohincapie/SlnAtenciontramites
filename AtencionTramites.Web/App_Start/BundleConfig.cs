using System.Web;
using System.Web.Optimization;
using System.Reflection;
using Ultimus.Framework;

namespace AtencionTramites
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ResourceTrasform().GetBundleScriptsResources());
            bundles.Add(new ScriptBundle("~/bundles/tether").Include("~/Scripts/tether/tether.min.js"));
            bundles.Add(new StyleBundle("~/Content/tether").Include("~/Content/tether/tether.css"));
            bundles.Add(new ScriptBundle("~/bundles/tether").Include("~/Scripts/tether/tether.min.js"));
            bundles.Add(new StyleBundle("~/Content/tether").Include("~/Content/tether/tether.css"));
            bundles.Add(new ScriptBundle("~/bundles/tether").Include("~/Scripts/tether/tether.min.js"));
            bundles.Add(new StyleBundle("~/Content/tether").Include("~/Content/tether/tether.css"));
            bundles.Add(new ScriptBundle("~/bundles/tether").Include("~/Scripts/tether/tether.min.js"));
            bundles.Add(new StyleBundle("~/Content/tether").Include("~/Content/tether/tether.css"));
            bundles.Add(new ScriptBundle("~/bundles/tether").Include("~/Scripts/tether/tether.min.js"));
            bundles.Add(new StyleBundle("~/Content/tether").Include("~/Content/tether/tether.css"));
            bundles.Add(new ScriptBundle("~/bundles/tether").Include("~/Scripts/tether/tether.min.js"));
            bundles.Add(new StyleBundle("~/Content/tether").Include("~/Content/tether/tether.css"));
            bundles.Add(new ScriptBundle("~/bundles/tether").Include("~/Scripts/tether/tether.min.js"));
            bundles.Add(new StyleBundle("~/Content/tether").Include("~/Content/tether/tether.css"));
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery-migrate").Include("~/Scripts/jquery-migrate-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include("~/Scripts/jquery-ui-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/Scripts/jquery.unobtrusive*", "~/Scripts/jquery.validate*"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/Scripts/jquery.validate.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap3-typeahead").Include("~/Scripts/bootstrap3-typeahead.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/maskedinput").Include("~/Scripts/jquery.maskedinput-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/FastClick").Include("~/Scripts/fastclick.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquerysteps").Include("~/Scripts/jquery.steps.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/moneymask").Include("~/Scripts/jquery.moneymask.js"));
            bundles.Add(new ScriptBundle("~/bundles/toastr").Include("~/Scripts/toastr.js"));
            bundles.Add(new ScriptBundle("~/bundles/moment").Include("~/Scripts/moment.js").Include("~/Scripts/moment-with-langs.js"));
            bundles.Add(new ScriptBundle("~/bundles/bonsai").Include("~/Scripts/jquery.qubit.js").Include("~/Scripts/jquery.bonsai.js"));
            bundles.Add(new ScriptBundle("~/bundles/autoNumeric").Include("~/Scripts/autoNumeric/autoNumeric-{version}.js"));
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/bootstrap.css"));
            bundles.Add(new StyleBundle("~/Content/dashboard").Include("~/Content/dashboard.css"));
            bundles.Add(new StyleBundle("~/Content/awesome").Include("~/Content/font-awesome.css"));
            bundles.Add(new StyleBundle("~/Content/toastr").Include("~/Content/toastr.css"));
            bundles.Add(new StyleBundle("~/Content/bootstrap-datepicker").Include("~/Content/bootstrap-datepicker.css"));
            bundles.Add(new StyleBundle("~/Content/bonsai").Include("~/Content/jquery.bonsai.css"));
            bundles.Add(new StyleBundle("~/Content/jquerystepscss").Include("~/Content/jquery.steps.css"));
            bundles.Add(new StyleBundle("~/Content/jquery-dataTables").Include("~/Content/DataTables/css/jquery.dataTables.css", "~/Content/DataTables/css/buttons.dataTables.min.css"));
            bundles.Add(new ScriptBundle("~/bundles/jquery-dataTables").Include("~/Scripts/DataTables/jquery.dataTables.js", "~/Scripts/DataTables/dataTables.buttons.min.js", "~/Scripts/DataTables/buttons.flash.min.js", "~/Scripts/DataTables/buttons.html5.min.js", "~/Scripts/DataTables/buttons.print.min.js", "~/Scripts/jszip.min.js", "~/Scripts/pdfmake.min.js", "~/Scripts/vfs_fonts.js"));
            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include("~/Content/themes/base/jquery.ui.core.css", "~/Content/themes/base/jquery.ui.resizable.css", "~/Content/themes/base/jquery.ui.selectable.css", "~/Content/themes/base/jquery.ui.accordion.css", "~/Content/themes/base/jquery.ui.autocomplete.css", "~/Content/themes/base/jquery.ui.button.css", "~/Content/themes/base/jquery.ui.dialog.css", "~/Content/themes/base/jquery.ui.slider.css", "~/Content/themes/base/jquery.ui.tabs.css", "~/Content/themes/base/jquery.ui.datepicker.css", "~/Content/themes/base/jquery.ui.progressbar.css", "~/Content/themes/base/jquery.ui.theme.css"));
            bundles.Add(new ScriptBundle("~/bundles/InputMask").Include("~/Scripts/jquery.inputmask/inputmask.min.js").Include("~/Scripts/jquery.inputmask/jquery.inputmask.min.js").Include("~/Scripts/jquery.inputmask/inputmask.extensions.min.js")
                .Include("~/Scripts/jquery.inputmask/inputmask.numeric.extensions.min.js")
                .Include("~/Scripts/jquery.inputmask/inputmask.phone.extensions.min.js")
                .Include("~/Scripts/jquery.inputmask/inputmask.regex.extensions.min.js")
                .Include("~/Scripts/jquery.inputmask/inputmask.date.extensions.min.js"));
			bundles.Add(new ScriptBundle("~/bundles/summernote").Include("~/Scripts/summernote/summernote.min.js", "~/Scripts/summernote/lang/summernote-es-ES.js"));
			#region Proceso Clasificación

            bundles.Add(new ScriptBundle("~/Scripts/ClasificacionTramites/ClasificacionTramite")
                .Include("~/Ultimus.Framework/ClasificacionTramites/API.ClasificacionTramite.js")
                .Include("~/Ultimus.Framework/Ultimus.API.FuncionesGlobales.js")
                );
            bundles.Add(new ScriptBundle("~/Scripts/ClasificacionTramites/Seguimiento")
                .Include("~/Ultimus.Framework/ClasificacionTramites/API.Seguimiento.js")
                .Include("~/Ultimus.Framework/Ultimus.API.FuncionesGlobales.js")
                );
			#endregion

            #region Proceso Asesorias
            bundles.Add(new ScriptBundle("~/Scripts/AtencionTramitesAse/Aprobar")
                .Include("~/Ultimus.Framework/AtencionTramitesAse/API.Aprobar.js")
                .Include("~/Ultimus.Framework/Ultimus.API.FuncionesGlobales.js")
                );

            bundles.Add(new ScriptBundle("~/Scripts/AtencionTramitesAse/Archivar")
                .Include("~/Ultimus.Framework/AtencionTramitesAse/API.Archivar.js")
                .Include("~/Ultimus.Framework/Ultimus.API.FuncionesGlobales.js")
                );

            bundles.Add(new ScriptBundle("~/Scripts/AtencionTramitesAse/GenerarDocumento")
                .Include("~/Ultimus.Framework/AtencionTramitesAse/API.GenerarDocumento.js")
                .Include("~/Ultimus.Framework/Ultimus.API.FuncionesGlobales.js")
                );
			bundles.Add(new ScriptBundle("~/Scripts/AtencionTramitesAse/RevisionVistoBueno")
                .Include("~/Ultimus.Framework/AtencionTramitesAse/API.RevisionVistoBueno.js")
                .Include("~/Ultimus.Framework/Ultimus.API.FuncionesGlobales.js")
                );

            bundles.Add(new ScriptBundle("~/Scripts/AtencionTramitesAse/Seguimiento")
                .Include("~/Ultimus.Framework/AtencionTramitesAse/API.Seguimiento.js")
                .Include("~/Ultimus.Framework/Ultimus.API.FuncionesGlobales.js")
                );

            bundles.Add(new ScriptBundle("~/Scripts/AtencionTramitesAse/Verificar")
                .Include("~/Ultimus.Framework/AtencionTramitesAse/API.Verificar.js")
                .Include("~/Ultimus.Framework/Ultimus.API.FuncionesGlobales.js")
                );

            #endregion

            #region Proceso Solicitudes

            bundles.Add(new ScriptBundle("~/Scripts/AtencionTramitesSol/GestionPeticion")
                .Include("~/Ultimus.Framework/AtencionTramitesSol/API.GestionPeticion.js")
                .Include("~/Ultimus.Framework/Ultimus.API.FuncionesGlobales.js")
                );

            bundles.Add(new ScriptBundle("~/Scripts/AtencionTramitesSol/SeguimientoPeticion")
                .Include("~/Ultimus.Framework/AtencionTramitesSol/API.SeguimientoPeticion.js")
                .Include("~/Ultimus.Framework/Ultimus.API.FuncionesGlobales.js")
                );
             //borrar esta linea
            #endregion

            #region Proceso Quejas
            #endregion
        }
    }
}