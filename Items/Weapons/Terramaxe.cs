using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RedboidMutilation.Items.Weapons
{
	public class Terramaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Right click to shoot a Death Sickle \n'The Hamaxe finally reveals its true powers'");
		}

		public override void SetDefaults()
		{
			item.melee = true;
			item.width = 56;
			item.height = 54;
			item.knockBack = 7;
			item.value = 180462;
			item.rare = 7;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useStyle = 1;
			item.useTime = 10;
			item.useAnimation = 20;
			item.damage = 45;
			item.axe = 30;
			item.hammer = 90;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "RestoredHamaxe");
			recipe.AddIngredient(ItemID.BrokenHeroSword);
			recipe.AddIngredient(ItemID.LargeRuby);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				item.shoot = ProjectileID.DeathSickle;
				item.shootSpeed = 10f;
				item.UseSound = SoundID.Item71;
				item.useTime = 30;
				item.useAnimation = 30;
			}
			else
			{
				item.melee = true;
				item.width = 56;
				item.height = 54;
				item.knockBack = 7;
				item.UseSound = SoundID.Item1;
				item.autoReuse = true;
				item.useStyle = 1;
				item.useTime = 10;
				item.useAnimation = 20;
				item.damage = 45;
				item.axe = 30;
				item.hammer = 90;
				item.shoot = ProjectileID.None;
			}
			return base.CanUseItem(player);
	    }
	}
}