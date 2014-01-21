using System;
using jquery.mobile.mvc.Core;

namespace jquery.mobile.mvc.Widgets
{
	public class Button : Widget<Button>
	{
		public enum ButtonType
		{
			Button,
			Submit,
			Link
		}

		public Button(ButtonType type = ButtonType.Button)
			: base(GetButtonType(type))
		{
			EnforceClass("ui-btn");
			if (type == ButtonType.Submit)
			{
				EnforceHtmlAttribute("type", "submit");
			}
		}

		public Button Href(String href)
		{
			EnforceHtmlAttribute("href", href);

			return this;
		}

		private static String GetButtonType(ButtonType type)
		{
			switch (type)
			{
				case ButtonType.Submit:
					return "input";
				case ButtonType.Link:
					return "a";
				default:
					return "button";
			}
		}
	}
}
