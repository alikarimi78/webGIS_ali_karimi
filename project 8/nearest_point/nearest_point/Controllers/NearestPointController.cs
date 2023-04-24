using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using nearest_point.Models;
using Newtonsoft.Json;
using Oracle.DataAccess.Client;

namespace nearest_point.Controllers
{
    public class NearestPointController : ApiController
    {
        // connection string :
        public static string  DBConnection = "User Id =Ali; Password =123; Data Source =(DESCRIPTION =(ADDRESS =(PROTOCOL =TCP)(HOST =localhost)(PORT =1521))(CONNECT_DATA =(SERVER =DEDICATED)(SERVICE_NAME =orcl11)))";



        public IHttpActionResult GetAllRecords(double phi , double lambda)
        {
            // create an instance of DataBaseConnection class :
            DataBaseConnection NewInstanceDataBase = new DataBaseConnection(DBConnection);
            DataTable DataTable_coordinates = new DataTable();

            // getting table form database:
            DataTable_coordinates = NewInstanceDataBase.ExecuteQuery();

            // getting neatest point based on user input:
            string[] nearest_name = NewInstanceDataBase.GetNearestPoint(DataTable_coordinates, phi, lambda);
            
            return Ok(nearest_name);

        }
    }
}
