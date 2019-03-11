using Terraria.ModLoader;
using Terraria;
using Terraria.UI;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.Reflection;

namespace MixelBegone
{
	class MixelBegone : Mod
	{
        internal static MixelBegone instance;

        public MixelBegone()
		{
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true,
                AutoloadBackgrounds = true
            };
            instance = this;
        }

        public override void Load()
        {
            instance = this;

            if (!Main.dedServ)
            {
                Main.itemTexture[3460] = GetTexture("Resprites/Luminite");
                Main.itemTexture[551] = GetTexture("Resprites/HallowedPlate");
            }
        }

        public override void Unload()
        {
            instance = null;
        }
    }
}
