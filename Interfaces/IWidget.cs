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
using System.Web;
using jquery.mobile.mvc.Core;

namespace jquery.mobile.mvc.Interfaces
{
	/// <summary>
	///     Base widget interface, all widgets must implement this interface to render
	/// </summary>
	/// <typeparam name="T">Widget Type</typeparam>
	public interface IWidget<out T> : IHtmlString
	{
		/// <summary>
		///     Sets the id attribute within the html element
		/// </summary>
		/// <param name="id">id value</param>
		/// <returns>this (fluent)</returns>
		T Id(String id);

		/// <summary>
		///     Sets a data- prefixed key with a given value
		/// </summary>
		/// <param name="key">key to append to data- attribute</param>
		/// <param name="val">value of data-key</param>
		/// <returns>this (fluent)</returns>
		T Data(String key, String val);

		/// <summary>
		///     Sets the theme character to use
		/// </summary>
		/// <param name="theme">theme character</param>
		/// <returns>this (fluent)</returns>
		T Theme(Char theme);

		/// <summary>
		///     Sets the data role of the html element
		/// </summary>
		/// <param name="role">data-role to set</param>
		/// <returns>this (fluent)</returns>
		T Role(String role);

		/// <summary>
		///     Sets the inner html of the html element
		/// </summary>
		/// <param name="innerHtml">inner html or text to set</param>
		/// <returns>this (fluent)</returns>
		T InnerHtml(String innerHtml);

		/// <summary>
		///     Adds a class name to the html element's class attribute
		/// </summary>
		/// <param name="className">class name to add</param>
		/// <returns>this (fluent)</returns>
		T AddClass(String className);

		/// <summary>
		///     Removes a class name from the html elements class attribute
		/// </summary>
		/// <param name="className">class name to remove</param>
		/// <returns>this (fluent)</returns>
		T RemoveClass(String className);

		/// <summary>
		///     Sets the html elements icon and icon position
		/// </summary>
		/// <param name="icon">Icon to use</param>
		/// <param name="position">Icon position</param>
		/// <returns>this (fluent)</returns>
		T Icon(Icon.IconType icon, Icon.IconPosition position);
	}
}