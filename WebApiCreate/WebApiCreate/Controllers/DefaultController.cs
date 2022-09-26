using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApiCreate.EDM;

namespace WebApiCreate.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public async Task<ActionResult> Index()
        {
            List<tblemployee> li =null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44335/");
                var response = await client.GetAsync("api/emp");
                if (response.IsSuccessStatusCode)
                {
                    li = await response.Content.ReadAsAsync<List<tblemployee>>();
                }
            }
            return View(li);
        }

        public async Task<ActionResult> Details(int id)
        {
            tblemployee li = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44335/");
                var response = await client.GetAsync($"api/emp/{id}");
                if (response.IsSuccessStatusCode)
                {
                    li = await response.Content.ReadAsAsync<tblemployee>();
                }
            }
            return View(li);
        }
    }
}