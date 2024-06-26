using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TFE.Content.Armor{
  [AutoloadEquip(EquipType.Head)]
    public class Alcatraz : ModItem{
        public override void SetDefaults()
        {
         Item.width = 18;
         Item.height = 24;
         			Item.value = Item.sellPrice(gold: 1);
         Item.rare = ItemRarityID.Cyan;
        //  Item.vanity = true;
         Item.defense = 2;
        //  Item.headSlot = 1;
        }
    }
}