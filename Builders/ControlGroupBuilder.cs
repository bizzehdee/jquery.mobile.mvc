using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using jquery.mobile.mvc.Abstract;
using jquery.mobile.mvc.Widgets;

namespace jquery.mobile.mvc.Builders
{
	public class ControlGroupBuilder<TModel> : Builder<TModel, ControlGroup>
	{
		public ControlGroupBuilder(HtmlHelper<TModel> _htmlHelper, ControlGroup _element) 
			: base(_htmlHelper, _element)
		{

		}

		public ControlGroupBuilder<TModel> Mini()
		{
			element.Mini();
			return this;
		}

		public ControlGroupBuilder<TModel> Horizontal()
		{
			element.Horizontal();
			return this;
		}
	}
}
