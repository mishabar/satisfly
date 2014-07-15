using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EliteRoute.Services.Tokens
{
    public class AirlineToken
    {
        public int ID { get; set; }
        public string Name { get; set; }

    }

    public static class AirlineTokenExtensions
    {
        public static IEnumerable<SelectListItem> ToSelectList(this IEnumerable<AirlineToken> list)
        {
            return list.Select(i => new SelectListItem { Value = i.ID.ToString(), Text = i.Name });
        }
    }
}
