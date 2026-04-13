using UnityEngine;

public class DrunkGuard : Enemy
{
    [SerializeField] private float poisonAmount = 2f;

    public override void Attack(Character toHit)
    {
        Debug.Log(CharName + " throws a Central market odekolons!");

        base.Attack(toHit);
        toHit.AddPoison(poisonAmount);
    }
}