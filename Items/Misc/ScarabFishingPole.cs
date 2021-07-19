using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using RedboidMutilation.Items.Misc;

namespace RedboidMutilation.Items.Misc
{
	public class ScarabFishingPole : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Scarab Fishing Pole");
			Tooltip.SetDefault("'Made of hard chitin, it looks sturdy enough to endure lava'");
			ItemID.Sets.CanFishInLava[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.useStyle = 1;
			item.useAnimation = 8;
			item.useTime = 8;
			item.width = 48;
			item.height = 48;
			item.UseSound = SoundID.Item1;

			//Sets the poles fishing power
			item.fishingPole = 38;

			//Sets the speed in which the bobbers are launched, Wooden Fishing Pole is 9f and Golden Fishing Rod is 17f
			item.shootSpeed = 13f;

			//The Bobber projectile
			item.shoot = ModContent.ProjectileType<Projectiles.ScarabBobber>();
		}

	}
}
