using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_DataViewer
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            lbl_Instructions.Text = "1) The Search By City Function Allows users to find a city within" +
                " the populated list\nby simply typing in a desired city.\n" +
                "2) Use the slider to filter cities with temperatures at or below the displayed value. \n" +
                "3) Click the Sort By Temperature button to sort cites by temperature descending.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
