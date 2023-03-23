namespace ReadingKMLProject
{
    partial class ReadingKmlMainform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadingKmlMainform));
            this.GroupBox_bot = new System.Windows.Forms.GroupBox();
            this.insert_to_database = new System.Windows.Forms.Button();
            this.data_grid_view = new System.Windows.Forms.DataGridView();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.lbl_filepath = new System.Windows.Forms.Label();
            this.lbl_message = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox_bot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_view)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_bot
            // 
            this.GroupBox_bot.Controls.Add(this.insert_to_database);
            this.GroupBox_bot.Controls.Add(this.data_grid_view);
            this.GroupBox_bot.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_bot.Location = new System.Drawing.Point(12, 82);
            this.GroupBox_bot.Margin = new System.Windows.Forms.Padding(20, 20, 3, 3);
            this.GroupBox_bot.Name = "GroupBox_bot";
            this.GroupBox_bot.Size = new System.Drawing.Size(808, 409);
            this.GroupBox_bot.TabIndex = 6;
            this.GroupBox_bot.TabStop = false;
            this.GroupBox_bot.Text = "coordiantes";
            // 
            // insert_to_database
            // 
            this.insert_to_database.BackColor = System.Drawing.Color.DarkGray;
            this.insert_to_database.Location = new System.Drawing.Point(591, 19);
            this.insert_to_database.Margin = new System.Windows.Forms.Padding(4);
            this.insert_to_database.Name = "insert_to_database";
            this.insert_to_database.Size = new System.Drawing.Size(209, 29);
            this.insert_to_database.TabIndex = 3;
            this.insert_to_database.Text = "insert selected file to database";
            this.insert_to_database.UseVisualStyleBackColor = false;
            this.insert_to_database.Click += new System.EventHandler(this.insert_to_database_Click);
            // 
            // data_grid_view
            // 
            this.data_grid_view.AllowUserToAddRows = false;
            this.data_grid_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_grid_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_grid_view.BackgroundColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_grid_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_grid_view.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_grid_view.Location = new System.Drawing.Point(6, 55);
            this.data_grid_view.Name = "data_grid_view";
            this.data_grid_view.ReadOnly = true;
            this.data_grid_view.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_grid_view.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.data_grid_view.RowHeadersWidth = 51;
            this.data_grid_view.RowTemplate.Height = 24;
            this.data_grid_view.Size = new System.Drawing.Size(794, 348);
            this.data_grid_view.TabIndex = 0;
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.BackColor = System.Drawing.Color.DarkGray;
            this.BtnBrowse.Location = new System.Drawing.Point(679, 19);
            this.BtnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(122, 29);
            this.BtnBrowse.TabIndex = 1;
            this.BtnBrowse.Text = "Choose a KML file";
            this.BtnBrowse.UseVisualStyleBackColor = false;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // lbl_filepath
            // 
            this.lbl_filepath.AutoSize = true;
            this.lbl_filepath.Location = new System.Drawing.Point(90, 25);
            this.lbl_filepath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_filepath.Name = "lbl_filepath";
            this.lbl_filepath.Size = new System.Drawing.Size(0, 16);
            this.lbl_filepath.TabIndex = 1;
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(7, 25);
            this.lbl_message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(59, 16);
            this.lbl_message.TabIndex = 0;
            this.lbl_message.Text = "file path :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnBrowse);
            this.groupBox1.Controls.Add(this.lbl_filepath);
            this.groupBox1.Controls.Add(this.lbl_message);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 59);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KML File";
            // 
            // ReadingKmlMainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(832, 503);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBox_bot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReadingKmlMainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reading KML file and connecting to oracle";
            this.GroupBox_bot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_view)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_bot;
        private System.Windows.Forms.DataGridView data_grid_view;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.Label lbl_filepath;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button insert_to_database;
    }
}

