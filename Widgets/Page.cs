using System;
using jquery.mobile.mvc.Core;

namespace jquery.mobile.mvc.Widgets
{
	public class Page : Widget<Page>
	{
		public Page()
			: base("div")
		{
			EnforceHtmlAttribute("data-role", "page");
		}

		public Page(String id)
			: base("div")
		{
			EnforceHtmlAttribute("id", id);
			EnforceHtmlAttribute("data-role", "page");
		}
	}
}
