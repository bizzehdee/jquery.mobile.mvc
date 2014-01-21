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
