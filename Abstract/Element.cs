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
	public abstract class Element
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IDictionary<String, Object> htmlAttributes;
		protected String tag;
		protected String classToEnsure;

		internal Element(String _tag)
        {
            htmlAttributes = new Dictionary<String, Object>();
            tag = _tag;
        }

		internal String EndTag
		{
			get
			{
				return String.IsNullOrEmpty(tag) ? String.Empty : String.Format("</{0}>", tag);
			}
		}

		internal virtual String StartTag
		{
			get
			{
				if (String.IsNullOrEmpty(tag)) return String.Empty;

				TagBuilder builder = new TagBuilder(tag);
				builder.MergeAttributes(htmlAttributes);

				return builder.ToString(TagRenderMode.StartTag);
			}
		}

		protected void MergeHtmlAttribute(String key, String value)
		{
			if (htmlAttributes != null)
			{
				if (htmlAttributes.ContainsKey(key))
				{
					htmlAttributes[key] = value;
				}
				else
				{
					htmlAttributes.Add(key, value);
				}
			}
			else
			{
				htmlAttributes = new Dictionary<String, Object>
				{
					{key, value}
				};
			}

			if (!String.IsNullOrEmpty(classToEnsure)) EnforceClass(classToEnsure);
		}

		protected void EnforceClass(String className)
		{
			if (htmlAttributes.ContainsKey("class"))
			{
				String currentValue = htmlAttributes["class"].ToString();
				if (!currentValue.Contains(className))
				{
					htmlAttributes["class"] += " " + className;
				}
			}
			else
			{
				MergeHtmlAttribute("class", className);
			}
		}

		protected void EnforceClassRemoval(String className)
		{
			if (!htmlAttributes.ContainsKey("class")) return;

			String currentValue = htmlAttributes["class"].ToString();
			if (currentValue.Contains(className))
			{
				htmlAttributes["class"] = currentValue.Replace(className, "").Replace("  ", "").Trim();
			}
		}

		protected void EnforceHtmlAttribute(String key, String value, Boolean replaceExisting = true)
		{
			if (htmlAttributes.ContainsKey(key))
			{
				if (replaceExisting)
				{
					htmlAttributes[key] = value;
				}
				else
				{
					htmlAttributes[key] += " " + value;
				}
			}
			else
			{
				htmlAttributes.Add(key, value);
			}
		}
	}
}
