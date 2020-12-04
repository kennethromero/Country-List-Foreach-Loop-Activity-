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
using RestSharp;
using Newtonsoft;
using Newtonsoft.Json;

namespace Country_List__Foreach_Loop_Activity_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var Client = new RestClient("http://techslides.com/demos/country-capitals.json");
            var request = new RestRequest("", Method.GET);

            IRestResponse response = Client.Execute(request);

            var content = response.Content;

            var data = JsonConvert.DeserializeObject<Countries>(content);
            
            
        List<string> countries = new List<string>() { " ", " ", " ", " ", };
        List<string> names = new List<string>();

        int ctr = 0;
            foreach (string country in countries)
            {
                names.Add(ctr + "" + country);
                ctr = ctr + 1;
         }
            lstCountries.ItemsSource = names;
        }
    }
}
