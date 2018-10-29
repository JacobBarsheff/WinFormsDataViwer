using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_DataViewer.DAL;
using WinForms_DataViewer.Models;

namespace WinForms_DataViewer
{
    public partial class List : Form
    {
        private List<City> _cities;

        public List()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ReadWeatherAPIAndBindToDataGrid();
            }
            catch (Exception message)
            {

                MessageBox.Show(message.Message);
                this.Close();
            }
        }
        private void ReadWeatherAPIAndBindToDataGrid()
        {

            //
            // read data file
            //
            IDataService dataService = new APIDataService();
            _cities = dataService.ReadAll();

            //
            // bind list to DataGridView control
            //
            var bindingList = new BindingList<City>(_cities);
            var source = new BindingSource(bindingList, null);
            dataGridViewCities.DataSource = source;

            //
            // configure DataGridView control
            //
            this.dataGridViewCities.Columns["Pressure"].Visible = false;
            this.dataGridViewCities.Columns["Humidity"].Visible = false;
            this.dataGridViewCities.Columns["Deg"].Visible = false;
            this.dataGridViewCities.Columns["Icon"].Visible = false;

        }

        private void txtBox_search_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtBox_search.Text;
            var searchedList = _cities.Where(c => c.Name.ToUpper().Contains(searchTerm.ToUpper())).ToList();
            dataGridViewCities.DataSource = searchedList;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
           
            lbl_tempScroll.Text = $"Current Temperature at or Below ({trackBar1.Value}) :";

            var searchedList = _cities.Where(c => c.Temp <= trackBar1.Value).ToList();

            if (_chexBoxTemp.Checked == true)
            {
                searchedList = _cities.Where(c => c.Temp <= trackBar1.Value).OrderBy(c => c.Temp).ToList();
            }
      

            dataGridViewCities.DataSource = searchedList;
            

        }

        private void _chexBoxTemp_CheckedChanged(object sender, EventArgs e)
        {

            if (_chexBoxTemp.Checked == true)
            {
                var searchedList = _cities.Where(c => c.Temp <= trackBar1.Value).OrderBy(c => c.Temp).ToList();
                dataGridViewCities.DataSource = searchedList;
            }
            


        }

        private void btn_moreDetails_Click(object sender, EventArgs e)
        {
            if (dataGridViewCities.SelectedRows.Count == 1)
            {
                City city = new City();
                city = (City)dataGridViewCities.CurrentRow.DataBoundItem;

                Detail detailForm = new Detail(city);
                detailForm.ShowDialog();
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }
    }
}
