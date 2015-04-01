using System.Reflection;
using Abp.Modules;

namespace CRM_team
{
    public class CRM_teamCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
