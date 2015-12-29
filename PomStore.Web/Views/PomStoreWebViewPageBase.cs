using Abp.Web.Mvc.Views;

namespace PomStore.Web.Views
{
    public abstract class PomStoreWebViewPageBase : PomStoreWebViewPageBase<dynamic>
    {

    }

    public abstract class PomStoreWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected PomStoreWebViewPageBase()
        {
            LocalizationSourceName = PomStoreConsts.LocalizationSourceName;
        }
    }
}