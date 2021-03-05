using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApp
{
    public static class MyHelpers
    {
        public static HtmlString Ulist(this IHtmlHelper html, params string[] items)
        {
            StringBuilder sb = new StringBuilder("<ul>");
            foreach (string item in items)
            {
                sb.Append("<li>");
                sb.Append(item);
                sb.Append("</li>");
            }
            sb.Append("</ul>");
            return new HtmlString(sb.ToString());
        }
    }
}