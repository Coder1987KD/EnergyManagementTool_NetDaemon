using NetDaemon.AppModel;
using Microsoft.Extensions.Logging;

namespace EnergyManagementTool.Apps
{
    [NetDaemonApp(Id = "energy_manager_app")]
    public class EnergyManagerApp
    {
        private readonly ILogger<EnergyManagerApp> _logger;

        // Example: inject services via constructor
        // private readonly IBatteryManager _batteryManager;
        public EnergyManagerApp(ILogger<EnergyManagerApp> logger)
        {
            _logger = logger;
        }

        public void Initialize()
        {
            _logger.LogInformation("EnergyManagerApp initialized");

            // placeholder for logic
            // subscribe to state changes, schedule tasks, etc.

            // Example: inject IHomeAssistantConnection or other services via DI
        }
    }
}
