using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RedboidMutilation.NPCs
{
	class MyGlobalNPC : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (npc.type == NPCID.UndeadMiner)
			{
				if (Main.rand.NextFloat() < .1200f)
					Item.NewItem(npc.getRect(), mod.ItemType("RustedHamaxe"));
			}
			// Addtional if statements here if you would like to add drops to other vanilla npc.
		}
	}
}