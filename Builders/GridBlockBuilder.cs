using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using jquery.mobile.mvc.Abstract;
using jquery.mobile.mvc.Widgets;

namespace jquery.mobile.mvc.Builders
{
	public class GridBlockBuilder<TModel> : Builder<TModel, GridBlock>
	{
		public GridBlockBuilder(HtmlHelper<TModel> _htmlHelper, GridBlock _element) 
			: base(_htmlHelper, _element)
		{

		}
	}
}
