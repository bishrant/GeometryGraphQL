# GeometryGraphQL

In `Speaker.cs` class, if I use `Geometry` type the HotChocolate cannot figure out the type.
However if I use explicit types such as `Point` or `MultiPolygon` everything works fine.

For the sake of simplicity, I am using SQLLite without adding migrations as I would be using SQL server.
