using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace RedboidMutilation.Items.Vanity
{
	[AutoloadEquip(EquipType.Body)]
	public class MushroomVest : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 20;
			item.rare = 1;
			item.vanity = true;
		}

		public override void DrawHands(ref bool drawHands, ref bool drawArms)
		{
			drawHands = true;
			drawArms = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Mushroom, 10);
			recipe.AddIngredient(ItemID.GlowingMushroom, 30);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
