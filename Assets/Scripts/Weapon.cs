using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private float minDamage, maxDamage;
    [SerializeField] private string attackName = "Attack";

    public string weaponName;

    public string AttackName
    {
        get { return attackName; }
    }

    public virtual float GetDamage()
    {
        return Random.Range(minDamage, maxDamage);
    }
}