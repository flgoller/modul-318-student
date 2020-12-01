using SwissTransport;
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
    public partial class DepartureList : Form
    {
        private ITransport _transport = new Transport();            //Instanz der Transport Klasse erstellen
        public DepartureList()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu();      // Objekt von MainMenu erstellen:
            frm.Show();                         // MainMenu anzeigen
            this.Hide();
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbxSearch_Click(object sender, EventArgs e)
        {
            if(tbxDepartureStation.Text != "")
            {
                if (StationExists(tbxDepartureStation.Text))
                {
                    StationBoardRoot stationBoardRoot = new StationBoardRoot();
                    stationBoardRoot = _transport.GetStationBoard(tbxDepartureStation.Text, "");
                    FillDataGridView(stationBoardRoot);
                }
                else 
                {
                    MessageBox.Show("Station existiert nicht");
                }
            }
            else 
            {
                MessageBox.Show("Bitte das Feld 'Station' ausfüllen");
            }
        
        }
        private bool StationExists(string StationName)
        {
            Stations stations = new Stations();
            stations = _transport.GetStations(StationName);
            foreach (Station station in stations.StationList)
            {
                if (station.Name == StationName)
                {
                    return true;
                }
            }
            return false;
        }


        private void FillDataGridView(StationBoardRoot stationBoardRoot)
        {
            StationBoarddataGridView.Rows.Clear();
            foreach (StationBoard stationBoard in stationBoardRoot.Entries)
            {
                StationBoarddataGridView.Rows.Add(
                    tbxDepartureStation.Text,
                    stationBoard.To,
                    stationBoard.Name
                );
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu();      // Objekt von MainMenu erstellen:
            frm.Show();                         // MainMenu anzeigen
            this.Hide();
        }
    }
}
