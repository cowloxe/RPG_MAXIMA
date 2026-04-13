using UnityEngine;

public class OldLady : Enemy
{
    [SerializeField] private float dodgeChance = 0.4f;

    public override void Attack(Character toHit)
    {
        Debug.Log(CharName + " hits with stick!");
        base.Attack(toHit);
    }

    public override void TakeDamage(float damage)
    {
        if (Random.value < dodgeChance)
        {
            Debug.Log(CharName + " dodged the attack!");
            return;
        }

        base.TakeDamage(damage);
    }
}