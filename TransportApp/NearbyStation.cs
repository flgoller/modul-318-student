using SwissTransport;
using System;
using System.Device.Location;
using System.Linq;
using System.Windows.Forms;

namespace TransportApp
{
    public partial class NearbyStation : Form
    {
        private ITransport _itransport = new Transport();
        Transport _transport = new Transport();
        Station _station = new Station();
        Stations _stations = new Stations();
        Connections connections = new Connections();
        GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

        private string arrivalCompany = "Buttisholz, Dorf";                         //Mein Standort der Firma, damit ich nur "Take Me Home" klicken muss

        string Time = "";
        string Date = "";

        public NearbyStation()
        {
            InitializeComponent();
            watcher.Start();

            int minute = DateTime.Now.Minute;
            int hours = DateTime.Now.Hour;
            Time = minute.ToString() + ":" + hours.ToString();
            Date = DateTime.Now.ToString().Substring(startIndex: 0, length: 10);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (watcher.Position.Location.IsUnknown)
            {
                MessageBox.Show("Aktueller Standort nicht gefunden");
            }

            else
            {
                string x = watcher.Position.Location.Latitude.ToString();
                string y = watcher.Position.Location.Longitude.ToString();
                Stations stations = new Stations();
                stations = _transport.GetStationsCoordinates(x, y);
                FillDataGridView(stations);

                NearbyStationdataGridView.Rows[0].Visible = false;                              //Erste Zeile im Grid löschen (Da dies dein Standort ist)
            }
            
            watcher.Stop();
        }
        private void FillDataGridView(Stations stations)
        {
            string yourGps = stations.StationList.First().Name.ToString();
            NearbyStationdataGridView.Rows.Clear();
            foreach (Station station in stations.StationList)
            {
                NearbyStationdataGridView.Rows.Add(yourGps, station.Name, station.Distance + " m");
            }
        }

        private void btnTakeMeHome_Click(object sender, EventArgs e)
        {
            if (watcher.Position.Location.IsUnknown)
            {
                MessageBox.Show("Aktueller Standort nicht gefunden");
            }

            else
            {
                string x = watcher.Position.Location.Latitude.ToString();
                string y = watcher.Position.Location.Longitude.ToString();
                Stations stations = new Stations();
                stations = _transport.GetStationsCoordinates(x, y);
                string departure = "";
                departure = stations.StationList[1].Name.ToString();
                connections = _transport.GetConnections(departure, arrivalCompany, Date, Time);
                FillDataGridView2();
            }

            watcher.Stop();
        }
        private void FillDataGridView2()
        {
            ConnectionSelectiondataGridView.Rows.Clear();       //Datagrid leeren
            int i = 0;

            foreach (Connection connection in connections.ConnectionList)
            {
                DateTime DateDeparture = Convert.ToDateTime(connection.From.Departure);
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
    }
}
