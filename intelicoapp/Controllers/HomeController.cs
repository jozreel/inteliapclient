using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace intelicoapp.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

         /*   string baseUri = "http://localhost:59727/api/equipments/";
            string uri = baseUri;
            using (HttpClient httpClient = new HttpClient())
            {
                Task<String> response = httpClient.GetStringAsync(uri);
                // return JsonConvert.DeserializeObjectAsync<List<Car>>(response.Result).Result;
                this.ViewBag.json = new JavaScriptSerializer().Serialize(response);
                return View();
            }*/
           return View();
        }
    }
}
