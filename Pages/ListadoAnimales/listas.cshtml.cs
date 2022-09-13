using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Holaweb.App.Frontend.Pages
{

    public class listasModel : PageModel
    {
        private string[] vectorLista = { "Caballo Loco", "Plata", "Palomo", "Azabache", "Trueno", "Petronilo", "Ivancho", "Alvarito","Roycillo", "Rocinante", "MafeCabal" };
        private string[] vectorPropietarios={"Andres","Pedro","Pablo","Moises","Andres","Pedro","Pablo","Moises","Andres","Pedro","Pablo"};
        public List<string> mylista { get; set; }=default!;
        public List<string> mylista1 {get; set;}=default!;
        public void OnGet()
        {
            mylista = new List<string>();
            mylista1 = new List<string>();
            mylista.AddRange(vectorLista);
            mylista1.AddRange(vectorPropietarios);
    
        }
    }
}
