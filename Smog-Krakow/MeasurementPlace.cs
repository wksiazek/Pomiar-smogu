using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smog_Krakow
{
    class MeasurementPlace
    {
        string city;
        string adress;
        string url;
        public MeasurementPlace(string city, string adress, string url)
        {
            this.city = city;
            this.adress = adress;
            this.url = url;
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Address
        {
            get { return adress; }
            set { adress = value; }
        }
        public string Url
        {
            get { return url; }
            set { url = value; }
        }
    }
}
