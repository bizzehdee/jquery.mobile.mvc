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
using jquery.mobile.mvc.Builders;
using jquery.mobile.mvc.Widgets;

namespace jquery.mobile.mvc.Core
{
	public partial class jQueryMobile<TModel>
	{
		/*BEGIN PAGE*/
		public PageBuilder<TModel> Begin(Page page)
		{
			return new PageBuilder<TModel>(Html, page);
		}

		public PageBuilder<TModel> BeginPage(String id)
		{
			return new PageBuilder<TModel>(Html, new Page(id));
		}
		/*END PAGE*/

		/*BEGIN FORM*/
		public FormBuilder<TModel> Begin(Form form)
		{
			return new FormBuilder<TModel>(Html, form);
		}

		public FormBuilder<TModel> BeginForm()
		{
			return new FormBuilder<TModel>(Html, new Form());
		}
		/*END FORM*/

		/*BEGIN BUTTON*/
		public ButtonBuilder<TModel> Begin(Button button)
		{
			return new ButtonBuilder<TModel>(Html, button);
		}

		public ButtonBuilder<TModel> BeginButton()
		{
			return new ButtonBuilder<TModel>(Html, new Button());
		}

		public ButtonBuilder<TModel> BeginButton(Button.ButtonType type)
		{
			return new ButtonBuilder<TModel>(Html, new Button(type));
		}
		/*END BUTTON*/

		/*BEGIN GRID*/
		public GridBuilder<TModel> Begin(Grid grid)
		{
			return new GridBuilder<TModel>(Html, grid);
		}

		public GridBuilder<TModel> BeginGrid(Char gridType)
		{
			return new GridBuilder<TModel>(Html, new Grid(gridType));
		}
		/*END GRID*/

		/*BEGIN LISTVIEW*/
		public ListViewBuilder<TModel> Begin(ListView list)
		{
			return new ListViewBuilder<TModel>(Html, list);
		}

		public ListViewBuilder<TModel> BeginListView()
		{
			return new ListViewBuilder<TModel>(Html, new ListView());
		}
		/*END LISTVIEW*/

		/*BEGIN LISTVIEW*/
		public PanelBuilder<TModel> Begin(Panel panel)
		{
			return new PanelBuilder<TModel>(Html, panel);
		}

		public PanelBuilder<TModel> BeginPanel()
		{
			return new PanelBuilder<TModel>(Html, new Panel());
		}
		/*END LISTVIEW*/

		/*BEGIN NAVBAR*/
		public NavbarBuilder<TModel> Begin(Navbar navbar)
		{
			return new NavbarBuilder<TModel>(Html, navbar);
		}

		public NavbarBuilder<TModel> BeginNavbar()
		{
			return new NavbarBuilder<TModel>(Html, new Navbar());
		}
		/*END NAVBAR*/

		/*BEGIN SELECTMENU*/
		public SelectMenuBuilder<TModel> Begin(SelectMenu selectMenu)
		{
			return new SelectMenuBuilder<TModel>(Html, selectMenu);
		}

		public SelectMenuBuilder<TModel> BeginSelectMenu()
		{
			return new SelectMenuBuilder<TModel>(Html, new SelectMenu());
		}
		/*END SELECTMENU*/
	}
}
