using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SqlTranslator.Domain.Interfaces;

namespace SqlTranslator.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ISqlTranslationService _translationService;

        public IndexModel(ISqlTranslationService translationService)
        {
            _translationService = translationService;
        }

        [BindProperty]
        public string QueryText { get; set; }

        [BindProperty]
        public string SourceDb { get; set; }

        [BindProperty]
        public string TargetDb { get; set; }

        public string TranslatedQuery { get; set; }

        public void OnGet()
        {
            // Inicializa sem query
        }

        public IActionResult OnPost()
        {
            // Usar o serviço de tradução para processar a query de acordo com os bancos de origem e destino
            TranslatedQuery = _translationService.Translate(QueryText, SourceDb, TargetDb);
            return Page();
        }
    }
}
