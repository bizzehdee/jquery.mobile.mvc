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
using System.ComponentModel;
using System.IO;
using System.Web.Mvc;
using jquery.mobile.mvc.Core;

namespace jquery.mobile.mvc.Abstract
{
	public abstract class Builder<TModel, T> : IDisposable where T : Widget<T>
	{
		private bool _disposed = false;

		protected readonly T Element;

		protected readonly TextWriter TextWriter;
		protected readonly HtmlHelper<TModel> HtmlHelper;
		protected readonly AjaxHelper<TModel> AjaxHelper;

		internal Builder(HtmlHelper<TModel> htmlHelper, T element)
        {
			if (element == null)
            {
				throw new ArgumentNullException("element");
            }

			Element = element;
			HtmlHelper = htmlHelper;
            TextWriter = HtmlHelper.ViewContext.Writer;
			TextWriter.WriteLine(Element.StartTag);
        }

		internal Builder(AjaxHelper<TModel> ajaxHelper, T element)
        {
			if (element == null)
            {
				throw new ArgumentNullException("element");
            }

			Element = element;
			AjaxHelper = ajaxHelper;
            TextWriter = AjaxHelper.ViewContext.Writer;
			TextWriter.WriteLine(Element.StartTag);
        }

		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		protected virtual void Dispose(bool disposing)
		{
			if (_disposed) return;

			if (disposing)
			{
				TextWriter.WriteLine(Element.EndTag);
				TextWriter.WriteLine();
			}

			_disposed = true;
		}
	}
}
