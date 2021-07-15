using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace RedboidMutilation.Items.Vanity
{
	[AutoloadEquip(EquipType.Shoes)]
	public class GlassSlipper : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 38;
			item.height = 26;
			item.rare = 5;
			item.vanity = true;
			item.accessory = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumCoin, 1);
			recipe.AddIngredient(ItemID.Glass, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}