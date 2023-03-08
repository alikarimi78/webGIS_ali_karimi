using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace counting_media
{
    internal interface ICounting_media
    {
        string Get_path(string file_name);
        int Count_of_imgtag_htmlfile(string file_path);
    }
}
