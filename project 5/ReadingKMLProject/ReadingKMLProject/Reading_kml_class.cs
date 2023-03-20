using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Oracle.DataAccess.Client;

namespace ReadingKMLProject
{
    internal class Reading_kml_class : IReading_kml
    {

        // A method for building a OpenFileDialog to Browse and  filter file extension to choose kml file
        public string Get_path(OpenFileDialog openFile)
        {
            openFile.Filter = "KML files (*.kml)|*.kml";
            openFile.Title = "select KML file";
            openFile.CheckFileExists = true;
            openFile.CheckPathExists = true;
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // Getting path of file and showoing it :

                string file_path = openFile.FileName;
                return file_path;
            }
            else
            {
                MessageBox.Show("Please Select a KTML file!");
                return null;
            }
        }

        public bool Insert_table(string DBConnection, DataTable data_grid_view,int raw_indx)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnection))
                {
                    using (OracleCommand cmd = new OracleCommand("", conn))
                    {
                        conn.Open();
                        OracleTransaction txn = conn.BeginTransaction(IsolationLevel.ReadCommitted);


                        // 90th data has "'" character in its name so should skip this!


                        string name_string = Convert.ToString(data_grid_view.Rows[raw_indx][0]);

                        if (name_string.Contains('\''))
                        {
                            name_string =  name_string.Replace('\'', ' ');                        
                        }

                        try
                        {
                            cmd.CommandText = @"INSERT INTO KMLCOOR (NAME , X , Y , Z) VALUES ('" + name_string + "','" + data_grid_view.Rows[raw_indx][1] + "','" + data_grid_view.Rows[raw_indx][2] + "','" + data_grid_view.Rows[raw_indx][3] + "')";
                            cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return false;
                        }


                        txn.Commit();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }


        public bool Insert_table(string connection_string, DataTable table)
        {
            throw new NotImplementedException();
        }

        // a method for reading and showing kml component in datatable :
        public DataTable Read_KML(string file_path)
        {
            // Reading KML with XmlReader !!!!

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Parse;
            XmlReader read = XmlReader.Create(file_path, settings);

            // Creating datatable for KML dataset :

            DataTable datatable_kml = new DataTable();
            datatable_kml.Columns.Add("Location");
            datatable_kml.Columns.Add("X");
            datatable_kml.Columns.Add("Y");
            datatable_kml.Columns.Add("Z");
            string nam = "";

            while (read.Read())
            {


                string component = read.Name;
                if (component == "name")
                {
                    nam = read.ReadElementContentAsString();
                }

                if (component == "coordinates")
                {
                    string coordin = read.ReadElementContentAsString();
                    string[] coordinate = coordin.Split(',');
                    string[] Final = { nam, coordinate[0], coordinate[1], coordinate[2] };
                    datatable_kml.Rows.Add(Final);
                }
            }
            return datatable_kml;
        }
    }
}

