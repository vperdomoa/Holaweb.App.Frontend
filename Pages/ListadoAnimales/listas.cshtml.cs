using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Holaweb.App.Frontend.Pages
{

    public class listasModel : PageModel
    {
        private string[] vectorLista = { "Caballo Loco", "Plata", "Palomo", "Azabache", "Trueno", "Petronilo", "Ivancho", "Alvarito","Roycillo", "Rocinante", "MafeCabal" };
        public List<string> mylista { get; set; }=default!;
        public void OnGet()
        {
            mylista = new List<string>();
            mylista.AddRange(vectorLista);
        }
    }
}
