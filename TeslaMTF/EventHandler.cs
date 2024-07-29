using System.Collections.Generic;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;


namespace TeslaMTF
{
    public class TeslaHandler
    {
        public static List<TeslaGate> DisabledTeslaGates { get; private set; } = new List<TeslaGate>();

        public static void OnTriggeringTesla(TriggeringTeslaEventArgs ev)
        {

            if (ev.Player.IsNTF)
            {
                ev.IsAllowed = false;

                ev.IsTriggerable = false;
                Log.Info("Metodo chiamato");
            }
        }




    }
}