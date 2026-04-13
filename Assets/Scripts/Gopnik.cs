using UnityEngine;

public class Gopnik : Enemy
{
    public override void Attack(Character toHit)
    {
        Debug.Log(CharName + " uses Punch!");
        base.Attack(toHit);
    }
}