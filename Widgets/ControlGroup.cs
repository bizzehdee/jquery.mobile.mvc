using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using jquery.mobile.mvc.Core;

namespace jquery.mobile.mvc.Widgets
{
	public class ControlGroup : Widget<ControlGroup>
	{
		public ControlGroup() 
			: base("div")
		{
			Role("controlgroup");
		}

		public ControlGroup Horizontal()
		{
			Data("type", "horizontal");
			return this;
		}

		public ControlGroup Mini()
		{
			Data("mini", "true");
			return this;
		}
	}
}
