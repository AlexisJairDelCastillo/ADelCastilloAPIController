using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace PL.Controllers
{
    public class PersonaController : Controller
    {
        public async Task<ActionResult> Persona()
        {
            string apiUrl = "https://besvc.capacitateparaelempleo.org/api/inscriptions/TestReport";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();

                        var data = JsonConvert.DeserializeObject<ML.Informacion>(responseData);

                        return View("Persona", data);
                    }
                    else
                    {
                        return View("Error");
                    }
                }
            }catch(Exception ex)
            {
                return View("Error");
            }
        }
    }
}
