using System;
using jquery.mobile.mvc.Core;

namespace jquery.mobile.mvc.Widgets
{
	public class Form : Widget<Form>
	{
		public enum FormMethod
		{
			Get,
			Post
		}

		public Form()
			: base("form")
		{

		}

		public Form Action(String action)
		{
			EnforceHtmlAttribute("action", action);

			return this;
		}

		public Form Method(FormMethod method)
		{
			switch (method)
			{
				case FormMethod.Get:
					EnforceHtmlAttribute("action", "get");
					break;
				case FormMethod.Post:
					EnforceHtmlAttribute("action", "post");
					break;
			}

			return this;
		}
	}
}
