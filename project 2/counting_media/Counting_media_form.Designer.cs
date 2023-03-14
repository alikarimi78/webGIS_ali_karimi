namespace counting_media
{
    partial class count_media
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(count_media));
            this.lbl_filepath_text = new System.Windows.Forms.Label();
            this.btn_counting_media = new System.Windows.Forms.Button();
            this.lbl_img_text = new System.Windows.Forms.Label();
            this.lbl_filepath_output = new System.Windows.Forms.Label();
            this.lbl_img_count = new System.Windows.Forms.Label();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.lbl_message_show = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_filepath_text
            // 
            this.lbl_filepath_text.Location = new System.Drawing.Point(16, 85);
            this.lbl_filepath_text.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_filepath_text.Name = "lbl_filepath_text";
            this.lbl_filepath_text.Size = new System.Drawing.Size(145, 37);
            this.lbl_filepath_text.TabIndex = 0;
            this.lbl_filepath_text.Text = "file path :";
            this.lbl_filepath_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_counting_media
            // 
            this.btn_counting_media.BackColor = System.Drawing.Color.Red;
            this.btn_counting_media.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_counting_media.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_counting_media.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_counting_media.Location = new System.Drawing.Point(575, 85);
            this.btn_counting_media.Margin = new System.Windows.Forms.Padding(5);
            this.btn_counting_media.Name = "btn_counting_media";
            this.btn_counting_media.Size = new System.Drawing.Size(145, 37);
            this.btn_counting_media.TabIndex = 1;
            this.btn_counting_media.Text = "choosing HTML file";
            this.btn_counting_media.UseVisualStyleBackColor = false;
            this.btn_counting_media.Click += new System.EventHandler(this.btn_counting_media_Click);
            // 
            // lbl_img_text
            // 
            this.lbl_img_text.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_img_text.Location = new System.Drawing.Point(203, 149);
            this.lbl_img_text.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_img_text.Name = "lbl_img_text";
            this.lbl_img_text.Size = new System.Drawing.Size(114, 37);
            this.lbl_img_text.TabIndex = 2;
            this.lbl_img_text.Text = "img count";
            this.lbl_img_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_filepath_output
            // 
            this.lbl_filepath_output.Font = new System.Drawing.Font("Temps Nouveau", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filepath_output.Location = new System.Drawing.Point(171, 85);
            this.lbl_filepath_output.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_filepath_output.Name = "lbl_filepath_output";
            this.lbl_filepath_output.Size = new System.Drawing.Size(394, 37);
            this.lbl_filepath_output.TabIndex = 3;
            this.lbl_filepath_output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_img_count
            // 
            this.lbl_img_count.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_img_count.Location = new System.Drawing.Point(419, 149);
            this.lbl_img_count.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_img_count.Name = "lbl_img_count";
            this.lbl_img_count.Size = new System.Drawing.Size(104, 37);
            this.lbl_img_count.TabIndex = 4;
            this.lbl_img_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // lbl_message_show
            // 
            this.lbl_message_show.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lbl_message_show.Location = new System.Drawing.Point(16, 33);
            this.lbl_message_show.Name = "lbl_message_show";
            this.lbl_message_show.Size = new System.Drawing.Size(704, 26);
            this.lbl_message_show.TabIndex = 5;
            this.lbl_message_show.Text = "Please select a HTML file to display the number of <img> tags ";
            this.lbl_message_show.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // count_media
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(732, 203);
            this.Controls.Add(this.lbl_message_show);
            this.Controls.Add(this.lbl_img_count);
            this.Controls.Add(this.lbl_filepath_output);
            this.Controls.Add(this.lbl_img_text);
            this.Controls.Add(this.btn_counting_media);
            this.Controls.Add(this.lbl_filepath_text);
            this.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "count_media";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "counting media ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_filepath_text;
        private System.Windows.Forms.Button btn_counting_media;
        private System.Windows.Forms.Label lbl_img_text;
        private System.Windows.Forms.Label lbl_filepath_output;
        private System.Windows.Forms.Label lbl_img_count;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        public System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label lbl_message_show;
    }
}

