using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingKMLProject
{
    public partial class ReadingKmlMainform : Form
    {
        IReading_kml reading_kml_instance;
        public ReadingKmlMainform()
        {
            InitializeComponent();
            reading_kml_instance = new Reading_kml_class();
        }
        public static string DBConnection = "User Id =Ali; Password =123; Data Source =(DESCRIPTION =(ADDRESS =(PROTOCOL =TCP)(HOST =localhost)(PORT =1521))(CONNECT_DATA =(SERVER =DEDICATED)(SERVICE_NAME =orcl11)))";
        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            // Getting file path:

            OpenFileDialog openFile = new OpenFileDialog();
            string file_path = reading_kml_instance.Get_path(openFile);
            lbl_filepath.Text = file_path;

            // Reading kml file and showing in gridview :

            DataTable dt = reading_kml_instance.Read_KML(file_path);
            data_grid_view.DataSource = dt;
            
            
            // gridview style adjusting :

            this.data_grid_view.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.data_grid_view.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



            // CONNECTING DATA BASE :

            bool Is_success;

            for (int i =90; i <91; i++)
            {
                //string name_string = convert.tostring(data_grid_view.rows[i].cells[0].value);

                Is_success = reading_kml_instance.Insert_table(DBConnection,dt,i);
                if (!Is_success)
                {
                    MessageBox.Show($" {i + 1}th data can't be inserted!");
                }
            }
        }
    }
}
