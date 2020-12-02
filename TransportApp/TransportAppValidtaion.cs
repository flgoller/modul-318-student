using SwissTransport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportApp
{
    class TransportApp
    {
        public class StationExists
        {
            public bool Station(string StationName)
            {
                Stations stations = new Stations();
                Transport _transport = new Transport();
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
        }


    }
}
