using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace CRM_team
{
    [DependsOn(typeof(AbpWebApiModule), typeof(CRM_teamApplicationModule))]
    public class CRM_teamWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(CRM_teamApplicationModule).Assembly, "tasksystem")
                .Build();
        }
    }
}
