using SwissTransport;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TransportApp
{
    public partial class SearchConnection : Form
    {
        private ITransport _transport = new Transport();                                                // Instanz der Transport Klasse erstellen
        Transport transport = new Transport();                                                          // Neues Objekt transport der Klase Transport erstellen
        Connections connections = new Connections();                                                    // Neues Objekt connections der Klase Connections erstellen
        TransportApp.StationExists stationExists = new TransportApp.StationExists();

        public SearchConnection()
        {
            InitializeComponent();
      
        }

        private void btnSearchConnectionAbort_Click(object sender, EventArgs e)
        {
            Close();                                                                                    // Schliess das Fenster
        }

        private void btnSearchConnectionBack_Click(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu();         // Objekt von MainMenu erstellen:
            this.Close();
            frm.Show();                            // MainMenu anzeigen
                                                   //Dieses Fenster nicht mehr Anzeigen
        }

        private void btnSearchConnection_Click(object sender, EventArgs e)
        {
            if (tbxArrival.Text != "" || tbxDeparture.Text != "")                                       // Zuerst wird eine Validation der Station durchgeführt
            {
                if (stationExists.Station(tbxDeparture.Text))
                {
                    if (stationExists.Station(tbxArrival.Text))
                    {                                                                                   // Die eingegebenen Werte werden an die Funktion "GetConnections" übergeben
                        try
                        {
                            string Date = SearchdateTimePicker.Value.ToString().Substring(startIndex:0, length: 10);
                            string Time = HoursnumericUpDown.Value.ToString() +":" + MinutesnumericUpDown.Value.ToString();
                            
                            connections = transport.GetConnections(tbxDeparture.Text, tbxArrival.Text, Date, Time);
                            FillDataGridView();
                        }
                        catch
                        {
                            Exception ex = new Exception();
                            MessageBox.Show(ex.ToString());
                        }

                    }
                    else
                    {
                        MessageBox.Show("Endstation nicht gefunden");
                    }
                }
                else
                {
                    MessageBox.Show("Abfahrtsstation nicht gefunden.");
                }

            }
            else
            {
                MessageBox.Show("Bitte das Feld 'Abfahrtsstation' und 'Endstation' ausfüllen");
            }

        }
        private void FillDataGridView()
        {
            ConnectionSelectiondataGridView.Rows.Clear();                                           // Datagrid leeren
            int i = 0;

            foreach (Connection connection in connections.ConnectionList)                       // Datagrid mit den Werten füllen
            {
                DateTime DateDeparture = Convert.ToDateTime(connection.From.Departure);
                DateTime DateArrival = Convert.ToDateTime(connection.To.Arrival);
                DateTime InputDateTime = Convert.ToDateTime(SearchdateTimePicker.Value);
                string xCoordinate = connection.From.Station.Coordinate.ToString();
                string Platform = "";
                if (connection.From.Platform != null)
                {
                    Platform = connection.From.Platform.ToString();
                }
                else
                {
                    Platform = "Keine Angabe";
                }
              
                if(connection.From.Delay == null)
                {
                     connection.From.Delay = 0;
                }
                    
                     if (i <= 4)
                     {
                          ConnectionSelectiondataGridView.Rows.Add(
                          Platform,
                          connection.From.Station.Name,
                          connection.To.Station.Name,
                          DateDeparture,
                          DateArrival,
                          connection.Duration.Substring(startIndex: 3, length: 5),
                          connection.From.Delay + " Minute(n)");

                          i++;
                     }
    
            }
            
        }
        private void OnFormLoad(object sender, EventArgs e)
        {
            MinutesnumericUpDown.Value = DateTime.Now.Minute;                               // Beim Laden des Forms werden die aktuellen Daten (Zeit und Datum) übergeben
            HoursnumericUpDown.Value = DateTime.Now.Hour;

            tbxDeparture.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbxDeparture.AutoCompleteSource = AutoCompleteSource.CustomSource;

            tbxArrival.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbxArrival.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string DepartureStation = tbxDeparture.Text;                                    // Der Abfahrtsort und der Ankunftsort werden getauscht
            string ArrivalStation = tbxArrival.Text;
            tbxDeparture.Text = ArrivalStation;
            tbxArrival.Text = DepartureStation;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu();                                               // Objekt von MainMenu erstellen:
            this.Close();                                                                // Form SearchConnection schliessen
            frm.Show();                                                                  // MainMenu anzeigen
        }

        private void tbxDeparture_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbxDeparture.Text.Length >= 1 && tbxDeparture.Text != " ")              // AutoComplition vom Feld Abfahrtsort
                {
                    List<string> temp = new List<string>();
                    foreach (var station in _transport.GetStations(tbxDeparture.Text).StationList)
                    {
                        temp.Add(station.Name);
                    }
                    if (AutoCompletecheckBox.Checked == true)
                    {
                        var autoComplete = new AutoCompleteStringCollection();
                        autoComplete.AddRange(temp.ToArray());
                        tbxDeparture.AutoCompleteCustomSource = autoComplete;
                    }
                    else
                    {
                        var autoComplete = new AutoCompleteStringCollection();
                        autoComplete.Clear();
                        tbxArrival.AutoCompleteCustomSource = autoComplete;
                    }
                }
            }
            catch
            {
                Exception ex = new Exception();
                MessageBox.Show(ex.ToString());
            }

        }
        private void tbxArrival_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbxArrival.Text.Length >= 1 && tbxArrival.Text != " ")              // AutoComplition vom Feld Ankunftsort
                {
                    List<string> temp = new List<string>();
                    foreach (var station in _transport.GetStations(tbxArrival.Text).StationList)
                    {
                        temp.Add(station.Name);
                    }
                    if (AutoCompletecheckBox.Checked == true)
                    {
                        var autoComplete = new AutoCompleteStringCollection();
                        autoComplete.AddRange(temp.ToArray());
                        tbxArrival.AutoCompleteCustomSource = autoComplete;
                    }
                    else
                    {
                        var autoComplete = new AutoCompleteStringCollection();
                        autoComplete.Clear();
                        tbxArrival.AutoCompleteCustomSource = autoComplete;
                    }

                }
            }
            catch
            {
                Exception ex = new Exception();
                MessageBox.Show(ex.ToString());
            }

        }

    private void btnMail_click(object sender, EventArgs e)
    {

      try
      {                                                                         // Die Werte der gewählten Zeile des Datagrids werden in die Mail kopiert
        var dataGridViewlist = new List<string>();
        foreach (DataGridViewRow row in ConnectionSelectiondataGridView.SelectedRows)
        {
          foreach (DataGridViewCell cell in row.Cells)
          {
            dataGridViewlist.Add(cell.Value.ToString());
          }
        }
        if (dataGridViewlist != null) System.Diagnostics.Process.Start("mailto:" + "?subject=Meine Kundenverbindung" + "&body=Gleis: " + dataGridViewlist[0] + ", Von: " + dataGridViewlist[1] + ", Nach: " + dataGridViewlist[2] + ", Abfahrtszeit: " + dataGridViewlist[3] + ", Ankunftszeit: " + dataGridViewlist[4] + ", Dauer: " + dataGridViewlist[5] + ", Verspätung: " + dataGridViewlist[6]);
      }
      catch
      {
        MessageBox.Show("Wählen sie eine Verbindung aus!");
      }
    }
  }
}
