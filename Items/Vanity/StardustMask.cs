using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace RedboidMutilation.Items.Vanity
{
	[AutoloadEquip(EquipType.Head)]
	public class StargazerMask : ModItem
	{
		public override void SetDefaults()
		{
				item.width = 32;
				item.height = 32;
			    item.expert = true;
				item.vanity = true;
		}

		public override bool DrawHead()
		{
				return false;
		}
	}
}
