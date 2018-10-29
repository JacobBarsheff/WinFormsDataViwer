using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_DataViewer.Models;

namespace WinForms_DataViewer.DAL
{
    public interface IDataService
    {
        List<City> ReadAll();
        //void WriteAll(List<WeatherData> cities);
    }
}
