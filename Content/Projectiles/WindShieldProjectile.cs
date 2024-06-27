using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TFE.Content.Projectiles
{
    public class WindShieldProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            // Projectile.name = "Boomerang";
            Projectile.width = 30;
            Projectile.height = 30;
            Projectile.aiStyle = 3;
            Projectile.friendly = true;
            Projectile.aiStyle = ProjAIStyleID.Boomerang;
            // Projectile.magic = false;
            Projectile.penetrate = 3;
            Projectile.timeLeft = 600;
            Projectile.light = 0.5f;
            Projectile.extraUpdates = 1;
           
           
        }
      

    }
}
