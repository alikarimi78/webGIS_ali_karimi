using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace nearest_point.Models
{
    public class DataBaseConnection
    {
        private string connectionString;
        public DataBaseConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable ExecuteQuery()
        {

            // connect to database :
            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    using (OracleCommand cmd = new OracleCommand("", conn))
                    {
                        conn.Open();
                        OracleTransaction txn = conn.BeginTransaction(IsolationLevel.ReadCommitted);

                        try
                        {
                            // select table query
                            cmd.CommandText = "SELECT * FROM kmlcoor";
                            cmd.CommandType = CommandType.Text;


                            // reading table :
                            using (OracleDataReader reader = cmd.ExecuteReader())
                            {
                                DataTable dataTable = new DataTable();
                                dataTable.Load(reader);
                                return dataTable;
                            }


                        }
                        catch
                        {
                            return null;
                        }


                        txn.Commit();

                    }
                }


            }

            catch
            {
                return null;
            }
        }

        public string[] GetNearestPoint(DataTable data_records, double phi, double lambda)
        {
            
            double[] converted_coor = Convert.ConvertToCartesian(phi, lambda);
            double x = converted_coor[0];
            double y = converted_coor[1];

            // setting first elements (first row) :
            // _t means : taken coordiante or name from databse!
            int number_of_rows = data_records.Rows.Count;
            double phi_t = System.Convert.ToDouble(data_records.Rows[0][1]);
            double lambda_t = System.Convert.ToDouble(data_records.Rows[0][2]);

            double[] converted_coor_t = Convert.ConvertToCartesian(phi_t, lambda_t);
            double x_t = converted_coor_t[0];
            double y_t = converted_coor_t[1];

            double distace = Math.Sqrt(Math.Pow(x_t - x, 2) + Math.Pow(y_t - y, 2));
            double min_distance = distace;
            string nearest_name = data_records.Rows[0][0].ToString();
            double phi_min = phi_t;
            double lambda_min = lambda_t;

            // a result array for storing phi , lambda , name and distance of nearest point: 
            string[] result = new string[4];



            for (int i = 1; i < number_of_rows; i++)
            {
                phi_t = System.Convert.ToDouble(data_records.Rows[i][1]);
                lambda_t = System.Convert.ToDouble(data_records.Rows[i][2]);

                converted_coor_t = Convert.ConvertToCartesian(phi_t, lambda_t);
                x_t = converted_coor_t[0];
                y_t = converted_coor_t[1];


                distace = Math.Sqrt(Math.Pow(x_t - x, 2) + Math.Pow(y_t - y, 2));
                if (distace <= min_distance)
                {
                    min_distance = distace;
                    nearest_name = data_records.Rows[i][0].ToString();                   
                    phi_min = System.Convert.ToDouble(data_records.Rows[i][1]);
                    lambda_min = System.Convert.ToDouble(data_records.Rows[i][2]);

                    // setting values for result array :
                    result[0] = data_records.Rows[i][0].ToString();
                    result[1] = phi_min.ToString();
                    result[2] = lambda_min.ToString();
                    result[3] = "distance(m) : " + min_distance.ToString();
                }
            }

            return result;
        }
    }
}