using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportApp
{
    public partial class MainMenu : Form
    {
      
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnMainMenuSearchConnection_Click(object sender, EventArgs e)
        {
            SearchConnection frm = new SearchConnection(); // Objekt von SearchConnection erstellen:
            frm.Show(); // SearchConnection anzeigen
            this.Hide();
        }

        private void btnMainMenuAbort_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDepartureList_Click(object sender, EventArgs e)
        {
            DepartureList frm = new DepartureList(); // Objekt von DepartureList erstellen:
            frm.Show(); // DepartureList anzeigen
            this.Hide();
        }

        private void btnMainMenuNavigation_Click(object sender, EventArgs e)
        {
            StationMap frm = new StationMap();
            frm.Show();
            this.Hide();
        }

        private void btnMainMenuNearbyStations_Click(object sender, EventArgs e)
        {
            NearbyStation frm = new NearbyStation();
            frm.Show();
            this.Hide();
        }
    }
}
