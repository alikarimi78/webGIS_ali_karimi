using System;
using System.Windows.Forms;

namespace azimuth
{
    public partial class azimuth_form : Form
    {
        public azimuth_form()
        {
            InitializeComponent();
        }

        private void function_button_Click(object sender, EventArgs e)
        {
            try
            {
                // getting values fom textbox:

                double latitude1 = double.Parse(lat1_text.Text);
                double latitude2 = double.Parse(lat2_text.Text);
                double longitude1 = double.Parse(long1_text.Text);
                double longitude2 = double.Parse(long2_text.Text);

                // convert degrees to radian :

                latitude1 = Calculation.Toradian(latitude1);
                longitude1 = Calculation.Toradian(longitude1);
                latitude2 = Calculation.Toradian(latitude2);
                longitude2 = Calculation.Toradian(longitude2);

                // caculate azimuth by funct

                double T = Calculation.Azimuth(latitude1, longitude1, latitude2, longitude2);
                T = Math.Round(T, 3);
                answer_show.Text = Convert.ToString(T);
            }

            catch (FormatException)
            {
                MessageBox.Show("you must enter just number !");
            }
        }

        private void azimuth_form_Load(object sender, EventArgs e)
        {
            MessageBox.Show("welcome to azimuth calculator application!");
        }
    }
}
