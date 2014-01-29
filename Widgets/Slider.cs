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
using jquery.mobile.mvc.Core;

namespace jquery.mobile.mvc.Widgets
{
	public class Slider : Widget<Slider>
	{
		public Slider()
			: base("input")
		{
			EnforceHtmlAttribute("type", "range");
		}

		public Slider Min(float min)
		{
			EnforceHtmlAttribute("min", String.Format("{0}", min));
			return this;
		}

		public Slider Max(float max)
		{
			EnforceHtmlAttribute("max", String.Format("{0}", max));
			return this;
		}

		public Slider Value(float val)
		{
			EnforceHtmlAttribute("value", String.Format("{0}", val));
			return this;
		}

		public Slider Step(float val)
		{
			EnforceHtmlAttribute("step", String.Format("{0}", val));
			return this;
		}

		public Slider Highlight(Boolean on)
		{
			return Data("highlight", on ? "true" : "false");
		}
	}
}
