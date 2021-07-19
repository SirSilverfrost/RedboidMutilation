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

            //Adds a recipe for super absorbant sponge
			recipe.AddIngredient(ItemID.HellstoneBar, 15);
			recipe.AddIngredient(ItemID.Coral, 10);
			recipe.AddIngredient(ItemID.SandBlock, 30);
			recipe.anySand = true;
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(ItemID.SuperAbsorbantSponge);
			recipe.AddRecipe();

			//Adds a recipe for piranha gun
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.JungleKey);
			recipe.AddIngredient(ItemID.Ectoplasm, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.PiranhaGun);
			recipe.AddRecipe();

			//Adds a recipe for scourge of the corruptor
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.CorruptionKey);
			recipe.AddIngredient(ItemID.Ectoplasm, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.ScourgeoftheCorruptor);
			recipe.AddRecipe();

			//Adds a recipe for vampire knives
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.CrimsonKey);
			recipe.AddIngredient(ItemID.Ectoplasm, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.VampireKnives);
			recipe.AddRecipe();

			//Adds a recipe for rainbow gun
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.HallowedKey);
			recipe.AddIngredient(ItemID.Ectoplasm, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.RainbowGun);
			recipe.AddRecipe();

			//Adds a recipe for staff of the frost hydra
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.FrozenKey);
			recipe.AddIngredient(ItemID.Ectoplasm, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.StaffoftheFrostHydra);
			recipe.AddRecipe();

			//Adds a recipe for magic mirror
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.ManaCrystal, 3);
			recipe.AddIngredient(ItemID.Glass, 20);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(ItemID.MagicMirror);
			recipe.AddRecipe();

			//Adds a recipe for lock box (gold)
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Bone, 100);
			recipe.AddIngredient(ItemID.GoldBar, 25);
			recipe.AddTile(TileID.BoneWelder);
			recipe.SetResult(ItemID.LockBox);
			recipe.AddRecipe();

			//Adds a recipe for lock box (platinum)
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Bone, 100);
			recipe.AddIngredient(ItemID.PlatinumBar, 25);
			recipe.AddTile(TileID.BoneWelder);
			recipe.SetResult(ItemID.LockBox);
			recipe.AddRecipe();

			//Adds a recipe for chlorophyte refund
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.ChlorophyteMask);
			recipe.AddTile(TileID.LihzahrdFurnace);
			recipe.SetResult(ItemID.ChlorophyteBar, 4);
			recipe.AddRecipe();

			//Adds a recipe for chlorophyte refund
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.ChlorophytePlateMail);
			recipe.AddTile(TileID.LihzahrdFurnace);
			recipe.SetResult(ItemID.ChlorophyteBar, 8);
			recipe.AddRecipe();

			//Adds a recipe for chlorophyte refund
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.ChlorophyteGreaves);
			recipe.AddTile(TileID.LihzahrdFurnace);
			recipe.SetResult(ItemID.ChlorophyteBar, 6);
			recipe.AddRecipe();

			//Adds a recipe for chlorophyte refund
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.ChlorophyteHelmet);
			recipe.AddTile(TileID.LihzahrdFurnace);
			recipe.SetResult(ItemID.ChlorophyteBar, 4);
			recipe.AddRecipe();

			//Adds a recipe for chlorophyte refund
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

			//Adds a recipe for Living Loom
			recipe = new ModRecipe(this);
			recipe.AddRecipeGroup("Wood", 50);
			recipe.AddIngredient(ItemID.VineRope, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.LivingLoom);
			recipe.AddRecipe();

			//Adds a recipe for Guide to Plant Fiber Cordage
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Book, 1);
			recipe.AddIngredient(ItemID.Vine, 5);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(ItemID.CordageGuide);
			recipe.AddRecipe();

			//Adds a recipe for Living Wood Wand
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Wood, 20);
			recipe.AddTile(TileID.LivingLoom);
			recipe.SetResult(ItemID.LivingWoodWand);
			recipe.AddRecipe();

			//Adds a recipe for Leaf Wand
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Wood, 20);
			recipe.AddTile(TileID.LivingLoom);
			recipe.SetResult(ItemID.LeafWand);
			recipe.AddRecipe();

			//Adds a recipe for Living Mahogany Wand
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.RichMahogany, 20);
			recipe.AddTile(TileID.LivingLoom);
			recipe.SetResult(ItemID.LivingMahoganyWand);
			recipe.AddRecipe();

			//Adds a recipe for Rich Mahogany Leaf Wand
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.RichMahogany, 20);
			recipe.AddTile(TileID.LivingLoom);
			recipe.SetResult(ItemID.LivingMahoganyLeafWand);
			recipe.AddRecipe();

			//Adds a recipe for Shoe Spikes
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Spike, 15);
			recipe.AddRecipeGroup("IronBar", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ShoeSpikes);
			recipe.AddRecipe();

			//Adds a recipe for Climbing Claws
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Spike, 10);
			recipe.AddRecipeGroup("IronBar", 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ClimbingClaws);
			recipe.AddRecipe();

			//Adds a recipe for Anklet Of The Wind
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.JungleRose);
			recipe.AddIngredient(ItemID.Vine, 10);
			recipe.AddIngredient(ItemID.JungleSpores, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.AnkletoftheWind);
			recipe.AddRecipe();

			//Adds a recipe for Bone Welder
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Bone, 100);
			recipe.AddIngredient(ItemID.Wire, 15);
			recipe.AddRecipeGroup("IronBar", 15);
			recipe.AddTile(TileID.HeavyWorkBench);
			recipe.SetResult(ItemID.BoneWelder);
			recipe.AddRecipe();

			//Adds a recipe for Tombstone
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.StoneBlock, 50);
			recipe.AddTile(TileID.HeavyWorkBench);
			recipe.SetResult(ItemID.Tombstone);
			recipe.AddRecipe();

			//Adds a recipe for Grave Marker
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.StoneBlock, 50);
			recipe.AddTile(TileID.HeavyWorkBench);
			recipe.SetResult(ItemID.GraveMarker);
			recipe.AddRecipe();

			//Adds a recipe for Cross Grave Marker
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.StoneBlock, 50);
			recipe.AddTile(TileID.HeavyWorkBench);
			recipe.SetResult(ItemID.CrossGraveMarker);
			recipe.AddRecipe();

			//Adds a recipe for Headstone
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.StoneBlock, 50);
			recipe.AddTile(TileID.HeavyWorkBench);
			recipe.SetResult(ItemID.Headstone);
			recipe.AddRecipe();

			//Adds a recipe for Gravestone
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.StoneBlock, 50);
			recipe.AddTile(TileID.HeavyWorkBench);
			recipe.SetResult(ItemID.Gravestone);
			recipe.AddRecipe();

			//Adds a recipe for Obelisk
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.StoneBlock, 50);
			recipe.AddTile(TileID.HeavyWorkBench);
			recipe.SetResult(ItemID.Obelisk);
			recipe.AddRecipe();

			//Adds a recipe for Golden Tombstone
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.StoneBlock, 50);
			recipe.AddIngredient(ItemID.GoldCoin);
			recipe.AddTile(TileID.HeavyWorkBench);
			recipe.SetResult(ItemID.RichGravestone1);
			recipe.AddRecipe();

			//Adds a recipe for Golden Grave Marker
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.StoneBlock, 50);
			recipe.AddIngredient(ItemID.GoldCoin);
			recipe.AddTile(TileID.HeavyWorkBench);
			recipe.SetResult(ItemID.RichGravestone2);
			recipe.AddRecipe();

			//Adds a recipe for Golden Cross Grave Marker
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.StoneBlock, 50);
			recipe.AddIngredient(ItemID.GoldCoin);
			recipe.AddTile(TileID.HeavyWorkBench);
			recipe.SetResult(ItemID.RichGravestone3);
			recipe.AddRecipe();

			//Adds a recipe for Golden Headstone
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.StoneBlock, 50);
			recipe.AddIngredient(ItemID.GoldCoin);
			recipe.AddTile(TileID.HeavyWorkBench);
			recipe.SetResult(ItemID.RichGravestone4);
			recipe.AddRecipe();

			//Adds a recipe for Golden Gravestone
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.StoneBlock, 50);
			recipe.AddIngredient(ItemID.GoldCoin);
			recipe.AddTile(TileID.HeavyWorkBench);
			recipe.SetResult(ItemID.RichGravestone5);
			recipe.AddRecipe();
		}
	}
}