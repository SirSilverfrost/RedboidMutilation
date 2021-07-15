using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace RedboidMutilation.Items.Vanity
{
	[AutoloadEquip(EquipType.Legs)]
	public class MoonLordLegs : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 14;
			item.rare = 2;
			item.vanity = true;
		}

		public override bool DrawLegs()
		{
			return false;
		}
	}
}