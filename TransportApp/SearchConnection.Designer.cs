﻿
namespace TransportApp
{
    partial class SearchConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchConnection));
            this.grpConnectionSearch = new System.Windows.Forms.GroupBox();
            this.AutoCompletecheckBox = new System.Windows.Forms.CheckBox();
            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.HoursnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MinutesnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnChange = new System.Windows.Forms.Button();
            this.SearchdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tbxArrival = new System.Windows.Forms.TextBox();
            this.lblArrivalStation = new System.Windows.Forms.Label();
            this.lblDepartureStation = new System.Windows.Forms.Label();
            this.btnSearchConnection = new System.Windows.Forms.Button();
            this.tbxDeparture = new System.Windows.Forms.TextBox();
            this.btnSearchConnectionBack = new System.Windows.Forms.Button();
            this.btnSearchConnectionAbort = new System.Windows.Forms.Button();
            this.ConnectionSelectiondataGridView = new System.Windows.Forms.DataGridView();
            this.BusTrainNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnMail = new System.Windows.Forms.Button();
            this.grpConnectionSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoursnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionSelectiondataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // grpConnectionSearch
            // 
            this.grpConnectionSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpConnectionSearch.Controls.Add(this.AutoCompletecheckBox);
            this.grpConnectionSearch.Controls.Add(this.lblDepartureTime);
            this.grpConnectionSearch.Controls.Add(this.HoursnumericUpDown);
            this.grpConnectionSearch.Controls.Add(this.MinutesnumericUpDown);
            this.grpConnectionSearch.Controls.Add(this.btnChange);
            this.grpConnectionSearch.Controls.Add(this.SearchdateTimePicker);
            this.grpConnectionSearch.Controls.Add(this.tbxArrival);
            this.grpConnectionSearch.Controls.Add(this.lblArrivalStation);
            this.grpConnectionSearch.Controls.Add(this.lblDepartureStation);
            this.grpConnectionSearch.Controls.Add(this.btnSearchConnection);
            this.grpConnectionSearch.Controls.Add(this.tbxDeparture);
            this.grpConnectionSearch.Location = new System.Drawing.Point(12, 12);
            this.grpConnectionSearch.Name = "grpConnectionSearch";
            this.grpConnectionSearch.Size = new System.Drawing.Size(967, 175);
            this.grpConnectionSearch.TabIndex = 0;
            this.grpConnectionSearch.TabStop = false;
            this.grpConnectionSearch.Text = "Verbindung Suchen";
            // 
            // AutoCompletecheckBox
            // 
            this.AutoCompletecheckBox.AutoSize = true;
            this.AutoCompletecheckBox.Location = new System.Drawing.Point(772, 28);
            this.AutoCompletecheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AutoCompletecheckBox.Name = "AutoCompletecheckBox";
            this.AutoCompletecheckBox.Size = new System.Drawing.Size(101, 24);
            this.AutoCompletecheckBox.TabIndex = 7;
            this.AutoCompletecheckBox.Text = "Suchhilfe";
            this.AutoCompletecheckBox.UseVisualStyleBackColor = true;
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.AutoSize = true;
            this.lblDepartureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartureTime.Location = new System.Drawing.Point(8, 145);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(121, 25);
            this.lblDepartureTime.TabIndex = 7;
            this.lblDepartureTime.Text = "Abfahrtszeit:";
            // 
            // HoursnumericUpDown
            // 
            this.HoursnumericUpDown.Location = new System.Drawing.Point(142, 143);
            this.HoursnumericUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.HoursnumericUpDown.Name = "HoursnumericUpDown";
            this.HoursnumericUpDown.Size = new System.Drawing.Size(75, 26);
            this.HoursnumericUpDown.TabIndex = 2;
            // 
            // MinutesnumericUpDown
            // 
            this.MinutesnumericUpDown.Location = new System.Drawing.Point(219, 143);
            this.MinutesnumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.MinutesnumericUpDown.Name = "MinutesnumericUpDown";
            this.MinutesnumericUpDown.Size = new System.Drawing.Size(75, 26);
            this.MinutesnumericUpDown.TabIndex = 3;
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Image = ((System.Drawing.Image)(resources.GetObject("btnChange.Image")));
            this.btnChange.Location = new System.Drawing.Point(244, 82);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(50, 42);
            this.btnChange.TabIndex = 6;
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // SearchdateTimePicker
            // 
            this.SearchdateTimePicker.Location = new System.Drawing.Point(300, 143);
            this.SearchdateTimePicker.Name = "SearchdateTimePicker";
            this.SearchdateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.SearchdateTimePicker.TabIndex = 4;
            // 
            // tbxArrival
            // 
            this.tbxArrival.Location = new System.Drawing.Point(352, 88);
            this.tbxArrival.Name = "tbxArrival";
            this.tbxArrival.Size = new System.Drawing.Size(172, 26);
            this.tbxArrival.TabIndex = 1;
            this.tbxArrival.TextChanged += new System.EventHandler(this.tbxArrival_TextChanged);
            // 
            // lblArrivalStation
            // 
            this.lblArrivalStation.AutoSize = true;
            this.lblArrivalStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivalStation.Location = new System.Drawing.Point(348, 45);
            this.lblArrivalStation.Name = "lblArrivalStation";
            this.lblArrivalStation.Size = new System.Drawing.Size(115, 26);
            this.lblArrivalStation.TabIndex = 2;
            this.lblArrivalStation.Text = "Endstation";
            // 
            // lblDepartureStation
            // 
            this.lblDepartureStation.AutoSize = true;
            this.lblDepartureStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartureStation.Location = new System.Drawing.Point(6, 45);
            this.lblDepartureStation.Name = "lblDepartureStation";
            this.lblDepartureStation.Size = new System.Drawing.Size(157, 26);
            this.lblDepartureStation.TabIndex = 1;
            this.lblDepartureStation.Text = "Abfahrtsstation";
            // 
            // btnSearchConnection
            // 
            this.btnSearchConnection.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSearchConnection.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchConnection.Location = new System.Drawing.Point(615, 82);
            this.btnSearchConnection.Name = "btnSearchConnection";
            this.btnSearchConnection.Size = new System.Drawing.Size(222, 54);
            this.btnSearchConnection.TabIndex = 5;
            this.btnSearchConnection.Text = "Verbindungen Suchen";
            this.btnSearchConnection.UseVisualStyleBackColor = false;
            this.btnSearchConnection.Click += new System.EventHandler(this.btnSearchConnection_Click);
            // 
            // tbxDeparture
            // 
            this.tbxDeparture.Location = new System.Drawing.Point(10, 88);
            this.tbxDeparture.Name = "tbxDeparture";
            this.tbxDeparture.Size = new System.Drawing.Size(175, 26);
            this.tbxDeparture.TabIndex = 0;
            this.tbxDeparture.TextChanged += new System.EventHandler(this.tbxDeparture_TextChanged);
            // 
            // btnSearchConnectionBack
            // 
            this.btnSearchConnectionBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchConnectionBack.Location = new System.Drawing.Point(1122, 565);
            this.btnSearchConnectionBack.Name = "btnSearchConnectionBack";
            this.btnSearchConnectionBack.Size = new System.Drawing.Size(96, 32);
            this.btnSearchConnectionBack.TabIndex = 10;
            this.btnSearchConnectionBack.Text = "Zurück";
            this.btnSearchConnectionBack.UseVisualStyleBackColor = true;
            this.btnSearchConnectionBack.Click += new System.EventHandler(this.btnSearchConnectionBack_Click);
            // 
            // btnSearchConnectionAbort
            // 
            this.btnSearchConnectionAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchConnectionAbort.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSearchConnectionAbort.Location = new System.Drawing.Point(1240, 565);
            this.btnSearchConnectionAbort.Name = "btnSearchConnectionAbort";
            this.btnSearchConnectionAbort.Size = new System.Drawing.Size(96, 32);
            this.btnSearchConnectionAbort.TabIndex = 11;
            this.btnSearchConnectionAbort.Text = "Abbruch";
            this.btnSearchConnectionAbort.UseVisualStyleBackColor = true;
            this.btnSearchConnectionAbort.Click += new System.EventHandler(this.btnSearchConnectionAbort_Click);
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
            this.ConnectionSelectiondataGridView.Location = new System.Drawing.Point(12, 205);
            this.ConnectionSelectiondataGridView.Name = "ConnectionSelectiondataGridView";
            this.ConnectionSelectiondataGridView.ReadOnly = true;
            this.ConnectionSelectiondataGridView.RowHeadersWidth = 62;
            this.ConnectionSelectiondataGridView.RowTemplate.Height = 28;
            this.ConnectionSelectiondataGridView.Size = new System.Drawing.Size(1269, 274);
            this.ConnectionSelectiondataGridView.TabIndex = 9;
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
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.Image = global::TransportApp.Properties.Resources.Download1;
            this.btnHome.Location = new System.Drawing.Point(1286, 6);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(50, 48);
            this.btnHome.TabIndex = 9;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnMail
            // 
            this.btnMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMail.Image = ((System.Drawing.Image)(resources.GetObject("btnMail.Image")));
            this.btnMail.Location = new System.Drawing.Point(1222, 6);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(56, 48);
            this.btnMail.TabIndex = 8;
            this.btnMail.UseVisualStyleBackColor = true;
            this.btnMail.Click += new System.EventHandler(this.btnMail_click);
            // 
            // SearchConnection
            // 
            this.AcceptButton = this.btnSearchConnection;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSearchConnectionAbort;
            this.ClientSize = new System.Drawing.Size(1353, 614);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.ConnectionSelectiondataGridView);
            this.Controls.Add(this.btnMail);
            this.Controls.Add(this.btnSearchConnectionAbort);
            this.Controls.Add(this.btnSearchConnectionBack);
            this.Controls.Add(this.grpConnectionSearch);
            this.MinimumSize = new System.Drawing.Size(1375, 670);
            this.Name = "SearchConnection";
            this.Text = "Verbindungen";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.grpConnectionSearch.ResumeLayout(false);
            this.grpConnectionSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoursnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionSelectiondataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConnectionSearch;
        private System.Windows.Forms.TextBox tbxArrival;
        private System.Windows.Forms.Label lblArrivalStation;
        private System.Windows.Forms.Label lblDepartureStation;
        private System.Windows.Forms.TextBox tbxDeparture;
        private System.Windows.Forms.DateTimePicker SearchdateTimePicker;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnSearchConnection;
        private System.Windows.Forms.Button btnSearchConnectionBack;
        private System.Windows.Forms.Button btnSearchConnectionAbort;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.DataGridView ConnectionSelectiondataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusTrainNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delay;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblDepartureTime;
        private System.Windows.Forms.NumericUpDown HoursnumericUpDown;
        private System.Windows.Forms.NumericUpDown MinutesnumericUpDown;
        private System.Windows.Forms.CheckBox AutoCompletecheckBox;
  }
}