namespace heat
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Submit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mytime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.endtime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.Name = "Series1";
            series1.ShadowColor = System.Drawing.Color.White;
            series1.YValuesPerPoint = 3;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1291, 568);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Silver;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(89, 619);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(850, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.Silver;
            this.Submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Submit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Submit.FlatAppearance.BorderSize = 5;
            this.Submit.Font = new System.Drawing.Font("Tempus Sans ITC", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Submit.ForeColor = System.Drawing.Color.Indigo;
            this.Submit.Location = new System.Drawing.Point(1111, 586);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(149, 78);
            this.Submit.TabIndex = 3;
            this.Submit.Text = "New Data";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(427, 641);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Time:";
            // 
            // mytime
            // 
            this.mytime.AutoSize = true;
            this.mytime.BackColor = System.Drawing.Color.Silver;
            this.mytime.Font = new System.Drawing.Font("Tempus Sans ITC", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mytime.ForeColor = System.Drawing.Color.Indigo;
            this.mytime.Location = new System.Drawing.Point(479, 641);
            this.mytime.Name = "mytime";
            this.mytime.Size = new System.Drawing.Size(53, 23);
            this.mytime.TabIndex = 11;
            this.mytime.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(95, 641);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "0";
            // 
            // endtime
            // 
            this.endtime.AutoSize = true;
            this.endtime.BackColor = System.Drawing.Color.Silver;
            this.endtime.Font = new System.Drawing.Font("Tempus Sans ITC", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endtime.ForeColor = System.Drawing.Color.Indigo;
            this.endtime.Location = new System.Drawing.Point(903, 641);
            this.endtime.Name = "endtime";
            this.endtime.Size = new System.Drawing.Size(23, 23);
            this.endtime.TabIndex = 13;
            this.endtime.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(1146, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 80);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cool Tip:\r\nHold your mouse\r\n on the line to \r\nsee the values!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(1146, 529);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Width (cm)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(33, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Temperature (celsius)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(0, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "This is the left side\r\n of the object";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(1133, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 32);
            this.label7.TabIndex = 18;
            this.label7.Text = "This is the right side\r\n of the object";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 693);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endtime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mytime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.chart1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label mytime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label endtime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}