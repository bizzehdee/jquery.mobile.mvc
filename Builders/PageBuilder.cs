using System;
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
			return new ContentBuilder<TModel>(htmlHelper, new Content(type));
		}

		public ContentBuilder<TModel> BeginHeader()
		{
			return Begin(Content.ContentType.Header);
		}

		public ContentBuilder<TModel> BeginContent()
		{
			return Begin(Content.ContentType.Content);
		}

		public ContentBuilder<TModel> BeginFooter()
		{
			return Begin(Content.ContentType.Footer);
		}

		public PageBuilder<TModel> Theme(String theme)
		{

			return this;
		}
	}
}
