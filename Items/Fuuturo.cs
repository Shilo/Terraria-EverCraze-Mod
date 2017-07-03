using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EverCraze.Items
{
	public class Fuuturo : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fuuturo");
			Tooltip.SetDefault("The elegant sword once wielded by almighty Savannah.");
		}

		public override void SetDefaults()
		{
            item.CloneDefaults(ItemID.BreakerBlade);
            item.autoReuse = true;
		}

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 5 * 60);
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Fire, player.velocity.X * 0.2f + (float)(player.direction * 3), player.velocity.Y * 0.2f, 100, default(Color), 3.0f);
            Main.dust[dust].noGravity = true;
        }
    }
}
