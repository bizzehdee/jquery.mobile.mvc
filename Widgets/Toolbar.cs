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
	public class Toolbar : Widget<Toolbar>
	{
		public enum ToolbarType
		{
			[Description("header")] Header,
			[Description("footer")] Footer
		}
		public Toolbar() 
			: base("div")
		{
			Role(Misc.GetEnumDescription(ToolbarType.Header));
		}
 
		public Toolbar(ToolbarType type)
			: base("div")
		{
			switch (type)
			{
				case ToolbarType.Header:
					InnerTag = "h1";
					break;
				case ToolbarType.Footer:
					InnerTag = "h4";
					break;
			}
			Role(Misc.GetEnumDescription(type));
 		}

		public Toolbar Fixed(Boolean on)
		{
			return on ? Data("position", "fixed") : Data("position", "");
		}

		public Toolbar FullScreen(Boolean on)
		{
			return Data("fullscreen", on ? "true" : "false");
		}
	}
}
