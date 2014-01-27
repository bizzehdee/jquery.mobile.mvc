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
using System.ComponentModel;
using System.Web.Mvc;

namespace jquery.mobile.mvc.Abstract
{
	/// <summary>
	/// Core HTML Element Class
	/// </summary>
	public abstract class Element
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected IDictionary<String, Object> HtmlAttributes;
		protected String Tag;
		protected String InnerTag;
		protected String ClassToEnsure;

		/// <summary>
		/// Construct a new Element instance with the <paramref name="tag"/> as the element name
		/// </summary>
		/// <param name="tag">Element name to use. e.g. div, ul, li, span, input</param>
		internal Element(String tag)
		{
			HtmlAttributes = new Dictionary<String, Object>();
			Tag = tag;
		}

		/// <summary>
		/// Construct a new Element instance with the <paramref name="tag"/> as the element name and <paramref name="innerTag"/> as the inner element name
		/// </summary>
		/// <param name="tag">Element name to use. e.g. div, ul, li, span, input</param>
		/// <param name="innerTag">Inner element name to use. e.g. div, ul, li, span, input</param>
		internal Element(String tag, String innerTag)
		{
			HtmlAttributes = new Dictionary<String, Object>();
			Tag = tag;
			InnerTag = innerTag;
		}

		/// <summary>
		/// Properly formatted end tag for this element
		/// </summary>
		internal String EndTag
		{
			get
			{
				if (!String.IsNullOrEmpty(InnerTag)) return String.Format("</{1}></{0}>", Tag, InnerTag);
				return String.IsNullOrEmpty(Tag) ? String.Empty : String.Format("</{0}>", Tag);
			}
		}

		/// <summary>
		/// Properly formatted start tag for this element with all attributes set
		/// </summary>
		internal virtual String StartTag
		{
			get
			{
				if (String.IsNullOrEmpty(Tag)) return String.Empty;

				TagBuilder builder = new TagBuilder(Tag);
				builder.MergeAttributes(HtmlAttributes);

				if (!String.IsNullOrEmpty(InnerTag)) return String.Format("{0}<{1}>", builder.ToString(TagRenderMode.StartTag), InnerTag);
				return builder.ToString(TagRenderMode.StartTag);
			}
		}

		/// <summary>
		/// Ensures that the class name <paramref name="className"/> is added to the element
		/// </summary>
		/// <param name="className">Class name to add to the element</param>
		protected void EnforceClass(String className)
		{
			if (HtmlAttributes.ContainsKey("class"))
			{
				String currentValue = HtmlAttributes["class"].ToString();
				if (!currentValue.Contains(className))
				{
					HtmlAttributes["class"] += " " + className;
				}
			}
			else
			{
				MergeHtmlAttribute("class", className);
			}
		}

		/// <summary>
		/// Ensures that the class <paramref name="className"/> is removed from the element
		/// </summary>
		/// <param name="className">Class name to remove</param>
		protected void EnforceClassRemoval(String className)
		{
			if (!HtmlAttributes.ContainsKey("class")) return;

			String currentValue = HtmlAttributes["class"].ToString();
			if (currentValue.Contains(className))
			{
				HtmlAttributes["class"] = currentValue.Replace(className, "").Replace("  ", "").Trim();
			}
		}

		/// <summary>
		/// Ensures the HTML attribute <paramref name="key"/> is added to the element with the value of <paramref name="value"/>
		/// </summary>
		/// <param name="key">HTML attribute to add</param>
		/// <param name="value">HTML attribute value</param>
		/// <param name="replaceExisting">Whether or not to replace any existing attributes of the same name</param>
		protected void EnforceHtmlAttribute(String key, String value, Boolean replaceExisting = true)
		{
			if (HtmlAttributes.ContainsKey(key))
			{
				if (replaceExisting)
				{
					HtmlAttributes[key] = value;
				}
				else
				{
					HtmlAttributes[key] += " " + value;
				}
			}
			else
			{
				HtmlAttributes.Add(key, value);
			}
		}

		/// <summary>
		/// Ensures the HTML attribute <paramref name="key"/> is removed from the element
		/// </summary>
		/// <param name="key">HTML attribute to remove</param>
		protected void EnforceHtmlAttributeRemoval(String key)
		{
			if (HtmlAttributes.ContainsKey(key))
			{
				HtmlAttributes.Remove(key);
			}
		}

		private void MergeHtmlAttribute(String key, String value)
		{
			if (HtmlAttributes != null)
			{
				if (HtmlAttributes.ContainsKey(key))
				{
					HtmlAttributes[key] = value;
				}
				else
				{
					HtmlAttributes.Add(key, value);
				}
			}
			else
			{
				HtmlAttributes = new Dictionary<String, Object>
				{
					{key, value}
				};
			}

			if (!String.IsNullOrEmpty(ClassToEnsure)) EnforceClass(ClassToEnsure);
		}
	}
}
