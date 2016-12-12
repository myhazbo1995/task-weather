using APIXULib;
using IPInfoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APIXUWebSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            try
            {
                string key = "eb2a0633229b456ba6093557151106";
                IRepository repo = new Repository();
                var ipInfoModel = IPManager.GetCurrentIP();

                var GetCityForecastWeatherResult = repo.GetWeatherData(key, GetBy.CityName, ipInfoModel.City, Days.Ten);

                if(GetCityForecastWeatherResult.current == null || GetCityForecastWeatherResult.forecast == null || GetCityForecastWeatherResult.location == null)
                {
                    ViewBag.ErrorMessage = "Something went wrong: apixu API returned not all data";
                }

                return View(GetCityForecastWeatherResult);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "Something went wrong: " + ex.Message;

                return View(new WeatherModel());
            }
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