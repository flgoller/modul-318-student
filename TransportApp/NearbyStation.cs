using SwissTransport;
using System;
using System.Device.Location;
using System.Linq;
using System.Windows.Forms;

namespace TransportApp
{
    public partial class NearbyStation : Form
    {
        Transport _transport = new Transport();                                                         // Objekte von Klassen erzeugen
        Connections _connections = new Connections();
        GeoCoordinateWatcher _watcher = new GeoCoordinateWatcher();                 

        private string arrivalCompany = "Buttisholz, Dorf";                                             // Mein Standort der Firma, damit ich nur "Take Me Home" klicken muss

        string Time = "";
        string Date = "";

        public NearbyStation()
        {
            InitializeComponent();
            _watcher.Start();
                
            int minute = DateTime.Now.Minute;                                                           // Aktuelle Uhrzeit und Datum übergeben
            int hours = DateTime.Now.Hour;
            Time = minute.ToString() + ":" + hours.ToString();
            Date = DateTime.Now.ToString().Substring(startIndex: 0, length: 10);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (_watcher.Position.Location.IsUnknown)
            {
                MessageBox.Show("Aktueller Standort nicht gefunden");                                   // Validation von Standort
            }

            else
            {
                string x = _watcher.Position.Location.Latitude.ToString();                              // Dein Standort x und y übergeben
                string y = _watcher.Position.Location.Longitude.ToString();
                Stations stations = new Stations();
                stations = _transport.GetStationsCoordinates(x, y);                                     // Nach x und y in der Funktion "GetStationsCoordinate" filtern
                FillDataGridView(stations);

                NearbyStationdataGridView.Rows[0].Visible = false;                                      // Erste Zeile im Grid löschen (Da dies dein Standort ist)
            }
            
            _watcher.Stop();
        }
        private void FillDataGridView(Stations stations)
        {
            string yourGps = stations.StationList.First().Name.ToString();                              // DataGrid mit den Stationen füllen
            NearbyStationdataGridView.Rows.Clear();
            foreach (Station station in stations.StationList)
            {
                NearbyStationdataGridView.Rows.Add(yourGps, station.Name, station.Distance + " m");
            }
        }

        private void btnTakeMeHome_Click(object sender, EventArgs e)
        {
            if (_watcher.Position.Location.IsUnknown)                                                   // Validation deines Standorts
            {
                MessageBox.Show("Aktueller Standort nicht gefunden");
            }

            else
            {
                try
                {
                    string x = _watcher.Position.Location.Latitude.ToString();                              // Dein Standort x und y übergeben
                    string y = _watcher.Position.Location.Longitude.ToString();
                    Stations stations = new Stations();
                    stations = _transport.GetStationsCoordinates(x, y);                                     // Nach Stationen in der Nähe suchen
                    string departure = "";
                    departure = stations.StationList[1].Name.ToString();                                    // Die nächste Station der Abfahrsstation übergeben
                    _connections = _transport.GetConnections(departure, arrivalCompany, Date, Time);        // Verbindung von deinem Standort zu der Firma suchen
                    FillDataGridViewConnections();
                }
                catch
                {
                    Exception ex = new Exception();
                    MessageBox.Show(ex.ToString());
                }

            }

            _watcher.Stop();
        }
        private void FillDataGridViewConnections()
        {
            ConnectionSelectiondataGridView.Rows.Clear();       //Datagrid leeren
            int i = 0;

            foreach (Connection connection in _connections.ConnectionList)
            {
                DateTime DateDeparture = Convert.ToDateTime(connection.From.Departure);                 //Datagrid mit den Verbindungen befüllen   
                DateTime DateArrival = Convert.ToDateTime(connection.To.Arrival);
                string xCoordinate = connection.From.Station.Coordinate.ToString();
                if (connection.From.Delay == null)
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu();      // Objekt von MainMenu erstellen:
            frm.Show();                         // MainMenu anzeigen
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu();      // Objekt von MainMenu erstellen:
            frm.Show();                         // MainMenu anzeigen
            this.Hide();                        //Dieses Fenster nicht mehr Anzeigen
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
