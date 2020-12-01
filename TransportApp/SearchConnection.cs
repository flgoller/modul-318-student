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
    public partial class SearchConnection : Form
    {
        private ITransport _transport = new Transport();            //Instanz der Transport Klasse erstellen
        Station station = new Station();                            //Neues Objekt station der Klase Station erstellen
        Stations stations = new Stations();                         //Neues Objekt stations der Klase Stations erstellen
        Transport transport = new Transport();                      //Neues Objekt transport der Klase Transport erstellen
        Connections connections = new Connections();                //Neues Objekt connections der Klase Connections erstellen

        string Email = "";

        public SearchConnection()
        {
            InitializeComponent();
      
        }

        private void btnSearchConnectionAbort_Click(object sender, EventArgs e)
        {
            Close();                                                //Schliess das Fenster
        }

        private void btnSearchConnectionBack_Click(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu();      // Objekt von MainMenu erstellen:
            frm.Show();                         // MainMenu anzeigen
            this.Hide();                        //Dieses Fenster nicht mehr Anzeigen
        }

        private void btnSearchConnection_Click(object sender, EventArgs e)
        {
            if (tbxArrival.Text != "" || tbxDeparture.Text != "")
            {
                if (StationExists(tbxDeparture.Text))
                {
                    if (StationExists(tbxArrival.Text))
                    {
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
            ConnectionSelectiondataGridView.Rows.Clear();       //Datagrid leeren
            int i = 0;

                foreach (Connection connection in connections.ConnectionList)
                {
                DateTime DateDeparture = Convert.ToDateTime(connection.From.Departure);
                DateTime DateArrival = Convert.ToDateTime(connection.To.Arrival);
                DateTime InputDateTime = Convert.ToDateTime(SearchdateTimePicker.Value);
                string xCoordinate = connection.From.Station.Coordinate.ToString();
                     if(connection.From.Delay == null)
                     {
                          connection.From.Delay = 0;
                     }

                    if (i <= 4)
                    {
                          ConnectionSelectiondataGridView.Rows.Add(
                          connection.From.Platform,
                          connection.From.Station.Name,
                          connection.To.Station.Name,
                          DateDeparture,
                          DateArrival,
                          connection.Duration.Substring(startIndex: 3, length: 5),
                          connection.From.Delay + " Minute");

                        i++;
                    }
    
                }
            
        }
        private bool StationExists(string StationName)
        {
            stations = transport.GetStations(StationName);
            foreach (Station station in stations.StationList)
            {
                if (station.Name == StationName)
                {
                    return true;
                }
            }
            return false;
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            MinutesnumericUpDown.Value = DateTime.Now.Minute;
            HoursnumericUpDown.Value = DateTime.Now.Hour;

            tbxDeparture.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbxDeparture.AutoCompleteSource = AutoCompleteSource.CustomSource;

            tbxArrival.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbxArrival.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string DepartureStation = tbxDeparture.Text;
            string ArrivalStation = tbxArrival.Text;
            tbxDeparture.Text = ArrivalStation;
            tbxArrival.Text = DepartureStation;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu();      // Objekt von MainMenu erstellen:
            frm.Show();                         // MainMenu anzeigen
            this.Hide();
        }

        private void tbxDeparture_TextChanged(object sender, EventArgs e)
        {
            if (tbxDeparture.Text.Length >= 1 && tbxDeparture.Text != " ")
            {
                List<string> temp = new List<string>();
                foreach (var station in _transport.GetStations(tbxDeparture.Text).StationList)
                {
                    temp.Add(station.Name);
                }
                if(AutoCompletecheckBox.Checked==true)
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
        private void tbxArrival_TextChanged(object sender, EventArgs e)
        {
            if (tbxArrival.Text.Length >= 1 && tbxArrival.Text != " ")
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

        private void ConnectionSelectiondataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Email = ConnectionSelectiondataGridView.SelectedColumns.ToString();
        }

    private void btnMail_click(object sender, EventArgs e)
    {

      try
      {
        var dataGridViewlist = new List<string>();
        foreach (DataGridViewRow row in ConnectionSelectiondataGridView.SelectedRows)
        {
          foreach (DataGridViewCell cell in row.Cells)
          {
            dataGridViewlist.Add(cell.Value.ToString());
          }
        }
        if (dataGridViewlist != null) System.Diagnostics.Process.Start("mailto:" + "?subject=Meine Verbindung" + "&body=Von: " + dataGridViewlist[0] + " Nach: " + dataGridViewlist[1] + ", Abfahrt: " + dataGridViewlist[2] + " Ankunft: " + dataGridViewlist[3] + ", Gleis: " + dataGridViewlist[4]);
      }
      catch
      {
        MessageBox.Show("Wählen sie eine Reihe aus.");
      }
    }
  }
}
