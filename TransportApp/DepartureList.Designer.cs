
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
            this.AutoCompletionCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.StationBoarddataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStation.Location = new System.Drawing.Point(18, 86);
            this.lblStation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(79, 25);
            this.lblStation.TabIndex = 0;
            this.lblStation.Text = "Station:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSearch.Location = new System.Drawing.Point(396, 69);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(222, 54);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.tbxSearch_Click);
            // 
            // tbxDepartureStation
            // 
            this.tbxDepartureStation.Location = new System.Drawing.Point(105, 85);
            this.tbxDepartureStation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxDepartureStation.Name = "tbxDepartureStation";
            this.tbxDepartureStation.Size = new System.Drawing.Size(226, 26);
            this.tbxDepartureStation.TabIndex = 0;
            this.tbxDepartureStation.TextChanged += new System.EventHandler(this.tbxDepartureStation_TextChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.Location = new System.Drawing.Point(530, 475);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(135, 37);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Zurück";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbort.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAbort.Location = new System.Drawing.Point(674, 475);
            this.btnAbort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(135, 37);
            this.btnAbort.TabIndex = 5;
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
            this.StationBoarddataGridView.Location = new System.Drawing.Point(18, 162);
            this.StationBoarddataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StationBoarddataGridView.Name = "StationBoarddataGridView";
            this.StationBoarddataGridView.RowHeadersWidth = 62;
            this.StationBoarddataGridView.Size = new System.Drawing.Size(627, 271);
            this.StationBoarddataGridView.TabIndex = 2;
            // 
            // DepartureStation
            // 
            this.DepartureStation.HeaderText = "Abfahrtsstation";
            this.DepartureStation.MinimumWidth = 8;
            this.DepartureStation.Name = "DepartureStation";
            // 
            // ArrivalStation
            // 
            this.ArrivalStation.HeaderText = "Ankunftsstation";
            this.ArrivalStation.MinimumWidth = 8;
            this.ArrivalStation.Name = "ArrivalStation";
            // 
            // Vehicle
            // 
            this.Vehicle.HeaderText = "Verkehrsmittel";
            this.Vehicle.MinimumWidth = 8;
            this.Vehicle.Name = "Vehicle";
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(759, 18);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(50, 48);
            this.btnHome.TabIndex = 3;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // AutoCompletionCheckBox
            // 
            this.AutoCompletionCheckBox.AutoSize = true;
            this.AutoCompletionCheckBox.Location = new System.Drawing.Point(105, 126);
            this.AutoCompletionCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AutoCompletionCheckBox.Name = "AutoCompletionCheckBox";
            this.AutoCompletionCheckBox.Size = new System.Drawing.Size(101, 24);
            this.AutoCompletionCheckBox.TabIndex = 6;
            this.AutoCompletionCheckBox.Text = "Suchhilfe";
            this.AutoCompletionCheckBox.UseVisualStyleBackColor = true;
            // 
            // DepartureList
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAbort;
            this.ClientSize = new System.Drawing.Size(826, 531);
            this.Controls.Add(this.AutoCompletionCheckBox);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.StationBoarddataGridView);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.tbxDepartureStation);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblStation);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(836, 551);
            this.Name = "DepartureList";
            this.Text = "Abfahrtstafel";
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
        private System.Windows.Forms.CheckBox AutoCompletionCheckBox;
    }
}