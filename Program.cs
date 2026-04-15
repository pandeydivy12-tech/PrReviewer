using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RelinkMCP;

var builder = Host.CreateEmptyApplicationBuilder(settings: null);


builder.Services.AddMcpServer().WithStdioServerTransport().WithToolsFromAssembly();
InputOutput.Clear();
InputOutput.Log("RELinked MCP Server started");
var app = builder.Build();
await app.RunAsync();