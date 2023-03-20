using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingKMLProject
{
    internal interface IReading_kml
    {
        string Get_path(OpenFileDialog dialog_name);
        DataTable Read_KML(string path);
        bool Insert_table(string connection_string,DataTable table,int row_indx);
    }
}
