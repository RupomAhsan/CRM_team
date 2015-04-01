using System.Data.Common;
using System.Data.Entity;
using Abp.EntityFramework;
using CRM_team.People;
using CRM_team.Tasks;
namespace CRM_team.EntityFramework
{
    public class CRM_teamDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...

        //Example:
        //public virtual IDbSet<User> Users { get; set; }
        public virtual IDbSet<Task> Tasks { get; set; }

        public virtual IDbSet<Person> People { get; set; }
        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public CRM_teamDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in CRM_teamDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of CRM_teamDbContext since ABP automatically handles it.
         */
        public CRM_teamDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }
    }
}
