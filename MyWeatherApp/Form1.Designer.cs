
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
            this.lblCurrTemp = new System.Windows.Forms.Label();
            this.pnlWeatherPanel = new System.Windows.Forms.Panel();
            this.lblPressure = new System.Windows.Forms.Label();
            this.map = new CefSharp.WinForms.ChromiumWebBrowser();
            this.linkLocation = new System.Windows.Forms.LinkLabel();
            this.lblWeather = new System.Windows.Forms.Label();
            this.tabControlWeather = new System.Windows.Forms.TabControl();
            this.tabDaily = new System.Windows.Forms.TabPage();
            this.tabHourly = new System.Windows.Forms.TabPage();
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
            this.pnlWeatherImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlWeatherImage.BackgroundImage")));
            this.pnlWeatherImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlWeatherImage.Location = new System.Drawing.Point(12, 26);
            this.pnlWeatherImage.Name = "pnlWeatherImage";
            this.pnlWeatherImage.Size = new System.Drawing.Size(100, 100);
            this.pnlWeatherImage.TabIndex = 0;
            // 
            // lblCurrTemp
            // 
            this.lblCurrTemp.AutoSize = true;
            this.lblCurrTemp.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblCurrTemp.Location = new System.Drawing.Point(169, 46);
            this.lblCurrTemp.Name = "lblCurrTemp";
            this.lblCurrTemp.Size = new System.Drawing.Size(46, 30);
            this.lblCurrTemp.TabIndex = 2;
            this.lblCurrTemp.Text = "0°C";
            // 
            // pnlWeatherPanel
            // 
            this.pnlWeatherPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlWeatherPanel.Controls.Add(this.lblPressure);
            this.pnlWeatherPanel.Controls.Add(this.map);
            this.pnlWeatherPanel.Controls.Add(this.linkLocation);
            this.pnlWeatherPanel.Controls.Add(this.lblWeather);
            this.pnlWeatherPanel.Controls.Add(this.lblCurrTemp);
            this.pnlWeatherPanel.Controls.Add(this.pnlWeatherImage);
            this.pnlWeatherPanel.Controls.Add(this.tabControlWeather);
            this.pnlWeatherPanel.Location = new System.Drawing.Point(138, 12);
            this.pnlWeatherPanel.Name = "pnlWeatherPanel";
            this.pnlWeatherPanel.Size = new System.Drawing.Size(635, 419);
            this.pnlWeatherPanel.TabIndex = 4;
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblPressure.Location = new System.Drawing.Point(118, 85);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(71, 20);
            this.lblPressure.TabIndex = 33;
            this.lblPressure.Text = "1000hPa";
            // 
            // map
            // 
            this.map.ActivateBrowserOnCreation = false;
            this.map.Location = new System.Drawing.Point(261, 16);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(361, 146);
            this.map.TabIndex = 32;
            // 
            // linkLocation
            // 
            this.linkLocation.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.linkLocation.AutoSize = true;
            this.linkLocation.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.linkLocation.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLocation.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLocation.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.linkLocation.Location = new System.Drawing.Point(118, 16);
            this.linkLocation.Name = "linkLocation";
            this.linkLocation.Size = new System.Drawing.Size(111, 30);
            this.linkLocation.TabIndex = 31;
            this.linkLocation.TabStop = true;
            this.linkLocation.Text = "Worcester";
            this.linkLocation.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            // 
            // lblWeather
            // 
            this.lblWeather.AutoSize = true;
            this.lblWeather.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeather.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblWeather.Location = new System.Drawing.Point(119, 54);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(44, 20);
            this.lblWeather.TabIndex = 18;
            this.lblWeather.Text = "Clear";
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
            this.tabDaily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabDaily.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabDaily.Location = new System.Drawing.Point(4, 22);
            this.tabDaily.Name = "tabDaily";
            this.tabDaily.Padding = new System.Windows.Forms.Padding(3);
            this.tabDaily.Size = new System.Drawing.Size(602, 212);
            this.tabDaily.TabIndex = 0;
            this.tabDaily.Text = "Daily";
            // 
            // tabHourly
            // 
            this.tabHourly.AutoScroll = true;
            this.tabHourly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabHourly.Location = new System.Drawing.Point(4, 22);
            this.tabHourly.Name = "tabHourly";
            this.tabHourly.Padding = new System.Windows.Forms.Padding(3);
            this.tabHourly.Size = new System.Drawing.Size(602, 212);
            this.tabHourly.TabIndex = 1;
            this.tabHourly.Text = "Hourly";
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
            this.MaximumSize = new System.Drawing.Size(801, 486);
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
        private System.Windows.Forms.Label lblCurrTemp;
        private System.Windows.Forms.Panel pnlWeatherPanel;
        private System.Windows.Forms.Label lblWeather;
        private System.Windows.Forms.TabControl tabControlWeather;
        private System.Windows.Forms.TabPage tabDaily;
        private System.Windows.Forms.TabPage tabHourly;
        private System.Windows.Forms.LinkLabel linkLocation;
        private CefSharp.WinForms.ChromiumWebBrowser map;
        private System.Windows.Forms.Label lblPressure;
    }
}

