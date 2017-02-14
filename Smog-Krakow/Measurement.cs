using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smog_Krakow
{
    class Measurement
    {
        private MeasurementPlace place;
        private double pm10;
        private double pm25;
        private double o3;
        private double no2;
        private double so2;
        private double c6h6;
        private double c0;
        private DateTime date;
        public Measurement()
        {

        }
        public Measurement(MeasurementPlace place, double pm10, double pm25, double o3, double no2, double so2, double c6h6, double c0, DateTime date)
        {
            this.place = place;
            this.pm10 = pm10;
            this.pm25 = pm25;
            this.o3 = o3;
            this.no2 = no2;
            this.so2 = so2;
            this.c6h6 = c6h6;
            this.c0 = c0;
            this.date = date;
        }
    }
}
