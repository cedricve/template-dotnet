# .NET Web Application Template

A template project for .NET 8 Web API with Dev Container support.

## Project Structure

```
├── .devcontainer/          # Dev Container configuration
│   └── devcontainer.json
├── src/
│   └── WebApp/             # Main web application
│       ├── Controllers/
│       ├── Properties/
│       ├── appsettings.json
│       ├── Program.cs
│       └── WebApp.csproj
├── tests/
│   └── WebApp.Tests/       # Unit tests
│       └── WebApp.Tests.csproj
├── WebApp.sln
└── README.md
```

## Getting Started

### Using Dev Container (Recommended)

1. Install [Docker](https://www.docker.com/get-started) and [VS Code](https://code.visualstudio.com/)
2. Install the [Dev Containers extension](https://marketplace.visualstudio.com/items?itemName=ms-vscode-remote.remote-containers)
3. Open the project folder in VS Code
4. Click "Reopen in Container" when prompted (or use Command Palette: `Dev Containers: Reopen in Container`)
5. Wait for the container to build and start

### Local Development

Ensure you have the [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) installed.

```bash
# Restore dependencies
dotnet restore

# Run the application
dotnet run --project src/WebApp

# Run tests
dotnet test
```

## API Documentation

When running in development mode, Swagger UI is available at:
- http://localhost:5000/swagger
- https://localhost:5001/swagger

## Available Endpoints

- `GET /WeatherForecast` - Returns a list of weather forecasts

## Running Tests

```bash
dotnet test
```

## Building for Production

```bash
dotnet publish -c Release -o ./publish
```

## License

This project is licensed under the MIT License.
