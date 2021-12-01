using NetTopologySuite.Geometries;

namespace GraphQL
{
    public record AddSpeakerInput(
           string Name,
           string Bio,
           string WebSite,
            Geometry Geom
        );

}

