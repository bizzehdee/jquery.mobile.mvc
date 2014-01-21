using System;
using jquery.mobile.mvc.Builders;
using jquery.mobile.mvc.Widgets;

namespace jquery.mobile.mvc.Core
{
	public partial class jQueryMobile<TModel>
	{
		public PageBuilder<TModel> Begin(Page page)
		{
			return new PageBuilder<TModel>(Html, page);
		}

		public PageBuilder<TModel> BeginPage(String id)
		{
			return new PageBuilder<TModel>(Html, new Page(id));
		}

		public FormBuilder<TModel> Begin(Form form)
		{
			return new FormBuilder<TModel>(Html, form);
		}

		public FormBuilder<TModel> BeginForm()
		{
			return new FormBuilder<TModel>(Html, new Form());
		}

		public ButtonBuilder<TModel> Begin(Button button)
		{
			return new ButtonBuilder<TModel>(Html, button);
		}

		public ButtonBuilder<TModel> BeginButton()
		{
			return new ButtonBuilder<TModel>(Html, new Button());
		}
	}
}
