using jquery.mobile.mvc.Widgets;

namespace jquery.mobile.mvc.Core
{
	public partial class jQueryMobile<TModel>
    {
		public Button Button(Button.ButtonType type = Widgets.Button.ButtonType.Button)
		{
			return new Button(type);
		}
    }
}
