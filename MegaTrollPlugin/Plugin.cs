using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaTrollPlugin
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance;

        public override string Author { get; } = "Kurama#7251";

        public override string Name { get; } = "exiled_plugin";

        public override string Prefix { get; } = "exiled_plugin";

        public override Version RequiredExiledVersion => new Version(5, 0, 0);

        public override Version Version => new Version(1, 0, 0);

        public override void OnEnabled()
        {
            Plugin.Instance = this;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
        }
    }
}
