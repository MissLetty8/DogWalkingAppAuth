using System.Web;
using System.Web.Optimization;

namespace DogWalkingAppAuth
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/assets/vendor/countTo/jquery.countTo.js",
                "~/assets/vendor/lightcase/lightcase.js",
                 "~/assets/vendor/stellar/jquery.stellar.js",
                 "~/assets/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));


            bundles.Add(new ScriptBundle("~/assets/vendor").Include(
                      "~/assets/vendor/bootstrap/bootstrap.min.js",
                      "~/assets/vendor/bootstrap/popper.min.js",
                     
                      
                      "~/assets/vendor/isotope/isotope.min.js",
                      
                      "~/assets/vendor/owlcarousel/owl.carousel.min.js",
                      "~/assets/vendor/select2/select2.min.js",
                      
                     
                      "~/assets/vendor/waypoints/waypoint.min.js"));

            bundles.Add(new StyleBundle("~/assets/css").Include(
                      "~/assets/vendor/bootstrap/bootstrap.min.css",
                      "~/assets/vendor/lightcase/lightcase.css",
                      "~/assets/vendor/owlcarousel/owl.carousel.min.css",
                      "~/assets/vendor/select2/select2.min.css"));


         

        }
    }
}
