using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TFE.Content.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class DesertHelmet : ModItem
    {
        public override void SetDefaults()
        {
            Item.defense = 10;
            Item.rare = ItemRarityID.Expert;
        }

        public override void UpdateEquip(Player player)
        {

        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.Register();
        }
    }
}
