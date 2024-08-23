using System.Collections.Generic;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;


namespace TeslaMTF
{
    public class TeslaHandler
    {
        public static void OnTriggeringTesla(TriggeringTeslaEventArgs ev)
        {

            if (ev.Player.IsNTF)
            {
                ev.IsAllowed = false;

                ev.IsTriggerable = false;
            }
        }
    }
}
