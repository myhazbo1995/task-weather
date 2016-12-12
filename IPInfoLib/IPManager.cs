using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IPInfoLib
{
    public static class IPManager
    {
        public static IPInfoDataModel GetCurrentIP()
        {
            var model = new IPInfoDataModel();

            try
            {
                model = GetData();
            }
            catch (Exception ex)
            {
                throw;
            }

            return model;
        }

        private static IPInfoDataModel GetData()
        {
            var model = new IPInfoDataModel();

            var json = new WebClient().DownloadString("http://ipinfo.io");

            model = JsonConvert.DeserializeObject<IPInfoDataModel>(json);

            return model;
        }
    }
}
