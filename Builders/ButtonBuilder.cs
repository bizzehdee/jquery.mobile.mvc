using System.Web.Mvc;
using jquery.mobile.mvc.Abstract;
using jquery.mobile.mvc.Widgets;

namespace jquery.mobile.mvc.Builders
{
	public class ButtonBuilder<TModel> : Builder<TModel, Button>
	{
		public ButtonBuilder(HtmlHelper<TModel> _htmlHelper, Button _element) 
			: base(_htmlHelper, _element)
		{

		}
	}
}
