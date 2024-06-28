
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace TFE.Content.Tiles
{
    public class LargeElementalStatue1 : ModTile{
	
		public override void SetStaticDefaults() {
			TileObjectData.newTile.CopyFrom(TileObjectData.Style4x2);
			// TileObjectData.newTile.Width = 16;
			// TileObjectData.newTile.Height = 16;
			// TileObjectData.newTile.Height = 64;
			// TileObjectData.newTile.Width = 64;
			// TileObjectData.newTile.UsesCustomCanPlace = true;
			// TileObjectData.newTile.Width = 2;
			// TileObjectData.newTile.Height = 2;
			TileObjectData.newTile.CoordinateHeights = [16, 16, 18]; // Extend into grass tiles.
			TileObjectData.addTile(Type);
// WORKING kinda TileObjectData.newTile.CoordinateHeights = [16, 16, 18];
// 32x32 is more broken
			// THE CUSTOM STATUE IS 64 X 52 PIXELS

	
		}
	}
}