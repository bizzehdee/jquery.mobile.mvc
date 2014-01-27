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
using System.Reflection;

namespace jquery.mobile.mvc.Core
{
	public class Icon
	{
		public enum IconType
		{
			[Description("action")] Action,
			[Description("arrow-d-l")] ArrowDL,
			[Description("arrow-d-r")] ArrowDR,
			[Description("arrow-d")] ArrowD,
			[Description("arrow-l")] ArrowL,
			[Description("arrow-r")] ArrowR,
			[Description("arrow-u-l")] ArrowUL,
			[Description("arrow-u-r")] ArrowUR,
			[Description("arrow-u")] ArrowU,
			[Description("audio")] Audio,
			[Description("calendar")] Calendar,
			[Description("camera")] Camera,
			[Description("carat-d")] CaratD,
			[Description("carat-l")] CaratL,
			[Description("carat-r")] CaratR,
			[Description("carat-u")] CaratU,
			[Description("check")] Check,
			[Description("clock")] Clock,
			[Description("cloud")] Cloud,
			[Description("grid")] Grid,
			[Description("mail")] Mail,
			[Description("eye")] Eye,
			[Description("gear")] Gear,
			[Description("heart")] Heart,
			[Description("home")] Home,
			[Description("info")] Info,
			[Description("bullets")] Bullets,
			[Description("bars")] Bars,
			[Description("navigation")] Navigation,
			[Description("lock")] Lock,
			[Description("search")] Search,
			[Description("location")] Location,
			[Description("minus")] Minus,
			[Description("forbidden")] Forbidden,
			[Description("edit")] Edit,
			[Description("user")] User,
			[Description("phone")] Phone,
			[Description("plus")] Plus,
			[Description("power")] Power,
			[Description("recycle")] Recycle,
			[Description("forward")] Forward,
			[Description("refresh")] Refresh,
			[Description("shop")] Shop,
			[Description("comment")] Comment,
			[Description("star")] Star,
			[Description("tag")] Tag,
			[Description("back")] Back,
			[Description("video")] Video,
			[Description("alert")] Alert,
			[Description("delete")] Delete
		}

		public enum IconPosition
		{
			Left,
			Right,
			Top,
			Bottom,
			NoText
		}
	}
}
