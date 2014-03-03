using Nancy;

namespace GeoJsonTestie.Web
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = parameters => "There be pirates ahoy!";

            Get["/pirateships"] = parameters =>
            {
                var pirateships = GeoJsonHelper.Ships();
                return Response.AsJson(GeoJsonHelper.FC(pirateships));
            };
        }
    }
}