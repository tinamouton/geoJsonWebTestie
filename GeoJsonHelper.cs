using System.Collections.Generic;
using GeoJSON.Net.Feature;
using GeoJSON.Net.Geometry;

namespace GeoJsonTestie.Web
{
    public class GeoJsonHelper
    {
        public static List<GeoShip> Ships()
        {
            var ships = new List<GeoShip>
            {
                new GeoShip
                {
                    Name = "The Black Perl",
                    Captain = "Jack Sparrow",
                    Latitude = -82.456693,
                    Longitude = 27.950701
                },
                new GeoShip
                {
                    Name = "The Jolly Roger",
                    Captain = "Hook",
                    Latitude = -87.524015,
                    Longitude = 30.306161
                }
            };

            return ships;
        }

        public static FeatureCollection FC(List<GeoShip> ships)
        {
            var shipdata = new List<Feature>();
            var spoints = new GeometryCollection();

            foreach (var s in ships)
            {
                spoints.Geometries.Add(new Point(new GeographicPosition(s.Latitude, s.Longitude)));
            }
            shipdata.Add(new Feature(spoints));

            return new FeatureCollection(shipdata);
        }
    }
}