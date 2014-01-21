using jquery.mobile.mvc.Core;

namespace jquery.mobile.mvc.Widgets
{
	public class Content : Widget<Content>
	{
		public enum ContentType
		{
			Header,
			Content,
			Footer
		}

		private ContentType type { get; set; }

		public Content(ContentType contentType = ContentType.Content)
			: base("div")
		{
			type = contentType;

			switch (type)
			{
				case ContentType.Header:
					EnforceHtmlAttribute("data-role", "header");
					break;
				case ContentType.Content:
					EnforceHtmlAttribute("role", "main");
					EnforceClass("ui-content");
					break;
				case ContentType.Footer:
					EnforceHtmlAttribute("data-role", "footer");
					break;
			}
		}
	}
}
