using Demo.Helper;
using Demo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly CallApi _callApi = new CallApi();
        HttpResponseMessage _resMsg;
        public async Task< ActionResult> Index()
        {
            _resMsg = await _callApi.client.PostAsJsonAsync("api/GetValues","some");
            var result = _resMsg.Content.ReadAsAsync<ApiReturn>().Result;
            var vm = new Check();
            vm.Data = result.ApiData;
            return View(vm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}