using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPInfoLib
{
    [JsonObject(MemberSerialization.OptIn)]
    public class IPInfoDataModel
    {
        private string _loc { get; set; }     
        private string _ip { get; set; }
        private string _org { get; set; }
        private string _hostname { get; set; }
        private string _region { get; set; }
        private string _country { get; set; }
        private string _city { get; set; }
        private string _postal { get; set; }


        [JsonProperty(PropertyName = "loc")]
        public string Loc { get { return _loc; } set { _loc = value; } }

        public string Latitude { get { return !String.IsNullOrEmpty(Loc) && Loc.Contains(',') ? Loc.Split(',')[0] : String.Empty; }}

        public string Longitude { get { return !String.IsNullOrEmpty(Loc) && Loc.Contains(',') ? Loc.Split(',')[1] : String.Empty; } }

        [JsonProperty(PropertyName = "ip")]
        public string IP { get { return _ip; } set { _ip = value; } }

        [JsonProperty(PropertyName = "org")]
        public string Organisation { get { return _org; } set { _org = value; } }

        [JsonProperty(PropertyName = "hostname")]
        public string HostName { get { return _hostname; } set { _hostname = value; } }

        [JsonProperty(PropertyName = "region")]
        public string Region { get { return _region; } set { _region = value; } }

        [JsonProperty(PropertyName = "city")]
        public string City { get { return _city; } set { _city = value; } }

        [JsonProperty(PropertyName = "county")]
        public string Country { get { return _country; } set { _country = value; } }

        [JsonProperty(PropertyName = "postal")]
        public string Postal { get { return _postal; } set { _postal = value; } }

        public IPInfoDataModel()
        {

        }

        public IPInfoDataModel(string loc, 
            string ip, 
            string organisation, 
            string hostName, 
            string region,
            string city,
            string country,
            string postal)
        {
            Loc = loc;
            IP = ip;
            Organisation = organisation;
            HostName = hostName;
            Region = region;
            City = city;
            Country = country;
            Postal = postal;
        }
    }
}
