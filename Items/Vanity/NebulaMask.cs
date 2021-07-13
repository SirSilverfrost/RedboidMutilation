using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace RedboidMutilation.Items.Vanity
{
	[AutoloadEquip(EquipType.Head)]
	public class PredictorMask : ModItem
	{
		public override void SetDefaults()
		{
				item.width = 29;
				item.height = 30;
			    item.expert = true;
				item.vanity = true;
		}

		public override bool DrawHead()
		{
				return false;
		}
	}
}
