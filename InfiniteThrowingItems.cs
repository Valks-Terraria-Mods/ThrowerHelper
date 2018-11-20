using Terraria;
using Terraria.ModLoader;

namespace ThrowersHelper
{
    class InfiniteThrowingItems : GlobalItem
    {
        public override bool ConsumeItem(Item item, Player player) {
            if (item.thrown) {
                return false;
            }
            return true;
        }
    }
}
