using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace counting_media
{
    public partial class count_media : Form
    {
        // using INter_face to manipulate easly!
        
        ICounting_media count_instance;

        public count_media()
        {
            InitializeComponent();  
            // build an instance :
            
            count_instance = new Counting_mdedia_functions();

            // showing splash screan : 

            Thread new_tread = new Thread(new ThreadStart(StartForm));
            new_tread.Start();
            Thread.Sleep(3000);
            new_tread.Abort();

            Thread new_tread2 = new Thread(new ThreadStart(MainForm));
            new_tread2.Start();
            new_tread2.Abort();

        } 

        private void btn_counting_media_Click(object sender, EventArgs e)
        {
            // filter file extension to choose just htm file! 
            
            openFile.Filter = "html files (*.html)|*.html|xml file(*.xml)|*.xml|text files(*.txt) | *.txt";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // geeting path of file and showoing it :
                
                string path = count_instance.Get_path(openFile.FileName);
                lbl_filepath_output.Text = path;

                // counting <img> tags in html file by Count_of_imgtag_htmlfile functions :   

                int count = count_instance.Count_of_imgtag_htmlfile(path);
                string count_string = Convert.ToString(count);  
                lbl_img_count.Text = count_string;
            }
            else
            {
                MessageBox.Show("Please Select a HTML file!");
            }              
        }

        // showing splash screan:

        public void StartForm()
        {
            Application.Run(new splash_screen());
        }

        // showing main form :

        public void MainForm()
        {
            Application.Run(new count_media());
        }
    }
}
