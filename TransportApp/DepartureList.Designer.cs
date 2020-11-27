
namespace TransportApp
{
    partial class DepartureList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartureList));
            this.lblStation = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxDepartureStation = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.StationBoarddataGridView = new System.Windows.Forms.DataGridView();
            this.DepartureStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StationBoarddataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStation.Location = new System.Drawing.Point(12, 56);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(52, 16);
            this.lblStation.TabIndex = 0;
            this.lblStation.Text = "Station:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSearch.Location = new System.Drawing.Point(264, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(148, 35);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.tbxSearch_Click);
            // 
            // tbxDepartureStation
            // 
            this.tbxDepartureStation.Location = new System.Drawing.Point(70, 55);
            this.tbxDepartureStation.Name = "tbxDepartureStation";
            this.tbxDepartureStation.Size = new System.Drawing.Size(152, 20);
            this.tbxDepartureStation.TabIndex = 2;
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.Location = new System.Drawing.Point(353, 309);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(90, 24);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Zurück";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbort.Location = new System.Drawing.Point(449, 309);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(90, 24);
            this.btnAbort.TabIndex = 4;
            this.btnAbort.Text = "Abbruch";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // StationBoarddataGridView
            // 
            this.StationBoarddataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StationBoarddataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StationBoarddataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StationBoarddataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartureStation,
            this.ArrivalStation,
            this.Vehicle});
            this.StationBoarddataGridView.Location = new System.Drawing.Point(12, 105);
            this.StationBoarddataGridView.Name = "StationBoarddataGridView";
            this.StationBoarddataGridView.Size = new System.Drawing.Size(418, 176);
            this.StationBoarddataGridView.TabIndex = 5;
            // 
            // DepartureStation
            // 
            this.DepartureStation.HeaderText = "Abfahrtsstation";
            this.DepartureStation.Name = "DepartureStation";
            // 
            // ArrivalStation
            // 
            this.ArrivalStation.HeaderText = "Ankunftsstation";
            this.ArrivalStation.Name = "ArrivalStation";
            // 
            // Vehicle
            // 
            this.Vehicle.HeaderText = "Verkehrsmittel";
            this.Vehicle.Name = "Vehicle";
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(506, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(33, 31);
            this.btnHome.TabIndex = 6;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // DepartureList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 345);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.StationBoarddataGridView);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.tbxDepartureStation);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblStation);
            this.MinimumSize = new System.Drawing.Size(567, 384);
            this.Name = "DepartureList";
            this.Text = "DepartureList";
            ((System.ComponentModel.ISupportInitialize)(this.StationBoarddataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxDepartureStation;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.DataGridView StationBoarddataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehicle;
        private System.Windows.Forms.Button btnHome;
    }
}