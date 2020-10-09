using Abp.Web.Mvc.Views;

namespace CurseDotNet.Class2.Web.Views
{
    public abstract class Class2WebViewPageBase : Class2WebViewPageBase<dynamic>
    {

    }

    public abstract class Class2WebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected Class2WebViewPageBase()
        {
            LocalizationSourceName = Class2Consts.LocalizationSourceName;
        }
    }
}