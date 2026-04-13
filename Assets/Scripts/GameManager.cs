using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player player;
    private Character enemy;

    [SerializeField] private Character[] enemyPrefabs;
    [SerializeField] private Transform enemySpawnPoint;

    [SerializeField] private TMP_Text playerName, playerHP, enemyName, playerWeapon, enemyHP;

    void Start()
    {
        SpawnNewEnemy();
    }

    public void AttackButton()
    {
        if (enemy == null) return;

        player.Attack(enemy);

        if (enemy.IsDead())
        {
            SpawnNewEnemy();
            return;
        }

        player.ApplyEffects();
        enemy.ApplyEffects();

        if (!enemy.IsStunned())
        {
            enemy.Attack(player);
        }
        else
        {
            Debug.Log(enemy.CharName + " is stunned and skips turn!");
            enemy.ClearStun();
        }

        if (player.IsDead())
        {
            Debug.Log("GAME OVER");
        }

        UpdateUI();
    }

    public void SwitchWeapon()
    {
        player.SwitchWeapons();
        UpdateUI();
    }

    void SpawnNewEnemy()
    {
        if (enemy != null)
        {
            Destroy(enemy.gameObject);
        }

        int rand = Random.Range(0, enemyPrefabs.Length);
        enemy = Instantiate(enemyPrefabs[rand], enemySpawnPoint);

        UpdateUI();
    }

    private void UpdateUI()
    {
        if (enemy == null || player == null) return;

        playerName.text = player.CharName;
        enemyName.text = enemy.CharName;

        playerHP.text = "HP: " + player.health.ToString("F1");
        enemyHP.text = "HP: " + enemy.health.ToString("F1");

        playerWeapon.text = player.ActiveWeaponName;
    }
}