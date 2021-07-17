using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RedboidMutilation.Items.Weapons
{
	public class RestoredHamaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("'After a good cleaning, it looks much better!' \n'Something feels off about the slot in the middle...'");
		}

		public override void SetDefaults()
		{
			item.melee = true;
			item.width = 54;
			item.height = 50;
			item.knockBack = 7;
			item.value = 100000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useStyle = 1;
			item.useTime = 12;
			item.useAnimation = 24;
			item.damage = 30;
			item.axe = 25;
			item.hammer = 80;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "RustedHamaxe");
			recipe.AddIngredient(ItemID.ArmorPolish);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
	}
}