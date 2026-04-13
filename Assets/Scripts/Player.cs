using UnityEngine;

public class Player : Character
{
    [SerializeField] private Weapon[] weapons;
    [SerializeField] private Weapon activeWeapon;

    private int selectedWeaponID = 0;

    public string ActiveWeaponName
    {
        get
        {
            if (activeWeapon == null) return "No Weapon";
            return activeWeapon.weaponName;
        }
    }

    void Start()
    {
        if (weapons.Length > 0)
        {
            activeWeapon = weapons[0];
        }
    }

    public override void Attack(Character toHit)
    {
        if (activeWeapon == null) return;

        Debug.Log(CharName + " uses " + activeWeapon.AttackName + "!");

        toHit.TakeDamage(activeWeapon);

        // Taser stun effect
        Taser taser = activeWeapon as Taser;
        if (taser != null)
        {
            taser.TryStun(toHit);
        }
    }

    public void SwitchWeapons()
    {
        if (weapons.Length == 0) return;

        selectedWeaponID = (selectedWeaponID + 1) % weapons.Length;
        activeWeapon = weapons[selectedWeaponID];
    }
}