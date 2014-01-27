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
using System.Web.Mvc;
using jquery.mobile.mvc.Abstract;
using jquery.mobile.mvc.Widgets;

namespace jquery.mobile.mvc.Builders
{
	public class PageBuilder<TModel> : Builder<TModel, Page>
	{
		internal PageBuilder(HtmlHelper<TModel> htmlHelper, Page page)
			: base(htmlHelper, page)
		{
			
		}

		public ContentBuilder<TModel> Begin(Content.ContentType type)
		{
			return new ContentBuilder<TModel>(HtmlHelper, new Content(type));
		}

		public ToolbarBuilder<TModel> Begin(Toolbar toolbar)
		{
			return new ToolbarBuilder<TModel>(HtmlHelper, toolbar);
		}

		public ToolbarBuilder<TModel> BeginHeader()
		{
			return new ToolbarBuilder<TModel>(HtmlHelper, new Toolbar().Role("header"));
		}

		public ContentBuilder<TModel> BeginContent()
		{
			return Begin(Content.ContentType.Content);
		}

		public ToolbarBuilder<TModel> BeginFooter()
		{
			return new ToolbarBuilder<TModel>(HtmlHelper, new Toolbar().Role("footer"));
		}
	}
}
