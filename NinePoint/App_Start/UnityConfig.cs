using NinePoint.Services;
using NinePoint.UnitOfWork;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace NinePoint
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            container.RegisterType<IEquipmentService, EquipmentService>();
            container.RegisterType<IResidentService, ResidentService>();
            container.RegisterType<IJobInfoService, JobInfoService>();
            container.RegisterType<ISupportService, SupportService>();

            container.RegisterType<IUnitOfWork, UnitOfWork.UnitOfWork>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}