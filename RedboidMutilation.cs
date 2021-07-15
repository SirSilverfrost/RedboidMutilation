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

<<<<<<< Updated upstream
			//Adds a recipe for Super Absorbant Sponge
=======
            //Adds a recipe for super absorbant sponge
>>>>>>> Stashed changes
			recipe.AddIngredient(ItemID.HellstoneBar, 15);
			recipe.AddIngredient(ItemID.Coral, 10);
			recipe.AddIngredient(ItemID.SandBlock, 30);
			recipe.anySand = true;
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(ItemID.SuperAbsorbantSponge);
			recipe.AddRecipe();

			//Adds a recipe for Hotline Fishing Hook
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.HellstoneBar, 14);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.HotlineFishingHook);
			recipe.AddRecipe();

			//Adds a recipe for Piranha Gun
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.JungleKey);
			recipe.AddIngredient(ItemID.Ectoplasm, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.PiranhaGun);
			recipe.AddRecipe();

			//Adds a recipe for Ccourge of the Corruptor
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.CorruptionKey);
			recipe.AddIngredient(ItemID.Ectoplasm, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.ScourgeoftheCorruptor);
			recipe.AddRecipe();

			//Adds a recipe for Vampire Knives
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.CrimsonKey);
			recipe.AddIngredient(ItemID.Ectoplasm, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.VampireKnives);
			recipe.AddRecipe();

			//Adds a recipe for Rainbow Gun
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.HallowedKey);
			recipe.AddIngredient(ItemID.Ectoplasm, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.RainbowGun);
			recipe.AddRecipe();

			//Adds a recipe for Staff of the Frost Hydra
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.FrozenKey);
			recipe.AddIngredient(ItemID.Ectoplasm, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.StaffoftheFrostHydra);
			recipe.AddRecipe();

			//Adds a recipe for Magic Mirror
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.ManaCrystal, 3);
			recipe.AddIngredient(ItemID.Glass, 20);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(ItemID.MagicMirror);
			recipe.AddRecipe();

			//Adds a recipe for Golden Lock Box (gold) 
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Bone, 100);
			recipe.AddIngredient(ItemID.GoldBar, 25);
			recipe.AddTile(TileID.BoneWelder);
			recipe.SetResult(ItemID.LockBox);
			recipe.AddRecipe();

			//Adds a recipe for Golden Lock Box (platinum)
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Bone, 100);
			recipe.AddIngredient(ItemID.PlatinumBar, 25);
			recipe.AddTile(TileID.BoneWelder);
			recipe.SetResult(ItemID.LockBox);
			recipe.AddRecipe();

			//Adds a recipe for Chlorophyte Mask refund
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.ChlorophyteMask);
			recipe.AddTile(TileID.LihzahrdFurnace);
			recipe.SetResult(ItemID.ChlorophyteBar, 4);
			recipe.AddRecipe();

			//Adds a recipe for Chlorophyte Plate Mail refund
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.ChlorophytePlateMail);
			recipe.AddTile(TileID.LihzahrdFurnace);
			recipe.SetResult(ItemID.ChlorophyteBar, 8);
			recipe.AddRecipe();

			//Adds a recipe for Chlorophyte Greaves refund
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.ChlorophyteGreaves);
			recipe.AddTile(TileID.LihzahrdFurnace);
			recipe.SetResult(ItemID.ChlorophyteBar, 6);
			recipe.AddRecipe();

			//Adds a recipe for Chlorophyte Helmet refund
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.ChlorophyteHelmet);
			recipe.AddTile(TileID.LihzahrdFurnace);
			recipe.SetResult(ItemID.ChlorophyteBar, 4);
			recipe.AddRecipe();

			//Adds a recipe for Chlorophyte Headgear refund
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.ChlorophyteHeadgear);
			recipe.AddTile(TileID.LihzahrdFurnace);
			recipe.SetResult(ItemID.ChlorophyteBar, 4);
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

			//Adds a recipe for Forest Ocarina
			recipe = new ModRecipe(this);
			if (thorium != null)
			{
			recipe.AddIngredient(ItemID.ClayBlock, 25);
			recipe.AddIngredient(ItemID.JungleSpores, 15);
			recipe.AddIngredient(thorium.ItemType("ArcaneDust"), 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(thorium.ItemType("ForestOcarina"));
			recipe.AddRecipe();
			}


			//Adds a recipe for The Digester
			recipe = new ModRecipe(this);
			if (thorium != null)
			{
		    recipe.AddIngredient(ItemID.JungleSpores, 15);
			recipe.AddIngredient(thorium.ItemType("LifeQuartz"), 20);
			recipe.AddIngredient(thorium.ItemType("ArcaneDust"), 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(thorium.ItemType("TheDigester"));
			recipe.AddRecipe();
			}
		}
	}
}