# MyFirstMCP

A .NET 10 Model Context Protocol (MCP) Server implementation with stdio transport.

## Features

- **Echo Tool**: Returns a greeting with the input message
- **Reverse Tool**: Returns the input message in uppercase and reversed

## Requirements

- .NET 10
- C# 14.0

## Running the Server

```bash
dotnet run
```

The server will start and listen for MCP protocol messages via standard input/output.

## Tools Available

### Echo
```
Echo(message: string) → string
```
Returns: "Hola " + message

### Reverse
```
Reverse(message: string) → string
```
Returns the uppercase reversed message

## License

MIT
