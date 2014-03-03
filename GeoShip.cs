using System.Collections.Generic;

namespace GeoJsonTestie.Web
{
    public class GeoShip
    {
        public string Name { get; set; }
        public string Captain { get; set; }
        public IList<string> Mates { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}