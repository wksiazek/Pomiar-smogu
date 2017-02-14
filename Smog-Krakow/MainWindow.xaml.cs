using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Smog_Krakow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MeasurementPlace place = new MeasurementPlace("Warszawa", "ul.Wokalna 1", "http://powietrze.gios.gov.pl/pjp/current/station_details/table/550/1/0");
            DownloadMeasurement downloader = new DownloadMeasurement();
            ListOfMeasurement list = new ListOfMeasurement();
            downloader.download(place,list);
        }
    }
}
