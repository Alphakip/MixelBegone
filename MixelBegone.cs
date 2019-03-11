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
        internal UserInterface UserInterface;
        public static IDictionary<string, Texture2D> Textures = null;

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
            Textures = (IDictionary<string, Texture2D>)typeof(Mod).GetField("textures", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(this);
            instance = this;

            if (!Main.dedServ)
            {
                UserInterface = new UserInterface();
                Main.itemTexture[3460] = GetTexture("Resprites/Luminite");
            }
        }
    }
}
