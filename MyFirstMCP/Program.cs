using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ModelContextProtocol.Server;
using System.ComponentModel;

var builder = Host.CreateApplicationBuilder(args);

builder.Logging.AddConsole(o=>o.LogToStandardErrorThreshold = LogLevel.Trace);

builder.Services.AddMcpServer().WithStdioServerTransport().WithToolsFromAssembly();

await builder.Build().RunAsync();

[McpServerToolType]
public static class EchoTools
{
    [McpServerTool, Description("Echo")]
    public static string Echo(string message) => "Hola " + message;

    [McpServerTool, Description("Devuelve el mensaje invertido")]
    public static string Reverse(string message)
        => new([.. message.ToUpper().Reverse()]);

    [McpServerTool, Description("Devuelve la altura de margarito")]
    public static string GetMargaritoHeight() => "Margarito medía 1.15 metros y eso cuando usaba sombrero.";
}