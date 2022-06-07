using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VSPlaybook.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private string theInfo;
        private string moreInfo;

        public string TheInfo { get => theInfo; set => theInfo = value; }
        public string MoreInfo { get => moreInfo; set => moreInfo = value; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

            TheInfo = "This is the original info";

            MoreInfo = "On file save makes it even better!";
        }

        public void OnGet()
        {

        }
    }
}