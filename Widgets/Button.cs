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
using jquery.mobile.mvc.Core;

namespace jquery.mobile.mvc.Widgets
{
	/// <summary>
	/// jQuery Mobile marked up <see cref="Button"/>
	/// </summary>
	public class Button : Widget<Button>
	{
		/// <summary>
		/// Button type to use, denotes the markup to output
		/// </summary>
		public enum ButtonType
		{
			[Description("button")] Button,
			[Description("input")] Submit,
			[Description("input")] Reset,
			[Description("a")] Link
		}

		/// <summary>
		/// Position to pace a button if the button is a toolbar button
		/// </summary>
		public enum ToolbarButtonPosition
		{
			Left,
			Right
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Button"/> class.
		/// </summary>
		/// <param name="type"><see cref="Button"/> type.</param>
		public Button(ButtonType type = ButtonType.Button)
			: base(Misc.GetEnumDescription(type))
		{
			EnforceClass("ui-btn");
			if (type == ButtonType.Submit)
			{
				EnforceHtmlAttribute("type", "submit");
			}
		}

		/// <summary>
		/// Sets the href attribute for <see cref="ButtonType.Link"/> buttons
		/// </summary>
		/// <param name="href">URL to set as the href</param>
		/// <returns>This <see cref="Button"/></returns>
		public Button Href(String href)
		{
			EnforceHtmlAttribute("href", href);

			return this;
		}

		/// <summary>
		/// Sets the button to be inline or not
		/// </summary>
		/// <param name="on">true or false to set the inline option on or off</param>
		/// <returns>This <see cref="Button"/></returns>
		public Button Inline(bool on)
		{
			return Data("inline", on ? "true" : "false");
		}

		/// <summary>
		/// Sets the button to be a toolbar button and sets its position
		/// </summary>
		/// <param name="position">Position of the button within the toolbar</param>
		/// <returns>This <see cref="Button"/></returns>
		public Button ToolbarButton(ToolbarButtonPosition position)
		{
			switch (position)
			{
				case ToolbarButtonPosition.Left:
					return AddClass("ui-btn-left");
				case ToolbarButtonPosition.Right:
					return AddClass("ui-btn-right");
			}

			return this;
		}
	}
}
