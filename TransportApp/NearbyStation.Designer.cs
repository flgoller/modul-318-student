
namespace TransportApp
{
    partial class NearbyStation
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.NearbyStationdataGridView = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnTakeMeHome = new System.Windows.Forms.Button();
            this.ConnectionSelectiondataGridView = new System.Windows.Forms.DataGridView();
            this.BusTrainNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yourGps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NearbyStationdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionSelectiondataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // NearbyStationdataGridView
            // 
            this.NearbyStationdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NearbyStationdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NearbyStationdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NearbyStationdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yourGps,
            this.StationName,
            this.Distance});
            this.NearbyStationdataGridView.Location = new System.Drawing.Point(29, 121);
            this.NearbyStationdataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NearbyStationdataGridView.Name = "NearbyStationdataGridView";
            this.NearbyStationdataGridView.ReadOnly = true;
            this.NearbyStationdataGridView.RowHeadersWidth = 62;
            this.NearbyStationdataGridView.Size = new System.Drawing.Size(828, 202);
            this.NearbyStationdataGridView.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSearch.Location = new System.Drawing.Point(29, 42);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(222, 54);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Suche nach Stationen";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnTakeMeHome
            // 
            this.btnTakeMeHome.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnTakeMeHome.Location = new System.Drawing.Point(314, 42);
            this.btnTakeMeHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTakeMeHome.Name = "btnTakeMeHome";
            this.btnTakeMeHome.Size = new System.Drawing.Size(222, 54);
            this.btnTakeMeHome.TabIndex = 10;
            this.btnTakeMeHome.Text = "Take Me Home";
            this.btnTakeMeHome.UseVisualStyleBackColor = false;
            this.btnTakeMeHome.Click += new System.EventHandler(this.btnTakeMeHome_Click);
            // 
            // ConnectionSelectiondataGridView
            // 
            this.ConnectionSelectiondataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectionSelectiondataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ConnectionSelectiondataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConnectionSelectiondataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BusTrainNumber,
            this.DepartureStation,
            this.ArrivalStation,
            this.DepartureTime,
            this.ArrivalTime,
            this.Duration,
            this.Delay});
            this.ConnectionSelectiondataGridView.Location = new System.Drawing.Point(29, 344);
            this.ConnectionSelectiondataGridView.Name = "ConnectionSelectiondataGridView";
            this.ConnectionSelectiondataGridView.ReadOnly = true;
            this.ConnectionSelectiondataGridView.RowHeadersWidth = 62;
            this.ConnectionSelectiondataGridView.RowTemplate.Height = 28;
            this.ConnectionSelectiondataGridView.Size = new System.Drawing.Size(1140, 216);
            this.ConnectionSelectiondataGridView.TabIndex = 11;
            // 
            // BusTrainNumber
            // 
            this.BusTrainNumber.HeaderText = "Platform";
            this.BusTrainNumber.MinimumWidth = 8;
            this.BusTrainNumber.Name = "BusTrainNumber";
            this.BusTrainNumber.ReadOnly = true;
            // 
            // DepartureStation
            // 
            this.DepartureStation.HeaderText = "Abfhartsstation";
            this.DepartureStation.MinimumWidth = 8;
            this.DepartureStation.Name = "DepartureStation";
            this.DepartureStation.ReadOnly = true;
            // 
            // ArrivalStation
            // 
            this.ArrivalStation.HeaderText = "Endstation";
            this.ArrivalStation.MinimumWidth = 8;
            this.ArrivalStation.Name = "ArrivalStation";
            this.ArrivalStation.ReadOnly = true;
            // 
            // DepartureTime
            // 
            this.DepartureTime.HeaderText = "Abfahrtszeit";
            this.DepartureTime.MinimumWidth = 8;
            this.DepartureTime.Name = "DepartureTime";
            this.DepartureTime.ReadOnly = true;
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.HeaderText = "Ankunftszeit";
            this.ArrivalTime.MinimumWidth = 8;
            this.ArrivalTime.Name = "ArrivalTime";
            this.ArrivalTime.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Dauer";
            this.Duration.MinimumWidth = 8;
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // Delay
            // 
            this.Delay.HeaderText = "Verspätung";
            this.Delay.MinimumWidth = 8;
            this.Delay.Name = "Delay";
            this.Delay.ReadOnly = true;
            // 
            // yourGps
            // 
            this.yourGps.HeaderText = "Dein Standort";
            this.yourGps.MinimumWidth = 8;
            this.yourGps.Name = "yourGps";
            this.yourGps.ReadOnly = true;
            // 
            // StationName
            // 
            this.StationName.HeaderText = "Stationsname";
            this.StationName.MinimumWidth = 8;
            this.StationName.Name = "StationName";
            this.StationName.ReadOnly = true;
            // 
            // Distance
            // 
            this.Distance.HeaderText = "Enfernte Distanz";
            this.Distance.MinimumWidth = 8;
            this.Distance.Name = "Distance";
            this.Distance.ReadOnly = true;
            // 
            // NearbyStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 572);
            this.Controls.Add(this.ConnectionSelectiondataGridView);
            this.Controls.Add(this.btnTakeMeHome);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.NearbyStationdataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1203, 628);
            this.Name = "NearbyStation";
            this.Text = "NearbyStation";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NearbyStationdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionSelectiondataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.DataGridView NearbyStationdataGridView;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnTakeMeHome;
        private System.Windows.Forms.DataGridView ConnectionSelectiondataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusTrainNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delay;
        private System.Windows.Forms.DataGridViewTextBoxColumn yourGps;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distance;
    }
}