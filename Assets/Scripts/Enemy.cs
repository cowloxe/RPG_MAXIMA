using UnityEngine;

public class Enemy : Character
{
    [SerializeField] protected float minDamage, maxDamage;

    public override void Attack(Character toHit)
    {
        float damage = Random.Range(minDamage, maxDamage);
        toHit.TakeDamage(damage);
    }
}