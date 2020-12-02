
namespace TransportApp
{
    partial class StationMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StationMap));
            this.StationgMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.tbxStation = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblStation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StationgMapControl
            // 
            this.StationgMapControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StationgMapControl.Bearing = 0F;
            this.StationgMapControl.CanDragMap = true;
            this.StationgMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.StationgMapControl.GrayScaleMode = false;
            this.StationgMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.StationgMapControl.LevelsKeepInMemmory = 5;
            this.StationgMapControl.Location = new System.Drawing.Point(4, 60);
            this.StationgMapControl.MarkersEnabled = true;
            this.StationgMapControl.MaxZoom = 2;
            this.StationgMapControl.MinZoom = 2;
            this.StationgMapControl.MouseWheelZoomEnabled = true;
            this.StationgMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.StationgMapControl.Name = "StationgMapControl";
            this.StationgMapControl.NegativeMode = false;
            this.StationgMapControl.PolygonsEnabled = true;
            this.StationgMapControl.RetryLoadTile = 0;
            this.StationgMapControl.RoutesEnabled = true;
            this.StationgMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.StationgMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.StationgMapControl.ShowTileGridLines = false;
            this.StationgMapControl.Size = new System.Drawing.Size(727, 401);
            this.StationgMapControl.TabIndex = 6;
            this.StationgMapControl.Zoom = 0D;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(729, 8);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(33, 31);
            this.btnHome.TabIndex = 3;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbort.Location = new System.Drawing.Point(673, 478);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(90, 24);
            this.btnAbort.TabIndex = 5;
            this.btnAbort.Text = "Abbruch";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.Location = new System.Drawing.Point(577, 478);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(90, 24);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Zurück";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // tbxStation
            // 
            this.tbxStation.Location = new System.Drawing.Point(64, 22);
            this.tbxStation.Name = "tbxStation";
            this.tbxStation.Size = new System.Drawing.Size(152, 20);
            this.tbxStation.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSearch.Location = new System.Drawing.Point(258, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(148, 35);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.tbxSearch_Click);
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStation.Location = new System.Drawing.Point(6, 23);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(52, 16);
            this.lblStation.TabIndex = 7;
            this.lblStation.Text = "Station:";
            // 
            // StationMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 514);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.tbxStation);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.StationgMapControl);
            this.MinimumSize = new System.Drawing.Size(789, 454);
            this.Name = "StationMap";
            this.Text = "Standort auf Karte anzeigen";
            this.Load += new System.EventHandler(this.StationMap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl StationgMapControl;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox tbxStation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblStation;
    }
}