using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RedboidMutilation.Items.Weapons
{
	public class RustedHamaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("'This ancient tool is showing its age' \n'You might be able to remove the rust...'");
		}

		public override void SetDefaults()
		{
			item.melee = true;
			item.width = 54;
			item.height = 50;
			item.knockBack = 7;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useStyle = 1;
			item.useTime = 18;
			item.useAnimation = 28;
			item.damage = 18;
			item.axe = 11;
			item.hammer = 59;
		}

	}

}