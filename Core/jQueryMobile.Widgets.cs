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
using jquery.mobile.mvc.Widgets;

namespace jquery.mobile.mvc.Core
{
	public partial class jQueryMobile<TModel>
	{
		public Button Button(Button.ButtonType type = Widgets.Button.ButtonType.Button)
		{
			return new Button(type);
		}

		public Checkbox Checkbox()
		{
			return new Checkbox();
		}

		public DatePicker DatePicker()
		{
			return new DatePicker();
		}

		public FlipSwitch FlipSwitch()
		{
			return new FlipSwitch();
		}

		public RadioButton RadioButton()
		{
			return new RadioButton();
		}

		public TextInput TextInput()
		{
			return new TextInput();
		}
	}
}
