using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;
using WebAplicationRazor.Services;

namespace WebAplicationRazor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly StringGeneratorService _stringGenerator;

        public List<string> Strings { get; set; } = new List<string> { "wolowo", "aboba", "tom", "mot" };

        public IndexModel(ILogger<IndexModel> logger, StringGeneratorService stringGenerator)
        {
            _logger = logger;
            _stringGenerator = stringGenerator;
        }

        public void OnGet()
        {
            Strings = _stringGenerator.Generate().ToList();
        }
    }
}