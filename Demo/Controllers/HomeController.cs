using Demo.Helper;
using Demo.ViewModels;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly CallApi _callApi = new CallApi();
        HttpResponseMessage _resMsg;
        public async Task<ActionResult> Index()

        {
            var vm =new List<Post>();
            try
            {
                _resMsg = await _callApi.client.PostAsJsonAsync("api/Post/GetAll", "Some");
                var resultObj = _resMsg.Content.ReadAsAsync<List<Post>>().Result;
                vm = resultObj;
                return View(vm);
            }
            catch (Exception ex)
            {
                return View(vm);
            }
        }

        public async Task<ActionResult> Report()
        {

            var vm = new ReportModel();
            try
            {
                var userName = Session["userName"].ToString();
                _resMsg = await _callApi.client.PostAsJsonAsync("api/Post/GetReport",userName);
                var resultObj = _resMsg.Content.ReadAsAsync<ReportModel>().Result;
                vm = resultObj;
                return View(vm);
            }
            catch (Exception ex)
            {
                return View(vm);
            }      
        }

    }
}