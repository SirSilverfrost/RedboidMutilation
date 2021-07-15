using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RedboidMutilation.Items.Weapons
{
	public class RustedHamaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This ancient tool is showing its age, yet it still looks strong");
		}

		public override void SetDefaults()
		{
			item.melee = true;
			item.width = 54;
			item.height = 50;
			item.scale = .8f;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useStyle = 1;
			item.useTime = 20;
			item.useAnimation = 30;
			item.damage = 18;
			item.axe = 11;
			item.hammer = 59;
		}

	}

}
