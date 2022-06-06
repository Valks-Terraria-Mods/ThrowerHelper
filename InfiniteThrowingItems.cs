namespace ThrowerHelper;

class InfiniteThrowingItems : GlobalItem
{
    public override bool ConsumeItem(Item item, Player player) => !item.CountsAsClass(DamageClass.Throwing);
}
