using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public float health;
    [SerializeField] private string charName;

    protected bool isStunned = false;
    protected float poisonDamage = 0;

    public string CharName
    {
        get { return charName; }
    }

    public abstract void Attack(Character toHit);

    public virtual void TakeDamage(float damage)
    {
        health -= damage;
        health = Mathf.Max(health, 0);

        Debug.Log(charName + " got hit for " + damage + " damage! HP: " + health);
    }

    public void TakeDamage(Weapon weapon)
    {
        if (weapon == null) return;

        float damage = weapon.GetDamage();
        TakeDamage(damage);
    }

    public void AddPoison(float amount)
    {
        poisonDamage += amount;
        Debug.Log(charName + " is poisoned!");
    }

    public virtual void ApplyEffects()
    {
        if (poisonDamage > 0)
        {
            health -= poisonDamage;
            Debug.Log(charName + " takes poison damage: " + poisonDamage);
        }
    }

    public void Stun()
    {
        isStunned = true;
        Debug.Log(charName + " is stunned!");
    }

    public bool IsStunned()
    {
        return isStunned;
    }

    public void ClearStun()
    {
        isStunned = false;
    }

    public bool IsDead()
    {
        return health <= 0;
    }
}