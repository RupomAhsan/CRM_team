using Abp.Web.Mvc.Views;

namespace CRM_team.Web.Views
{
    public abstract class CRM_teamWebViewPageBase : CRM_teamWebViewPageBase<dynamic>
    {

    }

    public abstract class CRM_teamWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected CRM_teamWebViewPageBase()
        {
            LocalizationSourceName = "CRM_team";//CRM_teamConsts.LocalizationSourceName;
        }
    }
}