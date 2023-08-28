public class BaseDamage : IDamageStrategy
{
    public int CalculateDamage(int baseDamage)
    {
        return baseDamage;
    }
}

public class PhysicalDamage : IDamageStrategy
{
    public int CalculateDamage(int baseDamage)
    {
        return Mathf.RoundToInt(baseDamage * 1.1f);
    }
}

public class MagicalDamage : IDamageStrategy
{
    public int CalculateDamage(int baseDamage)
    {
        return Mathf.RoundToInt(baseDamage * 1.3f);
    }
}

public class FireDamage : IDamageStrategy
{
    public int CalculateDamage(int baseDamage)
    {
        return Mathf.RoundToInt(baseDamage * 1.5f);
    }
}

public class IceDamage : IDamageStrategy
{
    public int CalculateDamage(int baseDamage)
    {
        return Mathf.RoundToInt(baseDamage * 1.2f);
    }
}

public class ElectricDamage : IDamageStrategy
{
    public int CalculateDamage(int baseDamage)
    {
        return Mathf.RoundToInt(baseDamage * 1.4f);
    }
}
