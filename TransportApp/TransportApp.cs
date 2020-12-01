using SwissTransport;
using System;
using System.Collections.Generic;
using System.Device.Location;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TransportApp
{
  class TransportApp
  {
    ITransport _itransport = new Transport();
    Station station = new Station();
    Connection connection = new Connection();
    Connections connections = new Connections();
    Stations stations = new Stations();
    Transport transport = new Transport();

    public Station GetStationsNearby(string x, string y)
      {
      Stations stations = new Stations();
      stations = transport.GetStationsCoordinates(x, y);
      return stations;
      }  

    private static WebRequest CreateWebRequest(string url)
    {
      var request = WebRequest.Create(url);
      var webProxy = WebRequest.DefaultWebProxy;

      webProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
      request.Proxy = webProxy;

      return request;
    }
  }
}
