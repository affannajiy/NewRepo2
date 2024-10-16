//Public Static Main is installed itself (Shortcut)
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Lambda Expression: () => "Hello World!"
          //Route: Single Slash is the root
//Get = Grabbing the document
app.MapGet("/", () => "Hello World!");

app.MapGet("/timetable", () => "No class TODAY!");

app.MapGet("/dinner", () => "No food TODAY!");

app.Run();
