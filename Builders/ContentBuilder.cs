using System.Web.Mvc;
using jquery.mobile.mvc.Abstract;
using jquery.mobile.mvc.Widgets;

namespace jquery.mobile.mvc.Builders
{
	public class ContentBuilder<TModel> : Builder<TModel, Content>
	{
		internal ContentBuilder(HtmlHelper<TModel> htmlHelper, Content content)
			: base(htmlHelper, content)
		{
			
		}
	}
}
