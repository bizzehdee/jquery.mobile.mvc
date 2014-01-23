using System;
using System.Web.Mvc;
using jquery.mobile.mvc.Abstract;
using jquery.mobile.mvc.Widgets;

namespace jquery.mobile.mvc.Builders
{
	public class GridBuilder<TModel> : Builder<TModel, Grid>
	{
		public GridBuilder(HtmlHelper<TModel> _htmlHelper, Grid _element) 
			: base(_htmlHelper, _element)
		{

		}

		public GridBlockBuilder<TModel> Begin(GridBlock block)
		{
			return new GridBlockBuilder<TModel>(htmlHelper, block);
		}

		public GridBlockBuilder<TModel> BeginBlock(Char blockType)
		{
			return new GridBlockBuilder<TModel>(htmlHelper, new GridBlock(blockType));
		}
	}
}
