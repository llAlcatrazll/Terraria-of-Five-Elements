using TFE.Content.Projectiles;
// 
using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TFE.Content.Items.Weapons
{
    public class WindShield : ModItem
    {
        public override void SetDefaults()
        {
            // Item. = "Cool Boomerang";
            Item.damage = 30;           
            Item.DamageType = DamageClass.Melee;
            Item.width = 30;
            Item.height = 30;
            // Item.toolTip = "A cool boomerang";
            Item.useTime = 25;
            Item.useAnimation = 25;
            Item.noUseGraphic = true;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 3;
            Item.value = 8;
          
            Item.shootSpeed = 12f;
            Item.shoot = ModContent.ProjectileType<WindShieldProjectile>();
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }
        public override bool CanUseItem(Player player)       //this make that you can shoot only 1 boomerang at once
        {
            for (int i = 0; i < 1000; ++i)
            {
                if (Main.projectile[i].active && Main.projectile[i].owner == Main.myPlayer && Main.projectile[i].type == Item.shoot)
                {
                    return false;
                }
            }
            return true;
        }
    }
}