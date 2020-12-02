using System;
using System.Device.Location;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using SwissTransport;

namespace TransportApp
{
    public partial class StationMap : Form
    {
        GeoCoordinateWatcher _watcher = new GeoCoordinateWatcher();                         // Objekt für Standortbestimmung erzeugen
        Transport _transport = new Transport();                                             // Objekt von der Klasse Transport erstellen
        TransportApp.StationExists _stationExists = new TransportApp.StationExists();       // Objekt von eigener Klasse TransportApp erstellen

        private double x = 0.0;                                                             // Globale variable für Breiten- und Längengrad
        private double y = 0.0;



        public StationMap()
        {
            InitializeComponent();
            _watcher.Start();                                                               // Startet den Watcher beim Starten des Forms
        }

        private void StationMap_Load(object sender, EventArgs e)
        {
          if (_watcher.Position.Location.IsUnknown)
          {
            MessageBox.Show("Aktueller Standort nicht gefunden");                           // Beim öffnen der Karte wird eine Fehlermeldung angezeigt und die Position auf der Karte wird auf die Firma gesetzt, falls dein Standort nicht bestummen werden konte

             x = 47.1;
             y = 8.1;

             StationgMapControl.DragButton = MouseButtons.Left;
             StationgMapControl.CanDragMap = true;
             StationgMapControl.MapProvider = GMapProviders.GoogleMap;
             StationgMapControl.Position = new PointLatLng(x, y);
             StationgMapControl.MinZoom = 0;
             StationgMapControl.MaxZoom = 24;
             StationgMapControl.Zoom = 10;
             StationgMapControl.AutoScroll = true;

             StationgMapControl.Position = new PointLatLng(x, y);
            }

          else
          {
            x = _watcher.Position.Location.Latitude;                                        // Falls dein Standort bestimmt werden konnte wird dein Standort auf der Karte angezeigt
            y = _watcher.Position.Location.Longitude;
            StationgMapControl.DragButton = MouseButtons.Left;
            StationgMapControl.CanDragMap = true;
            StationgMapControl.MapProvider = GMapProviders.GoogleMap;
            StationgMapControl.Position = new PointLatLng(x, y);
            StationgMapControl.MinZoom = 0;
            StationgMapControl.MaxZoom = 24;
            StationgMapControl.Zoom = 10;
            StationgMapControl.AutoScroll = true;

          }
        }
        private void tbxSearch_Click(object sender, EventArgs e)
        {
            if (tbxStation.Text != "")                                                      // Hier wird eine Validation der eingegebener Station durchgeführt
            {
                if (_stationExists.Station(tbxStation.Text))
                {
                    StationBoardRoot stationBoardRoot = new StationBoardRoot();             // Falls der Standort vorhanden ist, wird eine Funktion ShowMap ausgeführt
                    stationBoardRoot = _transport.GetStationBoard(tbxStation.Text, "");
                    ShowMap(stationBoardRoot);
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

        private void ShowMap(StationBoardRoot stationBoardRoot)
        {
            StationgMapControl.Overlays.Clear();                                            // Zuerst wird die Karte geleert, dann werden Längen und Breitengra der Stationen der zugeteilt
            x = stationBoardRoot.Station.Coordinate.XCoordinate;                            
            y = stationBoardRoot.Station.Coordinate.YCoordinate;
            StationgMapControl.Position = new PointLatLng(x, y);
            StationgMapControl.Zoom = 18;
            StationgMapControl.MarkersEnabled = true;
            PointLatLng point = new PointLatLng(x, y);                                      // Ein Punkt wird auf die Station auf der Karte gesetzt
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_pushpin);


            //Overlay erzeugen
            GMapOverlay markers = new GMapOverlay("makers");

            //Alle markes zum Overlay hinzufügen
            markers.Markers.Add(marker);

            //Overlay covern
            StationgMapControl.Overlays.Add(markers);
        }
    private void btnHome_Click(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu();      // Objekt von MainMenu erstellen:
            frm.Show();                         // MainMenu anzeigen
            this.Hide();
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
    }
}
