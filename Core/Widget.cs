using System;
using jquery.mobile.mvc.Abstract;
using jquery.mobile.mvc.Interfaces;

namespace jquery.mobile.mvc.Core
{
	public class Widget<T> : Element, IWidget<T> where T : Widget<T>
	{
		private String _innerHtml;

		public Widget(string _tag) 
			: base(_tag)
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

		public T Theme(String theme)
		{
			return Data("theme", theme);
		}

		public T Role(String role)
		{
			return Data("role", role);
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

		public T Icon(String iconName, bool noText = false)
		{
			AddClass(String.Format("ui-icon-{0}", iconName));
			if (noText) AddClass("ui-btn-icon-notext");
			return (T) this;
		}

		public string ToHtmlString()
		{
			return StartTag + _innerHtml + EndTag;
		}
	}
}
