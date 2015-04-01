using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using CRM_team.EntityFramework;

namespace CRM_team
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(CRM_teamCoreModule))]
    public class CRM_teamDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            //Database.SetInitializer<CRM_teamDbContext>(null);
        }
    }
}
