using BusTicket.Core.Abstract.IExternal.OBilet;
using BusTicket.Core.AOP.Cashing;
using BusTicket.Core.Dto.GetBusJourneys.Request;
using BusTicket.Core.Dto.GetBusJourneys.Response;
using BusTicket.Core.Dto.GetBusLocations.Response;
using BusTicket.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;

namespace BusTicket.UI.Controllers
{
    public class GetBusLocationsController : Controller
    {
        private readonly IGetBusLocationsService _getBusLocationsService;
        private readonly Microsoft.Extensions.Caching.Memory.IMemoryCache _memoryCache;
        private readonly IGetBusJourneysService _getBusJourneysService;
        public GetBusLocationsController(IGetBusJourneysService getBusJourneysService, Microsoft.Extensions.Caching.Memory.IMemoryCache memoryCache, IGetBusLocationsService getBusLocationsService)
        {
            _getBusLocationsService = getBusLocationsService;
            _memoryCache = memoryCache;
            _getBusJourneysService = getBusJourneysService;
        }


        public IActionResult Index()
        {

            List<GetBusLocationsResponse> responses;
            const string key = "terminals";
            var origindropdownList = new List<SelectListItem>();
            var destinationdropdownList = new List<SelectListItem>();
            if (!_memoryCache.TryGetValue(key, out responses))
            {
                var list = _getBusLocationsService.GetBusLocations(new Core.Dto.GetBusLocations.Request.GetBusLocationsRequest());
                _memoryCache.Set(key, list.data);
            }

            responses = _memoryCache.Get(key) as List<GetBusLocationsResponse>;


            var json = HttpContext.Session.GetString("busJourney");
            var data = new GetBusJourneysRequest();
            if (!string.IsNullOrWhiteSpace(json))
            {
                data = JsonConvert.DeserializeObject<GetBusJourneysRequest>(json);
            }



            int i = 0;
            foreach (var item in responses)
            {

                origindropdownList.Add(new SelectListItem
                {
                    Text = item.name,
                    Value = item.id.ToString(),

                });

                destinationdropdownList.Add(new SelectListItem
                {
                    Text = item.name,
                    Value = item.id.ToString(),

                });
            }
            if (!string.IsNullOrWhiteSpace(data.destinationid) && Convert.ToDateTime(data.departuredate) > DateTime.Now)
            {
                origindropdownList.FirstOrDefault(x => x.Value == data.originid).Selected = true;
                destinationdropdownList.FirstOrDefault(x => x.Value == data.destinationid).Selected = true;
            }
            ViewBag.drop = origindropdownList;
            ViewBag.drop2 = destinationdropdownList;
            return View(new GlobalViewModel
            {
                GetBusLocationsResponses = responses
            });
        }
        [HttpPost]
        public IActionResult Index(string val1, string val2, string date)
        {
            string strDDLValue = Request.Form["Origin"].ToString();
            string strDDLValue2 = Request.Form["departure-date"].ToString();


            var d = _getBusJourneysService.GetBusLocations(new Core.Dto.GetBusJourneys.Request.GetBusJourneysRequest
            {
                departuredate = date,
                destinationid = val2,
                originid = val1,
            });


            var jsondata = new GetBusJourneysRequest
            {
                departuredate = date,
                destinationid = val2,
                originid = val1
            };
            var json = JsonConvert.SerializeObject(jsondata);


            HttpContext.Session.SetString("busJourney", json);

            var journeyjson = JsonConvert.SerializeObject(d.data);
            HttpContext.Session.SetString("journeyjson", journeyjson);
            ViewBag.journey = journeyjson;
            return Json("success");
        }
        [HttpGet]
        public IActionResult GetBusJourneyList(string json)
        {
            var da = HttpContext.Session.GetString("journeyjson");
            var journey = JsonConvert.DeserializeObject<List<GetBusJourneysResponse>>(da);
            return View(new GlobalViewModel
            {
                getBusJourneysResponses = journey
            });
        }



    }
}
