using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace counting_media
{
    internal class Counting_mdedia_functions : ICounting_media
    {

        public string Get_path(string file_name)
        {
            string file_path = Path.GetFullPath(file_name);
            return file_path;
        }

        public int Count_of_imgtag_htmlfile(string file_path)
        {
            // reading file :

            string readed_file = File.ReadAllText(file_path);

            int count_of_media = 0;

            // coungint <img> tags by a for loop and boolian statement : 

            for (int i = 0; i < readed_file.Length; i++)
            {
                if (i == readed_file.Length - 3)
                {
                    break;
                }

                bool l0 = readed_file[i].Equals('<');
                bool l1 = readed_file[i + 1].Equals('i');
                bool l2 = readed_file[i + 2].Equals('m');
                bool l3 = readed_file[i + 3].Equals('g');
                if (l0 && l1 && l2 && l3)
                {
                    count_of_media++;
                }
            }

            
            return count_of_media;
        }
    }

}
