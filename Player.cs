public class GameManager : MonoBehaviour
{
    private void Start()
    {
        DamageType selectedDamageType = DamageType.Fire;
        IDamageStrategy selectedStrategy;

        switch (selectedDamageType)
        {
            case DamageType.Physical:
                selectedStrategy = new PhysicalDamage();
                break;
            case DamageType.Magical:
                selectedStrategy = new MagicalDamage();
                break;
            case DamageType.Fire:
                selectedStrategy = new FireDamage();
                break;
            case DamageType.Ice:
                selectedStrategy = new IceDamage();
                break;
            case DamageType.Electric:
                selectedStrategy = new ElectricDamage();
                break;
            default:
                selectedStrategy = new BaseDamage();
                break;
        }

        Character playerCharacter = new Character(selectedStrategy);
        int baseDamage = 100;
        int calculatedDamage = playerCharacter.DealDamage(baseDamage);
        Debug.Log("Calculated Damage: " + calculatedDamage);
    }
}