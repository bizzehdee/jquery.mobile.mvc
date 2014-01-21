using System;
using System.ComponentModel;
using System.IO;
using System.Web.Mvc;
using jquery.mobile.mvc.Core;

namespace jquery.mobile.mvc.Abstract
{
	public abstract class Builder<TModel, T> : IDisposable where T : Widget<T>
	{
		protected readonly T element;

		protected readonly TextWriter textWriter;
		protected readonly HtmlHelper<TModel> htmlHelper;
		protected readonly AjaxHelper<TModel> ajaxHelper;

		internal Builder(HtmlHelper<TModel> _htmlHelper, T _element)
        {
			if (_element == null)
            {
				throw new ArgumentNullException("_element");
            }

			element = _element;
			htmlHelper = _htmlHelper;
            textWriter = htmlHelper.ViewContext.Writer;
			textWriter.WriteLine(element.StartTag);
        }

		internal Builder(AjaxHelper<TModel> _ajaxHelper, T _element)
        {
			if (_element == null)
            {
				throw new ArgumentNullException("_element");
            }

			element = _element;
			ajaxHelper = _ajaxHelper;
            textWriter = ajaxHelper.ViewContext.Writer;
			textWriter.WriteLine(element.StartTag);
        }

		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual void Dispose()
		{
			textWriter.WriteLine(element.EndTag);
			textWriter.WriteLine();
		}
	}
}
