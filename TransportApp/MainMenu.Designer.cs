
namespace TransportApp
{
    partial class MainMenu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMainMenuSearchConnection = new System.Windows.Forms.Button();
            this.btnMainMenuNavigation = new System.Windows.Forms.Button();
            this.btnMainMenuNearbyStations = new System.Windows.Forms.Button();
            this.btnMainMenuAbort = new System.Windows.Forms.Button();
            this.lblMainMenuSellectOption = new System.Windows.Forms.Label();
            this.btnDepartureList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMainMenuSearchConnection
            // 
            this.btnMainMenuSearchConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMainMenuSearchConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenuSearchConnection.Location = new System.Drawing.Point(111, 122);
            this.btnMainMenuSearchConnection.Name = "btnMainMenuSearchConnection";
            this.btnMainMenuSearchConnection.Size = new System.Drawing.Size(412, 66);
            this.btnMainMenuSearchConnection.TabIndex = 0;
            this.btnMainMenuSearchConnection.Text = "Verbindung Suchen";
            this.btnMainMenuSearchConnection.UseVisualStyleBackColor = true;
            this.btnMainMenuSearchConnection.Click += new System.EventHandler(this.btnMainMenuSearchConnection_Click);
            // 
            // btnMainMenuNavigation
            // 
            this.btnMainMenuNavigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMainMenuNavigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenuNavigation.Location = new System.Drawing.Point(111, 222);
            this.btnMainMenuNavigation.Name = "btnMainMenuNavigation";
            this.btnMainMenuNavigation.Size = new System.Drawing.Size(412, 66);
            this.btnMainMenuNavigation.TabIndex = 1;
            this.btnMainMenuNavigation.Text = "Navigation zur Station";
            this.btnMainMenuNavigation.UseVisualStyleBackColor = true;
            this.btnMainMenuNavigation.Click += new System.EventHandler(this.btnMainMenuNavigation_Click);
            // 
            // btnMainMenuNearbyStations
            // 
            this.btnMainMenuNearbyStations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMainMenuNearbyStations.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenuNearbyStations.Location = new System.Drawing.Point(111, 415);
            this.btnMainMenuNearbyStations.Name = "btnMainMenuNearbyStations";
            this.btnMainMenuNearbyStations.Size = new System.Drawing.Size(412, 66);
            this.btnMainMenuNearbyStations.TabIndex = 3;
            this.btnMainMenuNearbyStations.Text = "Nahe Stationen";
            this.btnMainMenuNearbyStations.UseVisualStyleBackColor = true;
            this.btnMainMenuNearbyStations.Click += new System.EventHandler(this.btnMainMenuNearbyStations_Click);
            // 
            // btnMainMenuAbort
            // 
            this.btnMainMenuAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMainMenuAbort.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMainMenuAbort.Location = new System.Drawing.Point(572, 472);
            this.btnMainMenuAbort.Name = "btnMainMenuAbort";
            this.btnMainMenuAbort.Size = new System.Drawing.Size(99, 32);
            this.btnMainMenuAbort.TabIndex = 4;
            this.btnMainMenuAbort.Text = "Abbruch";
            this.btnMainMenuAbort.UseVisualStyleBackColor = true;
            this.btnMainMenuAbort.Click += new System.EventHandler(this.btnMainMenuAbort_Click);
            // 
            // lblMainMenuSellectOption
            // 
            this.lblMainMenuSellectOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMainMenuSellectOption.AutoSize = true;
            this.lblMainMenuSellectOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenuSellectOption.Location = new System.Drawing.Point(64, 28);
            this.lblMainMenuSellectOption.Name = "lblMainMenuSellectOption";
            this.lblMainMenuSellectOption.Size = new System.Drawing.Size(563, 55);
            this.lblMainMenuSellectOption.TabIndex = 4;
            this.lblMainMenuSellectOption.Text = "Was wollen Sie machen?";
            // 
            // btnDepartureList
            // 
            this.btnDepartureList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDepartureList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartureList.Location = new System.Drawing.Point(111, 322);
            this.btnDepartureList.Name = "btnDepartureList";
            this.btnDepartureList.Size = new System.Drawing.Size(412, 66);
            this.btnDepartureList.TabIndex = 2;
            this.btnDepartureList.Text = "Abfahrtstafel";
            this.btnDepartureList.UseVisualStyleBackColor = true;
            this.btnDepartureList.Click += new System.EventHandler(this.btnDepartureList_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnMainMenuAbort;
            this.ClientSize = new System.Drawing.Size(680, 508);
            this.Controls.Add(this.btnDepartureList);
            this.Controls.Add(this.lblMainMenuSellectOption);
            this.Controls.Add(this.btnMainMenuAbort);
            this.Controls.Add(this.btnMainMenuNearbyStations);
            this.Controls.Add(this.btnMainMenuNavigation);
            this.Controls.Add(this.btnMainMenuSearchConnection);
            this.MaximumSize = new System.Drawing.Size(702, 564);
            this.MinimumSize = new System.Drawing.Size(702, 564);
            this.Name = "MainMenu";
            this.Text = "Hauptmenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMainMenuSearchConnection;
        private System.Windows.Forms.Button btnMainMenuNavigation;
        private System.Windows.Forms.Button btnMainMenuNearbyStations;
        private System.Windows.Forms.Button btnMainMenuAbort;
        private System.Windows.Forms.Label lblMainMenuSellectOption;
        private System.Windows.Forms.Button btnDepartureList;
    }
}

