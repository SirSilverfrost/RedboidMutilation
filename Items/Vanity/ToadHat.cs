using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace RedboidMutilation.Items.Vanity
{
	[AutoloadEquip(EquipType.Head)]
	public class MushroomHat : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 28;
			item.rare = 1;
			item.vanity = true;
		}

		public override bool DrawHead()
		{
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Mushroom, 8);
			recipe.AddIngredient(ItemID.GlowingMushroom, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}