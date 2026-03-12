# EnergyManagementTool_NetDaemon

EnergyManagementTool is a C# solution built on **NetDaemon** for Home Assistant.  It provides a framework for energy management features such as battery charging/discharging, solar forecasting, and dynamic tariff reactions. The app is intended to run as a NetDaemon add-on inside Home Assistant.

## Getting Started

1. **Prerequisites**
   - .NET 10 SDK installed
   - Home Assistant with Long-Lived Access Token
   - NetDaemon add-on configured and running

2. **Build the project**
   ```powershell
   cd c:\GitHub_Repos\EnergyManagementTool_NetDaemon
   dotnet build
   ```

3. **Configuration**
   The project follows the NetDaemon getting‑started guide. Configuration is read from `appsettings.json` and (optionally) `appsettings.Development.json`.

   - **appsettings.json** contains mandatory `HomeAssistant` settings (`Host`, `Port`, `Ssl`, `Token`). It also includes sections for `NetDaemon` and `CodeGeneration` to mirror the template.
   - **appsettings.Development.json** should override secrets like the token and is excluded from source control by default.

   Example snippet from `appsettings.json`:
   ```json
   {
     "HomeAssistant": {
       "Host": "homeassistant.local",
       "Port": 8123,
       "Ssl": false,
       "Token": "YOUR_LONG_LIVED_ACCESS_TOKEN"
     }
   }
   ```

   > ⚠️ Always remove sensitive data before committing, or use a development‑only file which is ignored.

4. **Run locally**
   ```powershell
   dotnet run --project EnergyManagementTool.csproj
   ```

   The host will connect to Home Assistant and load any app classes in `Apps/`.

## Project Structure

```
EnergyManagementTool_NetDaemon/
├─ EnergyManagementTool.csproj
├─ Program.cs
├─ Apps/                # NetDaemon app classes
│  └─ EnergyManagerApp.cs
├─ Services/            # custom service implementations (placeholders)
├─ config/
│  └─ appsettings.yaml
└─ README.md
```
