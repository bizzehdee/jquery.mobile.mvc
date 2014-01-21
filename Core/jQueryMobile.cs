using System.Web.Mvc;

namespace jquery.mobile.mvc.Core
{
	public partial class jQueryMobile<TModel>
	{
		public HtmlHelper<TModel> Html;
		public AjaxHelper<TModel> Ajax;

		public jQueryMobile(HtmlHelper<TModel> _html)
		{
			Html = _html;
		}

		public jQueryMobile(AjaxHelper<TModel> _ajax)
		{
			Ajax = _ajax;
		}
	}
}
