using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Smog_Krakow
{
    class DownloadMeasurement
    {
        double downloadValue(HtmlNode node)
        {
            double value;
            try
            {
                value = Convert.ToDouble(node.InnerText);
            }
            catch
            {
                value = 0.0;
            }
            return value;
        }

        DateTime downloadTime(HtmlNode node)
        {
            string[] part = node.InnerText.ToString().Split(',');
            string []part2 = part[0].Split('.');
            string []part3 = part[1].Split(':');
            return new DateTime(Convert.ToInt32(part2[2]), Convert.ToInt32(part2[1]), Convert.ToInt32(part2[0]), Convert.ToInt32(part3[0]), Convert.ToInt32(part3[1]),0);
        }
        public void download(MeasurementPlace place,ListOfMeasurement list)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load(place.Url);

            double pm10, pm25, o3, no2, so2, c6h6, c0;
            DateTime dateOfMeasurement;
            //pobieramy dane
            HtmlNode[] date = document.DocumentNode.SelectNodes("//td").ToArray();
            HtmlNode[] time = document.DocumentNode.SelectNodes("//th").ToArray();//16 element do 39
            int numberOfFirstElement = 16;
            int numberOfLastElement = 167;
            for (int i=0,j= numberOfFirstElement; i< numberOfLastElement; i+=7,++j)
            {
                pm10 = downloadValue(date[i]);
                pm25 = downloadValue(date[i+1]);
                o3 = downloadValue(date[i+2]);
                no2 = downloadValue(date[i+3]);
                so2 = downloadValue(date[i + 4]);
                c6h6 = downloadValue(date[i + 5]);
                c0 = downloadValue(date[i + 6]);
                dateOfMeasurement = downloadTime(time[j]);
                Measurement measurement = new Measurement(place, pm10, pm25, o3, no2, so2, c6h6, c0, dateOfMeasurement);
                list.add(measurement);
            }
        }
    }
}

