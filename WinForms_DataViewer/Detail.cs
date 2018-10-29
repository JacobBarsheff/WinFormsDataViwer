using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_DataViewer.Models;

namespace WinForms_DataViewer
{
    public partial class Detail : Form
    {
        City _city = new City();
        public Detail(City city)
        {
            InitializeComponent();
            _city = city;
        }

        private void Detail_Load(object sender, EventArgs e)
        {
            lbl_City.Text = _city.Name;
            lbl_Country.Text = "Country: "+_city.Country;
            lbl_Long.Text = "Longitude: "+_city.Lon.ToString();
            lbl_lat.Text = "Latitude: "+_city.Lat.ToString();
            lbl_weatherDesc.Text = "Conditions: "+_city.WeatherDesc;
            lbl_Cloud.Text = "Cloud Coverage  :"+_city.CloudCoverage.ToString()+"%";
            lbl_Temp.Text = "Temperature :" + _city.Temp.ToString();
            lbl_WindSpeed.Text = "Wind Speed :" + _city.Speed.ToString() + " mph";
            lbl_Pressure.Text = "Pressure :" + _city.Pressure.ToString()+" hPa";
            lbl_Humidity.Text = "Humidity :" + _city.Humidity.ToString() + "%";
            lbl_WindDeg.Text = "Wind Direction (Degrees): " + _city.Deg.ToString();
            picture_weatherIcon.ImageLocation = $"http://openweathermap.org/img/w/{_city.Icon}.png";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
