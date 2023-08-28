public class Character
{
    private IDamageStrategy damageStrategy;

    public Character(IDamageStrategy strategy)
    {
        damageStrategy = strategy;
    }

    public int DealDamage(int baseDamage)
    {
        return damageStrategy.CalculateDamage(baseDamage);
    }
}