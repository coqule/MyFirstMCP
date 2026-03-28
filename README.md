# MyFirstMCP

Implementación de un servidor Model Context Protocol (MCP) en .NET 10 con transporte stdio.

## Características

- **Herramienta Echo**: Devuelve un saludo con el mensaje de entrada
- **Herramienta Reverse**: Devuelve el mensaje de entrada en mayúsculas e invertido

## Requisitos

- .NET 10
- C# 14.0

## Ejecutar el servidor

```bash
dotnet run
```

El servidor se iniciará y escuchará mensajes del protocolo MCP a través de entrada/salida estándar.

## Herramientas disponibles

### Echo
```
Echo(mensaje: string) → string
```
Retorna: "Hola " + mensaje

### Reverse
```
Reverse(mensaje: string) → string
```
Retorna el mensaje en mayúsculas e invertido

## Licencia

MIT
