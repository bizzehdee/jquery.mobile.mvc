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

		private const String ClassShaddow = "ui-shadow";
		private const String ClassCorner = "ui-corner-all";
		private const String ClassBtnIconLeft = "ui-btn-icon-left";
		private const String ClassBtnIconRight = "ui-btn-icon-right";
		private const String ClassBtnIconTop = "ui-btn-icon-top";
		private const String ClassBtnIconBottom = "ui-btn-icon-bottom";
		private const String ClassBtnIconNoText = "ui-btn-icon-notext";
		private const String ClassIconPrefix = "ui-icon-";

		public Widget(String tag)
			: base(tag)
		{
			_innerHtml = "";
		}

		public Widget(String tag, String innerTag)
			: base(tag, innerTag)
		{
			_innerHtml = "";
		}

		public T Id(String id)
		{
			EnforceHtmlAttribute("id", id);
			return (T)this;
		}

		public T Data(String key, String val)
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

		public T Mini(Boolean on)
		{
			on.If(() => Data("mini", "true"), () => Data("mini", "false"));

			return (T)this;
		}

		public T Native()
		{
			return Role("none");
		}

		public T Disable(Boolean disable)
		{
			disable.If(() => EnforceHtmlAttribute("disabled", "disabled"), () => EnforceHtmlAttributeRemoval("disabled"));

			return (T)this;
		}

		public T Corners(Boolean on)
		{
			on.If(() => AddClass(ClassCorner), () => RemoveClass(ClassCorner));

			return (T)this;
		}



		public T Icon(Icon.IconType icon, Icon.IconPosition position)
		{
			Data("icon", Misc.GetEnumDescription(icon));
			AddClass(String.Format("{0}{1}", ClassIconPrefix, Misc.GetEnumDescription(icon)));

			switch (position)
			{
				case Core.Icon.IconPosition.Left:
					AddClass(ClassBtnIconLeft);
					break;
				case Core.Icon.IconPosition.Right:
					AddClass(ClassBtnIconRight);
					break;
				case Core.Icon.IconPosition.Top:
					AddClass(ClassBtnIconTop);
					break;
				case Core.Icon.IconPosition.Bottom:
					AddClass(ClassBtnIconBottom);
					break;
				case Core.Icon.IconPosition.NoText:
					AddClass(ClassBtnIconNoText);
					break;
			}

			return (T)this;
		}

		public T Shadow(Boolean on)
		{
			on.If(() => AddClass(ClassShaddow), () => RemoveClass(ClassShaddow));

			return (T)this;
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

		public T InnerHtml(String innerHtml)
		{
			_innerHtml = innerHtml;

			return (T)this;
		}

		public virtual String ToHtmlString()
		{
			return String.Format("{0}{1}{2}", StartTag, _innerHtml, EndTag);
		}
	}
}
