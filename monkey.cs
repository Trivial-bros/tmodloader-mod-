using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace urmom.Items.Tools
{
    public class monkey : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("luckily we're rich");
        }

        public override void SetDefaults()
        {
            item.damage = 69;
            item.melee = true;
            item.width = 69;
            item.height = 69;
            item.useTime = 69;
            item.useAnimation = 69;
            item.pick = 69;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 69;
            item.value = 69420;
            item.rare = ItemRarityID.Yellow;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Amethyst, 69);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	


        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.NextBool(420))
            {

            }
        }
    }
}
