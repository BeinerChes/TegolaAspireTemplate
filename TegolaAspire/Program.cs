var builder = DistributedApplication.CreateBuilder(args);

var username = builder.AddParameter("username", secret: true);
var password = builder.AddParameter("password", secret: true);

/*use user secrets to store the username and password */
/*

*/

var postgres = builder.AddPostgres("tegolapostgis", username, password, port: 5432)
    .WithImage("postgis/postgis")
    .WithPgAdmin()
    .WithDataVolume("tegolapostgisdata");


var mapServer = builder.AddDockerfile("tegolamapserver", "Tegola")
    .WithEndpoint(port: 80, targetPort: 80, name: "endpoint", scheme: "http");
    

builder.Build().Run();
