using System.Web.Mvc;
using jquery.mobile.mvc.Core;

namespace jquery.mobile.mvc
{
    public static class jQueryMobileHtmlExtensions
    {
		public static jQueryMobile<TModel> jQueryMobile<TModel>(this HtmlHelper<TModel> helper)
		{
			return new jQueryMobile<TModel>(helper);
		}

		public static jQueryMobile<TModel> jQueryMobile<TModel>(this AjaxHelper<TModel> helper)
		{
			return new jQueryMobile<TModel>(helper);
		}

		public static jQueryMobile<TModel> jQM<TModel>(this HtmlHelper<TModel> helper)
		{
			return jQueryMobile(helper);
		}

		public static jQueryMobile<TModel> jQM<TModel>(this AjaxHelper<TModel> helper)
		{
			return jQueryMobile(helper);
		}
    }
}
