
using BuilderDesignPattern.ConsoleApp;
using System.Net;

var _endpointBuilder = new EndpointBuilder("https://localhost");

_endpointBuilder
    .Append("api")
    .Append("v1")
    .Append("user")
    .AppendParam("id", "5")
    .AppendParam("name", "ali");

var _url = _endpointBuilder.Build();

Console.WriteLine($"_endpointBuilder URL : {_url}");
Console.ReadLine();
