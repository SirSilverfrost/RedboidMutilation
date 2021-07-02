using Terraria.ModLoader;
using Terraria.ID;


namespace RedboidMutilation
{
	public class RedboidMutilation : Mod
	{
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(this);
			Mod thorium = ModLoader.GetMod("ThoriumMod");

			recipe.AddIngredient(ItemID.HellstoneBar, 15);
			recipe.AddIngredient(ItemID.Coral, 10);
			recipe.AddIngredient(ItemID.SandBlock, 30);
			recipe.anySand = true;
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(ItemID.SuperAbsorbantSponge);
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.HellstoneBar, 14);
			recipe.AddTile(TileID.MythrilAnvil);
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


			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.ManaCrystal, 3);
			recipe.AddIngredient(ItemID.Glass, 20);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(ItemID.MagicMirror);
			recipe.AddRecipe();


			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Bone, 100);
			recipe.AddIngredient(ItemID.GoldBar, 25);
			recipe.AddTile(TileID.BoneWelder);
			recipe.SetResult(ItemID.LockBox);
			recipe.AddRecipe();


			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Bone, 100);
			recipe.AddIngredient(ItemID.PlatinumBar, 25);
			recipe.AddTile(TileID.BoneWelder);
			recipe.SetResult(ItemID.LockBox);
			recipe.AddRecipe();


			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.ChlorophyteMask);
			recipe.AddTile(TileID.LihzahrdFurnace);
			recipe.SetResult(ItemID.ChlorophyteBar, 4);
			recipe.AddRecipe();


			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.ChlorophytePlateMail);
			recipe.AddTile(TileID.LihzahrdFurnace);
			recipe.SetResult(ItemID.ChlorophyteBar, 8);
			recipe.AddRecipe();


			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.ChlorophyteGreaves);
			recipe.AddTile(TileID.LihzahrdFurnace);
			recipe.SetResult(ItemID.ChlorophyteBar, 6);
			recipe.AddRecipe();


			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.ChlorophyteHelmet);
			recipe.AddTile(TileID.LihzahrdFurnace);
			recipe.SetResult(ItemID.ChlorophyteBar, 4);
			recipe.AddRecipe();


			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.ChlorophyteHeadgear);
			recipe.AddTile(TileID.LihzahrdFurnace);
			recipe.SetResult(ItemID.ChlorophyteBar, 4);
			recipe.AddRecipe();


			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Candle);
			recipe.AddTile(TileID.CrystalBall);
			recipe.needWater = true;
			recipe.SetResult(ItemID.WaterCandle);
			recipe.AddRecipe();


			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.PlatinumCandle);
			recipe.AddTile(TileID.CrystalBall);
			recipe.needWater = true;
			recipe.SetResult(ItemID.WaterCandle);
			recipe.AddRecipe();

			//Adds a recipe for Pharaoh's Slab
			recipe = new ModRecipe(this);
			if (thorium != null) 
			{
			recipe.AddIngredient(thorium.ItemType("DesertBiomeKey"));
			recipe.AddIngredient(ItemID.Ectoplasm, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(thorium.ItemType("PharaohsSlab"));
			recipe.AddRecipe();
			}
			
			//Adds a recipe for Phoenix Staff
			recipe = new ModRecipe(this);
			if (thorium != null) 
			{
			recipe.AddIngredient(thorium.ItemType("UnderworldBiomeKey"));
			recipe.AddIngredient(ItemID.Ectoplasm, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(thorium.ItemType("PheonixStaff"));
			recipe.AddRecipe();
			}
			
			//Adds a recipe for Fishbone
			recipe = new ModRecipe(this);
			if (thorium != null) 
			{
			recipe.AddIngredient(thorium.ItemType("AquaticDepthsBiomeKey"));
			recipe.AddIngredient(ItemID.Ectoplasm, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(thorium.ItemType("Fishbone"));
			recipe.AddRecipe();
			}

		}
	}
}