using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace RedboidMutilation.Items.Accessories
{
	[AutoloadEquip(EquipType.Wings)]
	public class FledglingWings : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("'These wings look very frail, they might not be able to fly very far'");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.accessory = true;
		}
		//these wings use the same values as the solar wings
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 25;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.15f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 1f;
			constantAscend = 0.135f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed *= 1f;
			acceleration *= 1f;
		}
	}
}
