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
using System.ComponentModel;
using jquery.mobile.mvc.Core;

namespace jquery.mobile.mvc.Widgets
{
	/// <summary>
	/// Helper widget for creating simple HTML elements
	/// </summary>
	public class HtmlElement : Widget<HtmlElement>
	{
		public enum HTMLTypes
		{
			[Description("div")] Div,
			[Description("h1")] Header1,
			[Description("h2")] Header2,
			[Description("h3")] Header3,
			[Description("h4")] Header4,
			[Description("h5")] Header5,
			[Description("h6")] Header6,
			[Description("span")] Span
		}

		public HtmlElement(HTMLTypes tag)
			: base(Misc.GetEnumDescription(tag))
		{

		}

		public HtmlElement(HTMLTypes tag, HTMLTypes innerTag)
			: base(Misc.GetEnumDescription(tag), Misc.GetEnumDescription(innerTag))
		{

		}

		public HtmlElement(string tag) 
			: base(tag)
		{

		}

		public HtmlElement(string tag, string innerTag) 
			: base(tag, innerTag)
		{

		}
	}
}
