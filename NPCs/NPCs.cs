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
			if (npc.type == NPCID.LunarTowerSolar)
			{
				if (Main.expertMode)
				npc.DropItemInstanced(npc.position, npc.Size, mod.ItemType("SolarBag"));
			}
			if (npc.type == NPCID.LunarTowerNebula)
			{
				if (Main.expertMode)
					npc.DropItemInstanced(npc.position, npc.Size, mod.ItemType("NebulaBag"));
			}
			if (npc.type == NPCID.LunarTowerVortex)
			{
				if (Main.expertMode)
					npc.DropItemInstanced(npc.position, npc.Size, mod.ItemType("VortexBag"));
			}
			if (npc.type == NPCID.LunarTowerStardust)
			{
				if (Main.expertMode)
					npc.DropItemInstanced(npc.position, npc.Size, mod.ItemType("StardustBag"));
			}
		}
		public override bool PreNPCLoot(NPC npc)
		{
			if (npc.type == NPCID.LunarTowerSolar)
			{
				if (Main.expertMode)
				NPCLoader.blockLoot.Add(ItemID.FragmentSolar);
			}
			
		
		    if (npc.type == NPCID.LunarTowerNebula)
		    {
				if (Main.expertMode)
				NPCLoader.blockLoot.Add(ItemID.FragmentNebula);
	        }
			

			if (npc.type == NPCID.LunarTowerVortex)
			{
				if (Main.expertMode)
					NPCLoader.blockLoot.Add(ItemID.FragmentVortex);
			}
			

			if (npc.type == NPCID.LunarTowerStardust)
			{
				if (Main.expertMode)
					NPCLoader.blockLoot.Add(ItemID.FragmentStardust);
			}
			return true;
		}
	}
}
