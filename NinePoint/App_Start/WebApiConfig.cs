using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using NinePoint.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace NinePoint
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            //config.MapODataServiceRoute("son-vh", "odata", model: GetModel());
            /* now the default setting for WebAPI OData is:
            client can’t apply $count, $orderby, $select, $top, $expand, $filter in the query, query
            like localhost\odata\Customers?$orderby=Name will failed as BadRequest,
            because all properties are not sort-able by default, this is a breaking change in 6.0.0
            So, we now need to enable OData Model Bound Attributes
            */
            //config.Count().Filter().OrderBy().Expand().Select().MaxTop(null);

            config.MapODataServiceRoute(
            routeName: "ODataRoute",
            routePrefix: null,
            model: GetModel());
        }

        public static Microsoft.OData.Edm.IEdmModel GetModel()
        {
            ODataModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Equipment>("Equipment");
            builder.EntitySet<Resident>("Resident");
            builder.EntitySet<JobInfo>("JobInfo");
            builder.EntitySet<Support>("Support");
            builder.EntitySet<John>("John");

            builder.Function("GetEquipmentByResident")
            .Returns<double>()
            .Parameter<int>("Id");

            builder.Function("FindResidentBySupport")
           .Returns<double>();


            builder.Function("FindSupportById")
            .Returns<double>()
            .Parameter<int>("Id");

      

            //builder.Namespace = "EquipmentService";
            //builder.EntityType<Equipment>().Collection
            //    .Function("MostExpensive")
            //    .Returns<double>();

            //builder.Namespace = "ProductService";
            //builder.EntityType<Equipment>().Collection
            //    .Function("Rate")
            //    .Returns<IQueryable>();

            //builder.Function("GetSalesTaxRate")
            //.Returns<IQueryable<Equipment>>()
            //.Parameter<int>("PostalCode");

            //builder.Namespace = "ProductService";
            //builder.EntityType<Product>().Collection
            //    .Function("MostExpensive")
            //    .Returns<double>();

            return builder.GetEdmModel();
        }
    }
   
}
