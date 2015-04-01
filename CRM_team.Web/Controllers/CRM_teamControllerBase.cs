using Abp.Web.Mvc.Controllers;

namespace CRM_team.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class CRM_teamControllerBase : AbpController
    {
        protected CRM_teamControllerBase()
        {
            LocalizationSourceName = "CRM_team";//CRM_teamConsts.LocalizationSourceName;
        }
    }
}