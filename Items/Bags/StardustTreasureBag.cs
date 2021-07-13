using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace RedboidMutilation.Items.Bags
{
    public class StardustBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("Right click to open");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.rare = -12;
            item.maxStack = 999;
            item.value = 1;
            item.expert = true;
            item.expertOnly = false;
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(ItemID.FragmentStardust, 24 + Main.rand.Next(76)); // 5, 6, or 7);
        }
    }
}
