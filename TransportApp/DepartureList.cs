using SwissTransport;
using System;
using System.Windows.Forms;

namespace TransportApp
{
    public partial class DepartureList : Form
    {
        private ITransport _transport = new Transport();                                          // Instanz der Transport Klasse erstellen
        TransportApp.StationExists _stationExists = new TransportApp.StationExists();             // Von eigener Klasse ein Objekt stationexists erzeugen

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
            if(tbxDepartureStation.Text != "")                                                        // Validation der Station
            {
                if (_stationExists.Station(tbxDepartureStation.Text))                  
                {
                    StationBoardRoot stationBoardRoot = new StationBoardRoot();                       // Wert der eingegebener Station der Funktion "GetStationBoard" übergeben
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

        private void FillDataGridView(StationBoardRoot stationBoardRoot)
        {
            StationBoarddataGridView.Rows.Clear();
            foreach (StationBoard stationBoard in stationBoardRoot.Entries)                         // Die erhaltenen Stationen ins DataGridView füllen
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
            MainMenu frm = new MainMenu();                          // Objekt von MainMenu erstellen:
            frm.Show();                                             // MainMenu anzeigen
            this.Hide();    
        }
    }
}
