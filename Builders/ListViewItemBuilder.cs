using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using jquery.mobile.mvc.Abstract;
using jquery.mobile.mvc.Widgets;

namespace jquery.mobile.mvc.Builders
{
	public class ListViewItemBuilder<TModel> : Builder<TModel, ListViewItem>
	{
		public ListViewItemBuilder(HtmlHelper<TModel> htmlHelper, ListViewItem element) 
			: base(htmlHelper, element)
		{

		}
	}
}
