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
	public class TextInput : Widget<TextInput>
	{
		public enum TextInputType
		{
			[Description("text")] Text,
			[Description("number")] Number,
			[Description("search")] Search,
			[Description("date")] Date,
			[Description("month")] Month,
			[Description("week")] Week,
			[Description("time")] Time,
			[Description("datetime")] DateTime,
			[Description("phone")] Phone,
			[Description("email")] Email,
			[Description("url")] URL,
			[Description("password")] Password,
			[Description("color")] Colour,
			[Description("color")] Color = Colour,
			[Description("file")] File,
			[Description("textarea")] TextArea
		}

		public TextInput()
			: base("input")
		{
			EnforceHtmlAttribute("type", "text");
		}

		public TextInput(TextInputType type)
			: base(type == TextInputType.TextArea ? "textarea" : "input")
		{
			if (type != TextInputType.TextArea) EnforceHtmlAttribute("type", Misc.GetEnumDescription(type));
		}

		public TextInput Type(TextInputType type)
		{
			if (type != TextInputType.TextArea)
			{
				Tag = "input";
				EnforceHtmlAttribute("type", Misc.GetEnumDescription(type));
			}
			else
			{
				Tag = "textarea";
			}

			return this;
		}

		public TextInput ClearButton(bool on)
		{
			return Data("clear-btn", on ? "true" : "false");
		}

		public TextInput Placeholder(String placeholder)
		{
			EnforceHtmlAttribute("placeholder", placeholder);
			return this;
		}

		public TextInput Value(String value)
		{
			EnforceHtmlAttribute("value", value);
			return this;
		}

		public TextInput Name(String name)
		{
			EnforceHtmlAttribute("name", name);
			return this;
		}
	}
}
