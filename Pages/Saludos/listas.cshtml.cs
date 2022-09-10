using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Holaweb.App.Frontend.Pages
{

    public class listasModel : PageModel
    {
        private string[] vectorLista = { "Ingreso caballo", "Ingreso Dueño", "Ingreso Veterinario", "Ingreso Datos del lugar" };
        public List<string> mylista { get; set; }
        public void OnGet()
        {
            mylista = new List<string>();
            mylista.AddRange(vectorLista);
        }
    }
}
