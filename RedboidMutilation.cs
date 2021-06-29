using Terraria.ModLoader;
using Terraria.ID;


namespace RedboidMutilation
{
	public class RedboidMutilation : Mod
	{
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.HellstoneBar, 15);
			recipe.AddIngredient(ItemID.Coral, 10);
			recipe.AddIngredient(ItemID.SandBlock, 30);
			recipe.anySand = true;
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(ItemID.SuperAbsorbantSponge);
			recipe.AddRecipe();



			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.HellstoneBar, 14);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(ItemID.HotlineFishingHook);
			recipe.AddRecipe();


			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.JungleKey);
			recipe.AddIngredient(ItemID.Ectoplasm, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.PiranhaGun);
			recipe.AddRecipe();


			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.CorruptionKey);
			recipe.AddIngredient(ItemID.Ectoplasm, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.ScourgeoftheCorruptor);
			recipe.AddRecipe();


			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.CrimsonKey);
			recipe.AddIngredient(ItemID.Ectoplasm, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.VampireKnives);
			recipe.AddRecipe();


			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.HallowedKey);
			recipe.AddIngredient(ItemID.Ectoplasm, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.RainbowGun);
			recipe.AddRecipe();


			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.FrozenKey);
			recipe.AddIngredient(ItemID.Ectoplasm, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.StaffoftheFrostHydra);
			recipe.AddRecipe();
		}
	}
}