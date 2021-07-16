using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using RedboidMutilation.Items.Vanity;

namespace RedboidMutilation.Items.Bags
{
    public class VortexBag : ModItem
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
            Mod Calamity = ModLoader.GetMod("CalamityMod");
            player.TryGettingDevArmor();
            if (Calamity == null)
            player.QuickSpawnItem(ItemID.FragmentVortex, 30 + Main.rand.Next(60)); // 5, 6, or 7);
            if (Calamity != null)
            player.QuickSpawnItem(ItemID.FragmentVortex, 5 + Main.rand.Next(10));
            if (Main.rand.Next(7) < 1) // a 1 in 7 chance
            player.QuickSpawnItem(ModContent.ItemType<VortexianMask>());
        }
    }
}
