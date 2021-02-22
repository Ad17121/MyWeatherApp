
namespace MyWeatherApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxWeather = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pnlWeatherImage = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrTemp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFeelsLike = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDewPoint = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPressure = new System.Windows.Forms.Label();
            this.lblWindSpeed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWindDir = new System.Windows.Forms.Label();
            this.pnlWeatherPanel = new System.Windows.Forms.Panel();
            this.lblSunset = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblSunrise = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblWeather = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblWindGust = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControlWeather = new System.Windows.Forms.TabControl();
            this.tabDaily = new System.Windows.Forms.TabPage();
            this.tabHourly = new System.Windows.Forms.TabPage();
            this.webBrowserMap = new System.Windows.Forms.WebBrowser();
            this.pnlWeatherPanel.SuspendLayout();
            this.tabControlWeather.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxWeather
            // 
            this.listBoxWeather.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxWeather.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.listBoxWeather.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxWeather.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxWeather.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxWeather.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.listBoxWeather.FormattingEnabled = true;
            this.listBoxWeather.ItemHeight = 17;
            this.listBoxWeather.Location = new System.Drawing.Point(12, 74);
            this.listBoxWeather.MaximumSize = new System.Drawing.Size(120, 4);
            this.listBoxWeather.MinimumSize = new System.Drawing.Size(120, 361);
            this.listBoxWeather.Name = "listBoxWeather";
            this.listBoxWeather.Size = new System.Drawing.Size(120, 357);
            this.listBoxWeather.TabIndex = 0;
            this.listBoxWeather.SelectedIndexChanged += new System.EventHandler(this.listBoxWeather_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(12, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(120, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(75, 38);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(57, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // pnlWeatherImage
            // 
            this.pnlWeatherImage.BackColor = System.Drawing.Color.Transparent;
            this.pnlWeatherImage.BackgroundImage = global::MyWeatherApp.Properties.Resources._02d;
            this.pnlWeatherImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlWeatherImage.Location = new System.Drawing.Point(12, 16);
            this.pnlWeatherImage.Name = "pnlWeatherImage";
            this.pnlWeatherImage.Size = new System.Drawing.Size(100, 100);
            this.pnlWeatherImage.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(114, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temperature:";
            // 
            // lblCurrTemp
            // 
            this.lblCurrTemp.AutoSize = true;
            this.lblCurrTemp.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblCurrTemp.Location = new System.Drawing.Point(211, 16);
            this.lblCurrTemp.Name = "lblCurrTemp";
            this.lblCurrTemp.Size = new System.Drawing.Size(33, 20);
            this.lblCurrTemp.TabIndex = 2;
            this.lblCurrTemp.Text = "0°C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(136, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Feels Like:";
            // 
            // lblFeelsLike
            // 
            this.lblFeelsLike.AutoSize = true;
            this.lblFeelsLike.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeelsLike.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblFeelsLike.Location = new System.Drawing.Point(211, 49);
            this.lblFeelsLike.Name = "lblFeelsLike";
            this.lblFeelsLike.Size = new System.Drawing.Size(33, 20);
            this.lblFeelsLike.TabIndex = 4;
            this.lblFeelsLike.Text = "0°C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(132, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dew Point:";
            // 
            // lblDewPoint
            // 
            this.lblDewPoint.AutoSize = true;
            this.lblDewPoint.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDewPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblDewPoint.Location = new System.Drawing.Point(211, 83);
            this.lblDewPoint.Name = "lblDewPoint";
            this.lblDewPoint.Size = new System.Drawing.Size(33, 20);
            this.lblDewPoint.TabIndex = 6;
            this.lblDewPoint.Text = "0°C";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label8.Location = new System.Drawing.Point(138, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Humidity:";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblHumidity.Location = new System.Drawing.Point(211, 117);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(31, 20);
            this.lblHumidity.TabIndex = 8;
            this.lblHumidity.Text = "0%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label10.Location = new System.Drawing.Point(224, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Pressure:";
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblPressure.Location = new System.Drawing.Point(292, 166);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(44, 20);
            this.lblPressure.TabIndex = 10;
            this.lblPressure.Text = "0hPa";
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.AutoSize = true;
            this.lblWindSpeed.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblWindSpeed.Location = new System.Drawing.Point(403, 29);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(50, 20);
            this.lblWindSpeed.TabIndex = 12;
            this.lblWindSpeed.Text = "0mph";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(311, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Wind Direction:";
            // 
            // lblWindDir
            // 
            this.lblWindDir.AutoSize = true;
            this.lblWindDir.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblWindDir.Location = new System.Drawing.Point(429, 96);
            this.lblWindDir.Name = "lblWindDir";
            this.lblWindDir.Size = new System.Drawing.Size(24, 20);
            this.lblWindDir.TabIndex = 14;
            this.lblWindDir.Text = "0°";
            // 
            // pnlWeatherPanel
            // 
            this.pnlWeatherPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlWeatherPanel.Controls.Add(this.webBrowserMap);
            this.pnlWeatherPanel.Controls.Add(this.lblSunset);
            this.pnlWeatherPanel.Controls.Add(this.label21);
            this.pnlWeatherPanel.Controls.Add(this.lblSunrise);
            this.pnlWeatherPanel.Controls.Add(this.label19);
            this.pnlWeatherPanel.Controls.Add(this.lblTime);
            this.pnlWeatherPanel.Controls.Add(this.label17);
            this.pnlWeatherPanel.Controls.Add(this.lblWeather);
            this.pnlWeatherPanel.Controls.Add(this.label15);
            this.pnlWeatherPanel.Controls.Add(this.lblWindGust);
            this.pnlWeatherPanel.Controls.Add(this.label13);
            this.pnlWeatherPanel.Controls.Add(this.lblWindDir);
            this.pnlWeatherPanel.Controls.Add(this.label3);
            this.pnlWeatherPanel.Controls.Add(this.lblWindSpeed);
            this.pnlWeatherPanel.Controls.Add(this.label12);
            this.pnlWeatherPanel.Controls.Add(this.lblPressure);
            this.pnlWeatherPanel.Controls.Add(this.label10);
            this.pnlWeatherPanel.Controls.Add(this.lblHumidity);
            this.pnlWeatherPanel.Controls.Add(this.label8);
            this.pnlWeatherPanel.Controls.Add(this.lblDewPoint);
            this.pnlWeatherPanel.Controls.Add(this.label6);
            this.pnlWeatherPanel.Controls.Add(this.lblFeelsLike);
            this.pnlWeatherPanel.Controls.Add(this.label4);
            this.pnlWeatherPanel.Controls.Add(this.lblCurrTemp);
            this.pnlWeatherPanel.Controls.Add(this.label1);
            this.pnlWeatherPanel.Controls.Add(this.pnlWeatherImage);
            this.pnlWeatherPanel.Controls.Add(this.tabControlWeather);
            this.pnlWeatherPanel.Location = new System.Drawing.Point(138, 12);
            this.pnlWeatherPanel.Name = "pnlWeatherPanel";
            this.pnlWeatherPanel.Size = new System.Drawing.Size(635, 419);
            this.pnlWeatherPanel.TabIndex = 4;
            // 
            // lblSunset
            // 
            this.lblSunset.AutoSize = true;
            this.lblSunset.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblSunset.Location = new System.Drawing.Point(292, 132);
            this.lblSunset.Name = "lblSunset";
            this.lblSunset.Size = new System.Drawing.Size(18, 20);
            this.lblSunset.TabIndex = 24;
            this.lblSunset.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label21.Location = new System.Drawing.Point(237, 132);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 20);
            this.label21.TabIndex = 23;
            this.label21.Text = "Sunset:";
            // 
            // lblSunrise
            // 
            this.lblSunrise.AutoSize = true;
            this.lblSunrise.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunrise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblSunrise.Location = new System.Drawing.Point(292, 98);
            this.lblSunrise.Name = "lblSunrise";
            this.lblSunrise.Size = new System.Drawing.Size(18, 20);
            this.lblSunrise.TabIndex = 22;
            this.lblSunrise.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label19.Location = new System.Drawing.Point(233, 98);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 20);
            this.label19.TabIndex = 21;
            this.label19.Text = "Sunrise:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblTime.Location = new System.Drawing.Point(292, 65);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(18, 20);
            this.lblTime.TabIndex = 20;
            this.lblTime.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label17.Location = new System.Drawing.Point(249, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 20);
            this.label17.TabIndex = 19;
            this.label17.Text = "Time:";
            // 
            // lblWeather
            // 
            this.lblWeather.AutoSize = true;
            this.lblWeather.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeather.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblWeather.Location = new System.Drawing.Point(88, 130);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(44, 20);
            this.lblWeather.TabIndex = 18;
            this.lblWeather.Text = "Clear";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label15.Location = new System.Drawing.Point(8, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 20);
            this.label15.TabIndex = 17;
            this.label15.Text = "Weather:";
            // 
            // lblWindGust
            // 
            this.lblWindGust.AutoSize = true;
            this.lblWindGust.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindGust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblWindGust.Location = new System.Drawing.Point(392, 62);
            this.lblWindGust.Name = "lblWindGust";
            this.lblWindGust.Size = new System.Drawing.Size(50, 20);
            this.lblWindGust.TabIndex = 16;
            this.lblWindGust.Text = "0mph";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label13.Location = new System.Drawing.Point(310, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "Wind Gust:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label12.Location = new System.Drawing.Point(311, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Wind Speed:";
            // 
            // tabControlWeather
            // 
            this.tabControlWeather.Controls.Add(this.tabDaily);
            this.tabControlWeather.Controls.Add(this.tabHourly);
            this.tabControlWeather.Location = new System.Drawing.Point(12, 168);
            this.tabControlWeather.Name = "tabControlWeather";
            this.tabControlWeather.SelectedIndex = 0;
            this.tabControlWeather.Size = new System.Drawing.Size(610, 238);
            this.tabControlWeather.TabIndex = 30;
            // 
            // tabDaily
            // 
            this.tabDaily.Location = new System.Drawing.Point(4, 22);
            this.tabDaily.Name = "tabDaily";
            this.tabDaily.Padding = new System.Windows.Forms.Padding(3);
            this.tabDaily.Size = new System.Drawing.Size(602, 212);
            this.tabDaily.TabIndex = 0;
            this.tabDaily.Text = "Daily";
            this.tabDaily.UseVisualStyleBackColor = true;
            // 
            // tabHourly
            // 
            this.tabHourly.AutoScroll = true;
            this.tabHourly.Location = new System.Drawing.Point(4, 22);
            this.tabHourly.Name = "tabHourly";
            this.tabHourly.Padding = new System.Windows.Forms.Padding(3);
            this.tabHourly.Size = new System.Drawing.Size(602, 212);
            this.tabHourly.TabIndex = 1;
            this.tabHourly.Text = "Hourly";
            this.tabHourly.UseVisualStyleBackColor = true;
            // 
            // webBrowserMap
            // 
            this.webBrowserMap.Location = new System.Drawing.Point(459, 14);
            this.webBrowserMap.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserMap.Name = "webBrowserMap";
            this.webBrowserMap.Size = new System.Drawing.Size(150, 150);
            this.webBrowserMap.TabIndex = 31;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(785, 447);
            this.Controls.Add(this.pnlWeatherPanel);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.listBoxWeather);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(801, 486);
            this.Name = "Form1";
            this.Text = "Weather";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlWeatherPanel.ResumeLayout(false);
            this.pnlWeatherPanel.PerformLayout();
            this.tabControlWeather.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxWeather;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel pnlWeatherImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrTemp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFeelsLike;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDewPoint;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.Label lblWindSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWindDir;
        private System.Windows.Forms.Panel pnlWeatherPanel;
        private System.Windows.Forms.Label lblSunset;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblSunrise;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblWeather;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblWindGust;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabControl tabControlWeather;
        private System.Windows.Forms.TabPage tabDaily;
        private System.Windows.Forms.TabPage tabHourly;
        private System.Windows.Forms.WebBrowser webBrowserMap;
    }
}

