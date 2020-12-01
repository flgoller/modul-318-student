
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
            this.StationgMapControl.Location = new System.Drawing.Point(6, 92);
            this.StationgMapControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.StationgMapControl.Size = new System.Drawing.Size(1091, 600);
            this.StationgMapControl.TabIndex = 0;
            this.StationgMapControl.Zoom = 0D;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(1095, 12);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(50, 48);
            this.btnHome.TabIndex = 12;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbort.Location = new System.Drawing.Point(1010, 702);
            this.btnAbort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(135, 37);
            this.btnAbort.TabIndex = 11;
            this.btnAbort.Text = "Abbruch";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.Location = new System.Drawing.Point(866, 702);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(135, 37);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Zurück";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // tbxStation
            // 
            this.tbxStation.Location = new System.Drawing.Point(96, 34);
            this.tbxStation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxStation.Name = "tbxStation";
            this.tbxStation.Size = new System.Drawing.Size(226, 26);
            this.tbxStation.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSearch.Location = new System.Drawing.Point(387, 18);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(222, 54);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.tbxSearch_Click);
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStation.Location = new System.Drawing.Point(9, 35);
            this.lblStation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(79, 25);
            this.lblStation.TabIndex = 7;
            this.lblStation.Text = "Station:";
            // 
            // StationMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 757);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.tbxStation);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.StationgMapControl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1176, 787);
            this.Name = "StationMap";
            this.Text = "StationMap";
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