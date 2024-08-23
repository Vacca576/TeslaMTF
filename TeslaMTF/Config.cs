using Exiled.API.Interfaces;
using System.ComponentModel;

namespace TeslaConfig
{
    public class Config : IConfig
    {
        [Description("Plugin Enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Debug Enabled?")]
        public bool Debug { get; set; } = false;
    }
}
