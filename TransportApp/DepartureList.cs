using SwissTransport;
using System;
using System.Collections.Generic;
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
            try
            {
                tbxDepartureStation.AutoCompleteMode = AutoCompleteMode.Suggest;
                tbxDepartureStation.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch
            {
                Exception ex = new Exception();
                MessageBox.Show(ex.ToString());
            }
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
            try
            {
                if (tbxDepartureStation.Text != "")                                                        // Validation der Station
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
            catch
            {
                Exception ex = new Exception();
                MessageBox.Show(ex.ToString());
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

        private void tbxDepartureStation_TextChanged(object sender, EventArgs e)
        {
            if (tbxDepartureStation.Text.Length >= 1 && tbxDepartureStation.Text != " ")              // AutoComplition vom Feld Ankunftsort
            {
                List<string> temp = new List<string>();
                foreach (var station in _transport.GetStations(tbxDepartureStation.Text).StationList)
                {
                    try
                    {
                        temp.Add(station.Name);
                    }
                    catch
                    {
                        Exception ex = new Exception();
                        MessageBox.Show(ex.ToString());
                    }
                   
                }
                if (AutoCompletionCheckBox.Checked == true)
                {
                    try
                    {
                        var autoComplete = new AutoCompleteStringCollection();
                        autoComplete.AddRange(temp.ToArray());
                        tbxDepartureStation.AutoCompleteCustomSource = autoComplete;
                    }
                    catch
                    {
                        Exception ex = new Exception();
                        MessageBox.Show(ex.ToString());
                    }
                    
                }
                else
                {
                    try
                    {
                        var autoComplete = new AutoCompleteStringCollection();
                        autoComplete.Clear();
                        tbxDepartureStation.AutoCompleteCustomSource = autoComplete;
                    }
                    catch
                    {
                        Exception ex = new Exception();
                        MessageBox.Show(ex.ToString());
                    }
                   
                }

            }
        }
    }
}
