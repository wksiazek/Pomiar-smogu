using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smog_Krakow
{
    class ListOfMeasurement
    {
        private List<Measurement> listOfData;

        public ListOfMeasurement()
        {
            listOfData = new List<Measurement>();
        }
        public void add(Measurement measurement)
        {
            listOfData.Add(measurement);
        }

        public List<Measurement> ListOfData
        {
            get { return listOfData; }
        }
    }
}
