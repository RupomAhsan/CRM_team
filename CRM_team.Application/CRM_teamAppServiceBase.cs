using Abp.Application.Services;

namespace CRM_team
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class CRM_teamAppServiceBase : ApplicationService
    {
        protected CRM_teamAppServiceBase()
        {
            LocalizationSourceName = CRM_teamConsts.LocalizationSourceName;
        }
    }
}