using UnityEngine;

public class Taser : Weapon
{
    [SerializeField] private float stunChance = 0.5f;

    public override float GetDamage()
    {
        return base.GetDamage() * 0.5f;
    }

    public void TryStun(Character target)
    {
        if (Random.value < stunChance)
        {
            target.Stun();
        }
    }
}