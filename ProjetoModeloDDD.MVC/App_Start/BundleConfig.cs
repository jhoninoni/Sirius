using System.Web.Optimization;

namespace ProjetoModeloDDD.MVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/ui-grid.css",
                      "~/Content/csc.css",
                      "~/Content/plan.css",
                      "~/Content/site.css"));


            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                     "~/Scripts/angular/angular.min.js",
                     "~/Scripts/angular/angular-animate.min.js",
                     "~/Scripts/angular/angular-ui-router.min.js",
                     "~/Scripts/angular/angular-dragdrop.min.js",
                     "~/Scripts/angular-ui/ui-grid.min.js",
                     "~/Scripts/angular-ui/ui-bootstrap.min.js",
                     "~/Scripts/angular-ui/ui-bootstrap-tpls.min.js",
                     "~/Scripts/angular/i18n/angular-locale_pt-br.js",
                     "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/cscPlanejamento").Include(
                     "~/Content/app/appPlanejamento.js",
                     "~/Content/app/controllers/*.js",
                     "~/Content/app/lib/*.js",
                     "~/Content/app/conf/*.js"));

            bundles.Add(new ScriptBundle("~/bundles/bsSelect/js").Include(
                "~/Scripts/nya-bs-select/nya-bootstrap-select.js",
                "~/Scripts/nya-bs-select/nya-bs-public.js",
                "~/Scripts/nya-bs-select/nya-bs-select-ctrl.js",
                "~/Scripts/nya-bs-select/nya-bs-option.js",
                "~/Scripts/nya-bs-select/nya-bs-select.js",
                "~/Scripts/nya-bs-select/nya-bs-config.js"));


            bundles.Add(new StyleBundle("~/bundles/bsSelect/css").Include(
                    "~/Scripts/nya-bs-select/*.css"));


            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }
    }
}
