using CommandSystem;
using Exiled.API.Extensions;
using Exiled.API.Features;
using PlayerStatsSystem;
using RemoteAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MegaTrollPlugin.Commands
{
    [CommandHandler(typeof(ClientCommandHandler))]
    public class test : ICommand
    {
        public string Command { get; } = "test";

        public string[] Aliases { get; } = { "tt" };

        public string Description { get; } = "Test commands (not work)";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {

            Player troller = Player.Get(sender);
            if (arguments.Array[1].Equals("ambient"))
            {
                Map.PlayAmbientSound(Convert.ToInt32(arguments.Array[2]));
                troller.OpenReportWindow($"<size=30>troll \n ambient {arguments.Array[2]} played");
                response = "troll";
                return true;
            }
            if (arguments.Array[1].Equals("fart"))
            {
                var deceived = Player.List.FirstOrDefault(p => p.Nickname == arguments.Array[2]);
                deceived.PlayGunSound((ItemType)Convert.ToInt32(arguments.Array[3]), Convert.ToByte(arguments.Array[4]));
                troller.OpenReportWindow($"<size=30>troll \n player fart");
                response = "fartttt";
                return true;
            }
            if (arguments.Array[1].Equals("intercom"))
            {
                Map.PlayIntercomSound(true);
                troller.OpenReportWindow($"<size=30>troll \n intercom sound played");
                response = "intercom troll";
                return true;
            }
            if (arguments.Array[1].Equals("window"))
            {
                var windower = Player.List.FirstOrDefault(p => p.Nickname == arguments.Array[2]);
                windower.OpenReportWindow(arguments.Array[3]);
                troller.OpenReportWindow($"<size=30>troll \n send {arguments.Array[3]} to player {arguments.Array[2]}");
                response = "send window troll";
                return true;
            }
            else
            {
                response = "Not work=(";
                return false;
                  
            }
        }
    }
}
