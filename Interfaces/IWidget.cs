using System;
using System.Web;

namespace jquery.mobile.mvc.Interfaces
{
	public interface IWidget<out T> : IHtmlString
	{
		T Id(String id);
		T Data(String key, String val);
		T Theme(String theme);
		T Role(String role);
		T InnerHtml(String innerHtml);
		T AddClass(String className);
		T RemoveClass(String className);
		T Icon(String iconName, bool noText = false);
	}
}
