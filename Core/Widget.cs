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
	/// <summary>
	///     Widget base class
	/// </summary>
	/// <typeparam name="T">Widget class that implements Widget</typeparam>
	public class Widget<T> : Element, IWidget<T> where T : Widget<T>
	{
		#region 

		private const String ClassShaddow = "ui-shadow";
		private const String ClassCorner = "ui-corner-all";
		private const String ClassBtnIconLeft = "ui-btn-icon-left";
		private const String ClassBtnIconRight = "ui-btn-icon-right";
		private const String ClassBtnIconTop = "ui-btn-icon-top";
		private const String ClassBtnIconBottom = "ui-btn-icon-bottom";
		private const String ClassBtnIconNoText = "ui-btn-icon-notext";
		private const String ClassIconPrefix = "ui-icon-";

		#endregion

		private String _innerHtml;

		/// <summary>
		///     Constructor for single element widget
		/// </summary>
		/// <param name="tag">Tag name</param>
		public Widget(String tag)
			: base(tag)
		{
			_innerHtml = "";
		}

		/// <summary>
		///     Constructor for double element widget
		/// </summary>
		/// <param name="tag">outer tag name</param>
		/// <param name="innerTag">inner tag name</param>
		public Widget(String tag, String innerTag)
			: base(tag, innerTag)
		{
			_innerHtml = "";
		}

		/// <summary>
		///     Sets the id attribute within the html element
		/// </summary>
		/// <param name="id">id value</param>
		/// <returns>this (fluent)</returns>
		public T Id(String id)
		{
			EnforceHtmlAttribute("id", id);
			return (T) this;
		}

		/// <summary>
		///     Sets a data- prefixed key with a given value
		/// </summary>
		/// <param name="key">key to append to data- attribute</param>
		/// <param name="val">value of data-key</param>
		/// <returns>this (fluent)</returns>
		public T Data(String key, String val)
		{
			EnforceHtmlAttribute(String.Format("data-{0}", key), val);

			return (T) this;
		}

		/// <summary>
		///     Sets the theme character to use
		/// </summary>
		/// <param name="theme">theme character</param>
		/// <returns>this (fluent)</returns>
		public virtual T Theme(Char theme)
		{
			return Data("theme", String.Format("{0}", theme));
		}

		/// <summary>
		///     Sets the data role of the html element
		/// </summary>
		/// <param name="role">data-role to set</param>
		/// <returns>this (fluent)</returns>
		public virtual T Role(String role)
		{
			return Data("role", role);
		}

		/// <summary>
		///     Sets the html elements icon and icon position
		/// </summary>
		/// <param name="icon">Icon to use</param>
		/// <param name="position">Icon position</param>
		/// <returns>this (fluent)</returns>
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

			return (T) this;
		}

		/// <summary>
		///     Adds a class name to the html element's class attribute
		/// </summary>
		/// <param name="className">class name to add</param>
		/// <returns>this (fluent)</returns>
		public T AddClass(String className)
		{
			EnforceClass(className);
			return (T) this;
		}

		/// <summary>
		///     Removes a class name from the html elements class attribute
		/// </summary>
		/// <param name="className">class name to remove</param>
		/// <returns>this (fluent)</returns>
		public T RemoveClass(String className)
		{
			EnforceClassRemoval(className);
			return (T) this;
		}

		/// <summary>
		///     Sets the inner html of the html element
		/// </summary>
		/// <param name="innerHtml">inner html or text to set</param>
		/// <returns>this (fluent)</returns>
		public T InnerHtml(String innerHtml)
		{
			_innerHtml = innerHtml;

			return (T) this;
		}

		public virtual String ToHtmlString()
		{
			return String.Format("{0}{1}{2}", StartTag, _innerHtml, EndTag);
		}

		/// <summary>
		///     Sets a data- prefixed key with a given value
		/// </summary>
		/// <param name="pair">key to append to data- attribute, value set as value of data-key</param>
		/// <returns>this (fluent)</returns>
		public T Data(KeyValuePair<String, String> pair)
		{
			EnforceHtmlAttribute(String.Format("data-{0}", pair.Key), pair.Value);

			return (T) this;
		}

		/// <summary>
		///     Sets the html element to render using mini mode
		/// </summary>
		/// <param name="on">true = mini, false = regular</param>
		/// <returns>this (fluent)</returns>
		public T Mini(Boolean on)
		{
			on.If(() => Data("mini", "true"), () => Data("mini", "false"));

			return (T) this;
		}

		/// <summary>
		///     Sets the data-role within the html element to none, forcing no enhancements to be rendered
		/// </summary>
		/// <returns>this (fluent)</returns>
		public T Native()
		{
			return Role("none");
		}

		/// <summary>
		/// </summary>
		/// <param name="disable"></param>
		/// <returns>this (fluent)</returns>
		public T Disable(Boolean disable)
		{
			disable.If(() => EnforceHtmlAttribute("disabled", "disabled"), () => EnforceHtmlAttributeRemoval("disabled"));

			return (T) this;
		}

		/// <summary>
		///     Sets the html elements corners to be rounded
		/// </summary>
		/// <param name="on">true = rounded, false = non-rounded</param>
		/// <returns>this (fluent)</returns>
		public T Corners(Boolean on)
		{
			on.If(() => AddClass(ClassCorner), () => RemoveClass(ClassCorner));

			return (T) this;
		}

		/// <summary>
		///     Switches the html elements drop shadow on or off
		/// </summary>
		/// <param name="on">true = on, false = off</param>
		/// <returns>this (fluent)</returns>
		public T Shadow(Boolean on)
		{
			on.If(() => AddClass(ClassShaddow), () => RemoveClass(ClassShaddow));

			return (T) this;
		}

		/// <summary>
		///     Adds a html attribute to the html element of name <paramref name="attribute" /> and value of
		///     <paramref name="value" />
		/// </summary>
		/// <param name="attribute">Attribute name</param>
		/// <param name="value">Attribute value</param>
		/// <returns>this (fluent)</returns>
		public T AddAttribute(String attribute, String value)
		{
			EnforceHtmlAttribute(attribute, value);
			return (T) this;
		}

		/// <summary>
		///     Removes a html attribute from the html element of name <paramref name="attribute" />
		/// </summary>
		/// <param name="attribute">Attribute name</param>
		/// <returns>this (fluent)</returns>
		public T RemoveAttribute(String attribute)
		{
			EnforceHtmlAttributeRemoval(attribute);
			return (T) this;
		}
	}
}