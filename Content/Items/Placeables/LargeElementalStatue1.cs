using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TFE.Content.Items.Placeables
{
    public class LargeElementalStatue1 : ModItem{
        public override void SetDefaults()
        {	Item.CloneDefaults(ItemID.ArmorStatue);
           	Item.createTile = ModContent.TileType<Tiles.LargeElementalStatue1>();
			Item.placeStyle = 0;
        }
        
    }
}