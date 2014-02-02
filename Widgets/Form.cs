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
	public class Form : Widget<Form>
	{
		public enum FormMethod
		{
			Get,
			Post
		}

		public enum FormEncoding
		{
			[Description("text/plain")] Plain,
			[Description("multipart/form-data")] Multipart,
			[Description("application/x-www-form-urlencoded")] UrlEncoded
		}

		public Form()
			: base("form")
		{

		}

		public Form Action(String action)
		{
			EnforceHtmlAttribute("action", action);

			return this;
		}

		public Form Method(FormMethod method)
		{
			switch (method)
			{
				case FormMethod.Get:
					EnforceHtmlAttribute("method", "get");
					break;
				case FormMethod.Post:
					EnforceHtmlAttribute("method", "post");
					break;
			}

			return this;
		}

		public Form Encoding(FormEncoding encoding)
		{
			EnforceHtmlAttribute("enctype", Misc.GetEnumDescription(encoding));

			return this;
		}

		public Form Ajax(Boolean on)
		{
			on.If(() => Data("ajax", "true"), () => Data("ajax", "false"));

			return this;
		}
	}
}
