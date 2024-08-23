using Exiled.API.Features;
using Exiled.Events;
using System;
using TeslaMTF;


namespace Tesla
{
    public class TeslaPlugin : Plugin<Config>
    {
        public override string Name => "TeslaMTF";
        public override string Author => "Vacca";
        public override string Prefix => "TeslaMTF";
        public override Version RequiredExiledVersion => new Version(8,9,11);

        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.TriggeringTesla += TeslaHandler.OnTriggeringTesla;
            base.OnEnabled();
            Log.Info("TeslaMTF Enebled");
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.TriggeringTesla -= TeslaHandler.OnTriggeringTesla;
            base.OnDisabled();
            Log.Info("TeslaMTF Disabled");
        }
    }
}
