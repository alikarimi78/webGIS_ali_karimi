namespace azimuth
{
    partial class azimuth_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(azimuth_form));
            this.point1_label = new System.Windows.Forms.Label();
            this.lat_label = new System.Windows.Forms.Label();
            this.point2_label = new System.Windows.Forms.Label();
            this.lon_label = new System.Windows.Forms.Label();
            this.answer_show = new System.Windows.Forms.Label();
            this.function_button = new System.Windows.Forms.Button();
            this.lat1_text = new System.Windows.Forms.TextBox();
            this.lat2_text = new System.Windows.Forms.TextBox();
            this.long1_text = new System.Windows.Forms.TextBox();
            this.long2_text = new System.Windows.Forms.TextBox();
            this.message_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // point1_label
            // 
            this.point1_label.BackColor = System.Drawing.Color.Coral;
            this.point1_label.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point1_label.Location = new System.Drawing.Point(27, 151);
            this.point1_label.Name = "point1_label";
            this.point1_label.Size = new System.Drawing.Size(104, 43);
            this.point1_label.TabIndex = 0;
            this.point1_label.Text = "point1";
            this.point1_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lat_label
            // 
            this.lat_label.BackColor = System.Drawing.Color.Coral;
            this.lat_label.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lat_label.Location = new System.Drawing.Point(178, 82);
            this.lat_label.Name = "lat_label";
            this.lat_label.Size = new System.Drawing.Size(161, 43);
            this.lat_label.TabIndex = 1;
            this.lat_label.Text = "latitude";
            this.lat_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // point2_label
            // 
            this.point2_label.BackColor = System.Drawing.Color.Coral;
            this.point2_label.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point2_label.Location = new System.Drawing.Point(27, 255);
            this.point2_label.Name = "point2_label";
            this.point2_label.Size = new System.Drawing.Size(104, 43);
            this.point2_label.TabIndex = 2;
            this.point2_label.Text = "point2";
            this.point2_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lon_label
            // 
            this.lon_label.BackColor = System.Drawing.Color.Coral;
            this.lon_label.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lon_label.Location = new System.Drawing.Point(421, 82);
            this.lon_label.Name = "lon_label";
            this.lon_label.Size = new System.Drawing.Size(161, 43);
            this.lon_label.TabIndex = 3;
            this.lon_label.Text = "longitude";
            this.lon_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answer_show
            // 
            this.answer_show.BackColor = System.Drawing.Color.MediumOrchid;
            this.answer_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer_show.Location = new System.Drawing.Point(686, 212);
            this.answer_show.Name = "answer_show";
            this.answer_show.Size = new System.Drawing.Size(233, 88);
            this.answer_show.TabIndex = 4;
            this.answer_show.Text = "azimuth is :";
            this.answer_show.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // function_button
            // 
            this.function_button.BackColor = System.Drawing.Color.MediumOrchid;
            this.function_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.function_button.Location = new System.Drawing.Point(684, 82);
            this.function_button.Name = "function_button";
            this.function_button.Size = new System.Drawing.Size(235, 88);
            this.function_button.TabIndex = 5;
            this.function_button.Text = "click  here to caculate ";
            this.function_button.UseVisualStyleBackColor = false;
            this.function_button.Click += new System.EventHandler(this.function_button_Click);
            // 
            // lat1_text
            // 
            this.lat1_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lat1_text.Location = new System.Drawing.Point(178, 153);
            this.lat1_text.Name = "lat1_text";
            this.lat1_text.Size = new System.Drawing.Size(161, 41);
            this.lat1_text.TabIndex = 1;
            this.lat1_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lat2_text
            // 
            this.lat2_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lat2_text.Location = new System.Drawing.Point(178, 259);
            this.lat2_text.Name = "lat2_text";
            this.lat2_text.Size = new System.Drawing.Size(161, 41);
            this.lat2_text.TabIndex = 3;
            this.lat2_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // long1_text
            // 
            this.long1_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.long1_text.Location = new System.Drawing.Point(421, 149);
            this.long1_text.Name = "long1_text";
            this.long1_text.Size = new System.Drawing.Size(161, 41);
            this.long1_text.TabIndex = 2;
            this.long1_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // long2_text
            // 
            this.long2_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.long2_text.Location = new System.Drawing.Point(421, 259);
            this.long2_text.Name = "long2_text";
            this.long2_text.Size = new System.Drawing.Size(161, 41);
            this.long2_text.TabIndex = 4;
            this.long2_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // message_label
            // 
            this.message_label.BackColor = System.Drawing.Color.Sienna;
            this.message_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message_label.Location = new System.Drawing.Point(30, 21);
            this.message_label.Name = "message_label";
            this.message_label.Size = new System.Drawing.Size(889, 41);
            this.message_label.TabIndex = 6;
            this.message_label.Text = "please enter latitude and longitude (degree) coordinate to caculte  azimuth";
            this.message_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // azimuth_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1032, 420);
            this.Controls.Add(this.message_label);
            this.Controls.Add(this.long2_text);
            this.Controls.Add(this.long1_text);
            this.Controls.Add(this.lat2_text);
            this.Controls.Add(this.lat1_text);
            this.Controls.Add(this.function_button);
            this.Controls.Add(this.answer_show);
            this.Controls.Add(this.lon_label);
            this.Controls.Add(this.point2_label);
            this.Controls.Add(this.lat_label);
            this.Controls.Add(this.point1_label);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "azimuth_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "azmimuth_caculator";
            this.Load += new System.EventHandler(this.azimuth_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label point1_label;
        private System.Windows.Forms.Label lat_label;
        private System.Windows.Forms.Label point2_label;
        private System.Windows.Forms.Label lon_label;
        private System.Windows.Forms.Label answer_show;
        private System.Windows.Forms.Button function_button;
        private System.Windows.Forms.TextBox lat1_text;
        private System.Windows.Forms.TextBox lat2_text;
        private System.Windows.Forms.TextBox long1_text;
        private System.Windows.Forms.TextBox long2_text;
        private System.Windows.Forms.Label message_label;
    }
}

