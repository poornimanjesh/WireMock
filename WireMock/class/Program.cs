// See https://aka.ms/new-console-template for more information
using WireMock.Matchers;
using WireMock.RequestBuilders;
using WireMock.ResponseBuilders;
using WireMock.Server;
using WireMock.Settings;

// Insulate the server
// Move the record declaration above the top-level statements to fix CS8803


// Top-level statements
Console.WriteLine("Admin Interface!");

// Replace 'StartAsAdminInterface' /__admin/settings with 'StartAdminInterface' in the settings
var server = WireMockServer.Start(new WireMockServerSettings
{
    Urls = new[] { "http://localhost:8080" },
    StartAdminInterface = true, // Corrected property name
    ReadStaticMappings=true
});
Console.WriteLine("Hello, World!");
//server.Given(
//   Request.Create()
//       .WithPath("/header")
//       .UsingGet()
//)
//.RespondWith(
//   Response.Create()
//       .WithBody("{\"name\":\"Hello this is multi Header testing\"}")
//       .WithHeaders(new Dictionary<string, string>
//       {
//           { "Content-Type", "application/json" },
//           { "X-Header", "Header Value" },
//           { "Cache-Control", "No-cache" }
//       })
//
//);
//
//server.Given(
//   Request.Create()
//       .WithPath("/header")
//       .UsingGet()
//)
//.RespondWith(
//   Response.Create()
//       .WithBody("{\"name\":\"Hello this is multi Header testing\"}")
//       .WithHeaders(new Dictionary<string, string>
//       {
//           { "Content-Type", "application/json" },
//           { "X-Header", "Header Value" },
//           { "Cache-Control", "No-cache" }
//       })
//
//);
//server.Given(
//   Request.Create()
//       .WithPath("/test1")
//       .UsingPut()
//)
//.RespondWith(
//   Response.Create()
//       .WithBody("{\"name\":\"Hello this is test1 put testing\"}")
//       .WithHeaders(new Dictionary<string, string>
//       {
//           { "Content-Type", "application/json" },
//           { "X-Header", "Header Value" },
//           { "Cache-Control", "No-cache" }
//       })
//
//);
//server.Given(
//   Request.Create()
//       .WithPath("/test1")
//       .UsingPost()
//)
//.RespondWith(
//   Response.Create()
//       .WithBody("{\"name\":\"Hello this is test1 post testing\"}")
//       .WithHeaders(new Dictionary<string, string>
//       {
//           { "Content-Type", "application/json" },
//           { "X-Header", "Header Value" },
//           { "Cache-Control", "No-cache" }
//       })
//
//);
////set the headers in dictionary
//server.Given(
//   Request.Create()
//       .WithPath("/test1")
//       .UsingPost()
//)
//.RespondWith(
//   Response.Create()
//       .WithBody("{\"name\":\"Hello this is test1 status code Accepted testing\"}")
//       .WithHeaders(new Dictionary<string, string>
//       {
//           { "Content-Type", "application/json" },
//           { "X-Header", "Header Value" },
//           { "Cache-Control", "No-cache" }
//       })
//   .WithStatusCode(System.Net.HttpStatusCode.Accepted)
//
//);
////match the request with a wildcard matcher
//server.Given(
//   Request.Create()
//       .WithPath(new RegexMatcher("/product/[0-9]+$"))
//       .UsingPost()
//)
//.RespondWith(
//   Response.Create()
//       .WithBody("{\"name\":\"Hello this is test1 RegexMatcher Accepted testing\"}")
//       .WithHeaders(new Dictionary<string, string>
//       {
//           { "Content-Type", "application/json" },
//           { "X-Header", "Header Value" },
//           { "Cache-Control", "No-cache" }
//       })
//   .WithStatusCode(System.Net.HttpStatusCode.Accepted)
//
//);
////match the path with wildcard
//server.Given(
//   Request.Create()
//       .WithPath(new WildcardMatcher("/product/*"))
//       .UsingPost()
//)
//.RespondWith(
//   Response.Create()
//       .WithBody("{\"name\":\"Hello this is test1 wildcardMatcher Accepted testing\"}")
//       .WithHeaders(new Dictionary<string, string>
//       {
//           { "Content-Type", "application/json" },
//           { "X-Header", "Header Value" },
//           { "Cache-Control", "No-cache" }
//       })
//   .WithStatusCode(System.Net.HttpStatusCode.Accepted)
//
//);
////autho
//// Authorization bearer token
//server.Given(
//   Request.Create()
//       .WithPath("/login")
//       .UsingGet()
//       .WithHeader("Authorization", "Bearer:12iuiuiuiuvnb-123-678ghjasjkytyy")
//)
//.RespondWith(
//   Response.Create()
//       .WithBody("{\"name\":\"Hello this is test1 login with bearer token Accepted testing\"}")
//       .WithHeaders(new Dictionary<string, string>
//       {
//           { "Content-Type", "application/json" },
//           { "X-Header", "Header Value" },
//           { "Cache-Control", "No-cache" }
//       })
//   .WithStatusCode(200)
//);
//server.Given(
//   Request.Create()
//       .WithPath("/login")
//       .UsingGet()
//       .WithHeader("Authorization", "Bearer:12iuiuiuiuvnb-123-678ghjasjkytyy")
//)
//.RespondWith(
//   Response.Create()
//       .WithBody("{\"name\":\"Hello this is test1 login with bearer token Accepted testing\"}")
//       .WithHeaders(new Dictionary<string, string>
//       {
//           { "Content-Type", "application/json" },
//           { "X-Header", "Header Value" },
//           { "Cache-Control", "No-cache" }
//       })
//   .WithStatusCode(200)
//
//);
//// bearer code 
//server.Given(
//   Request.Create()
//       .WithPath("/login")
//       .UsingGet()
//       .WithHeader("Authorization", "Bearer:*")
//)
//.RespondWith(
//   Response.Create()
//       .WithBody("{\"name\":\"Hello this is test1 login with bearer token Accepted testing\"}")
//       .WithHeaders(new Dictionary<string, string>
//       {
//           { "Content-Type", "application/json" },
//           { "X-Header", "Header Value" },
//           { "Cache-Control", "No-cache" }
//       })
//   .WithStatusCode(200)
//
//);
//
////  matcher with reject on match
//server.Given(
//   Request.Create()
//       .WithPath("/login")
//       .UsingGet()
//       .WithHeader("Authorization", "*",MatchBehaviour.RejectOnMatch)
//)
//.RespondWith(
//   Response.Create()
//       .WithBody("{\"name\":\"login unsuccessful\"}")
//       .WithHeaders(new Dictionary<string, string>
//       {
//           { "Content-Type", "application/json" },
//           { "X-Header", "Header Value" },
//           { "Cache-Control", "No-cache" }
//       })
//   .WithStatusCode(200)
//
//);
//
////match the path with ExactMatcher
//server.Given(
//   Request.Create()
//       .WithPath(new ExactMatcher("/product1"))
//       .UsingPost()
//)
//.RespondWith(
//   Response.Create()
//       .WithBodyAsJson
//       (new {
//       
//       Name="Poornima Harsha",
//       Job= "Automation tester",
//       City="London"
//       }
//       
//       )
//       .WithHeaders(new Dictionary<string, string>
//       {
//           { "Content-Type", "application/json" },
//           { "X-Header", "Header Value" },
//           { "Cache-Control", "No-cache" }
//       })
//   .WithStatusCode(System.Net.HttpStatusCode.Accepted)
//);
//Console.WriteLine("All the keys are bound");
//
//
////match the path with ExactMatcher with body using product type
//server.Given(
//   Request.Create()
//       .WithPath(new ExactMatcher("/Address"))
//       .UsingPost()
//)
//.RespondWith(
//   Response.Create()
//       .WithBodyAsJson
//       (new Address("London","England","UK" ))
//       
//       .WithHeaders(new Dictionary<string, string>
//       {
//           { "Content-Type", "application/json" },
//           { "X-Header", "Header Value" },
//           { "Cache-Control", "No-cache" }
//       })
//   .WithStatusCode(System.Net.HttpStatusCode.Accepted)
//);
//Console.WriteLine("Press any key to stop the server");
//// Save the static mappings to a file only once else it will overwrite the file
//server.SaveStaticMappings();
Console.ReadKey();

public record Address(string City, string State, string Country);