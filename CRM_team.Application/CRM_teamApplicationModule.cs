using System.Reflection;
using Abp.Modules;

namespace CRM_team
{
    [DependsOn(typeof(CRM_teamCoreModule))]
    public class CRM_teamApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            //This code is used to register classes to dependency injection system for this assembly using conventions.
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            //We must declare mappings to be able to use AutoMapper
            DtoMappings.Map();
        }
    }
}
