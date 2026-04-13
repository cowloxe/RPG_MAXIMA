using UnityEngine;

public class PoisonWeapon : Weapon
{
    public float poisonDamage;

    public override float GetDamage()
    {
        return base.GetDamage();
    }

    public void ApplyPoison(Character target)
    {
        target.AddPoison(poisonDamage);
    }
}