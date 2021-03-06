﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using BundleTransformer.Core.Builders;
using BundleTransformer.Core.Orderers;
using BundleTransformer.Core.Resolvers;
using BundleTransformer.Core.Transformers;

namespace LiquorAdda.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBunldes(BundleCollection bundles)
        {
            //This setting is used when if you have specfied the path Using System.web.Optimization.bundle.Cdnpath then it will try to fetch data from there first
            bundles.UseCdn = true;

            //NullBuilder class is responsible for prevention of early applying of the item transformations and combining of code.
            var nullBuilder = new NullBuilder();

            //StyleTransformer and ScriptTransformer classes produce processing of stylesheets and scripts.
            var styleTransformer = new StyleTransformer();
            var scriptTransformer = new ScriptTransformer();

            //NullOrderer class disables the built-in sorting mechanism and save assets sorted in the order they are declared.
            var nullOrderer = new NullOrderer();

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/DataTables/jquery.dataTables.min.js",
                        "~/Scripts/DataTables/dataTables.bootstrap.min.js",
                        "~/Scripts/jquery-ui-1.11.3.min.js")
                        
                        );

            bundles.Add(new ScriptBundle("~/bundles/Template").Include(
                        "~/Scripts/Template/lib/easing/easing.min.js",
                        "~/Scripts/Template/lib/mobile-nav/mobile-nav.js",
                        "~/Scripts/Template/lib/wow/wow.min.js",
                        "~/Scripts/Template/lib/waypoints/waypoints.min.js",
                        "~/Scripts/Template/lib/counterup/counterup.min.js",
                        "~/Scripts/Template/lib/owlcarousel/owl.carousel.min.js",
                        "~/Scripts/Template/lib/isotope/isotope.pkgd.min.js",
                        "~/Scripts/Template/lib/lightbox/js/lightbox.min.js",
                        "~/Scripts/Template/lib/main.js"));

            //--- Images not loading ---// to be resolved
            //bundles.Add(new StyleBundle("~/Content/Css").Include(
            //            "~/Scripts/Template/lib/font-awesome/css/font-awesome.min.css",
            //            "~/Scripts/Template/lib/animate/animate.min.css",
            //            "~/Scripts/Template/lib/ionicons/css/ionicons.min.css",
            //            "~/Scripts/Template/lib/owlcarousel/assets/owl.carousel.min.css",
            //            "~/Scripts/Template/lib/lightbox/css/*.min.css",
            //            "~/Scripts/Template/lib/style.css"
            //           ));

            //bundles.Add(new StyleBundle("~/Content/MainCss").Include(
            //            "~/Content/bootstrap.min.css",
            //            "~/Content/Site.css",
            //            "~/Content/DataTables/css/dataTables.bootstrap.min.css"));

            foreach (var item in bundles)
            {
                item.Builder = nullBuilder;
                item.Transforms.Add(scriptTransformer);
                item.Orderer = nullOrderer;
            }

            BundleTable.EnableOptimizations = true;
        }
    }
}