/*
Copyright (c) 2014 Darren Horrocks

Permission is hereby granted, free of charge, to any person obtaining a copy of
this software and associated documentation files (the "Software"), to deal in
the Software without restriction, including without limitation the rights to
use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
the Software, and to permit persons to whom the Software is furnished to do so,
subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE. 
*/
using System;
using System.Collections.Generic;
using jquery.mobile.mvc.Abstract;
using jquery.mobile.mvc.Interfaces;

namespace jquery.mobile.mvc.Core
{
	public class Widget<T> : Element, IWidget<T> where T : Widget<T>
	{
		private String _innerHtml;

		public Widget(string tag)
			: base(tag)
		{
			_innerHtml = "";
		}

		public Widget(string tag, string innerTag)
			: base(tag, innerTag)
		{
			_innerHtml = "";
		}

		public T Id(String id)
		{
			EnforceHtmlAttribute("id", id);
			return (T)this;
		}

		public T Data(string key, string val)
		{
			EnforceHtmlAttribute(String.Format("data-{0}", key), val);

			return (T)this;
		}

		public T Data(KeyValuePair<String, String> pair)
		{
			EnforceHtmlAttribute(String.Format("data-{0}", pair.Key), pair.Value);

			return (T)this;
		}

		public T Theme(String theme)
		{
			return Data("theme", theme);
		}

		public T Role(String role)
		{
			return Data("role", role);
		}

		public T Mini(bool on)
		{
			return Data("mini", on ? "true" : "false");
		}

		public T Native()
		{
			return Role("none");
		}

		public T Disable(bool disable)
		{
			if (disable)
			{
				EnforceHtmlAttribute("disabled", "disabled");
			}
			else
			{
				EnforceHtmlAttributeRemoval("disabled");
			}

			return (T)this;
		}

		public T Corners(bool on)
		{
			return on ? AddClass("ui-corner-all") : RemoveClass("ui-corner-all");
		}

		public T Icon(Icon.IconType icon, Icon.IconPosition position)
		{
			Data("icon", Core.Icon.IconTypeToString(icon));
			AddClass(String.Format("ui-icon-{0}", Core.Icon.IconTypeToString(icon)));

			switch (position)
			{
				case Core.Icon.IconPosition.Left:
					AddClass("ui-btn-icon-left");
					break;
				case Core.Icon.IconPosition.Right:
					AddClass("ui-btn-icon-right");
					break;
				case Core.Icon.IconPosition.Top:
					AddClass("ui-btn-icon-top");
					break;
				case Core.Icon.IconPosition.Bottom:
					AddClass("ui-btn-icon-bottom");
					break;
				case Core.Icon.IconPosition.NoText:
					AddClass("ui-btn-icon-notext");
					break;
			}

			return (T)this;
		}

		public T Shadow(bool on)
		{
			return on ? AddClass("ui-shadow") : RemoveClass("ui-shadow");
		}

		public T AddClass(String className)
		{
			EnforceClass(className);
			return (T)this;
		}

		public T RemoveClass(String className)
		{
			EnforceClassRemoval(className);
			return (T)this;
		}

		public T InnerHtml(string innerHtml)
		{
			_innerHtml = innerHtml;

			return (T)this;
		}

		public string ToHtmlString()
		{
			return StartTag + _innerHtml + EndTag;
		}
	}
}
