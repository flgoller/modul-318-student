using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private ITransport _transport = new Transport();            //Instanz der Transport Klasse erstellen
        StationBoardRoot stationBoard = new StationBoardRoot();                            //Neues Objekt station der Klase Station erstellen
          
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;

        int fileSelection = 0;
        double LatInicial = 20.9688132813906;
        double LngInicial = -89.6250915527344;

        public StationMap()
        {
            InitializeComponent();
        }

        private void StationMap_Load(object sender, EventArgs e)
        {
            StationgMapControl.DragButton = MouseButtons.Left;
            StationgMapControl.CanDragMap = true;
            StationgMapControl.MapProvider = GMapProviders.GoogleMap;
            StationgMapControl.MinZoom = 0;
            StationgMapControl.MaxZoom = 24;
            StationgMapControl.Zoom = 20;
            StationgMapControl.AutoScroll = true;
        }
        private void tbxSearch_Click(object sender, EventArgs e)
        {
            if (tbxStation.Text != "")
            {
                if (StationExists(tbxStation.Text))
                {
                    StationBoardRoot stationBoardRoot = new StationBoardRoot();
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
        GMapOverlay markers = new GMapOverlay();

        private void ShowMap(StationBoardRoot stationBoardRoot)
        {
            StationgMapControl.Overlays.Clear();
            double lat = stationBoardRoot.Station.Coordinate.XCoordinate;
            double lng = stationBoardRoot.Station.Coordinate.YCoordinate;
            StationgMapControl.Position = new PointLatLng(lat, lng);
            StationgMapControl.Zoom = 18;
            StationgMapControl.MarkersEnabled = true;
            PointLatLng point = new PointLatLng(lat, lng);
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
