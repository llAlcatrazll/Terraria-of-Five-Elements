// using ExampleMod.Content.Projectiles;
using TFE.Content.Buffs;
using TFE.Content.Dusts;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
namespace TFE.Content.Weapons
{
	public class HydroSpear : ModItem
	{
		public override void SetStaticDefaults() {
			ItemID.Sets.SkipsInitialUseSound[Item.type] = true; // This skips use animation-tied sound playback, so that we're able to make it be tied to use time instead in the UseItem() hook.
			ItemID.Sets.Spears[Item.type] = true; // This allows the game to recognize our new item as a spear.
            
		}

		public override void SetDefaults() {
			// Common Properties
			Item.rare = ItemRarityID.Pink; // Assign this item a rarity level of Pink
			Item.value = Item.sellPrice(silver: 10); // The number and type of coins item can be sold for to an NPC

			// Use Properties
			Item.useStyle = ItemUseStyleID.Thrust; // How you use the item (swinging, holding out, etc.)
			Item.useAnimation = 12; // The length of the item's use animation in ticks (60 ticks == 1 second.)
			Item.useTime = 18; // The length of the item's use time in ticks (60 ticks == 1 second.)
			Item.UseSound = SoundID.Item71; // The sound that this item plays when used.
			Item.autoReuse = true; // Allows the player to hold click to automatically use the item again. Most spears don't autoReuse, but it's possible when used in conjunction with CanUseItem()

			// Weapon Properties
			Item.damage = 25;
			Item.knockBack = 6.5f;
			Item.noUseGraphic = false; // When true, the item's sprite will not be visible while the item is in use. This is true because the spear projectile is what's shown so we do not want to show the spear sprite as well.
			Item.DamageType = DamageClass.Melee;
			// Item.noMelee = true; // Allows the item's animation to do damage. This is important because the spear is actually a projectile instead of an item. This prevents the melee hitbox of this item.

			// Projectile Properties
			Item.shootSpeed = 3.7f; // The speed of the projectile measured in pixels per frame.
			// Item.shoot = ModContent.ProjectileType<ExampleSpearProjectile>(); // The projectile that is fired from this weapon
		}

		public override bool CanUseItem(Player player) {
			// Ensures no more than one spear can be thrown out, use this when using autoReuse
			return player.ownedProjectileCounts[Item.shoot] < 1;
		}

		public override bool? UseItem(Player player) {
			// Because we're skipping sound playback on use animation start, we have to play it ourselves whenever the item is actually used.
			if (!Main.dedServ && Item.UseSound.HasValue) {
				SoundEngine.PlaySound(Item.UseSound.Value, player.Center);
			}

			return null;
		}

        public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
           	// target.AddBuff("WetDebuff", 300, false);
            // target.AddBuff(ModContent.BuffType<WetDebuff>(), 240);
            // target.AddBuff(BuffID.OnFire, 1800);
              
        }
public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.NextBool(6) )
            {
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, ModContent.DustType<WaterSplash>());
            }
        }
        // Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
        public override void AddRecipes() {
			CreateRecipe()
				// .AddIngredient<ExampleItem>()
				// .AddTile<Tiles.Furniture.ExampleWorkbench>()
				.Register();
		}
	}
}