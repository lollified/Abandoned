using UnityEngine;

public class PowerUp : MonoBehaviour
{
    HealthBar playerHealth;

    public float healthBonus = 15f;

    void Awake()
    {
        playerHealth = FindObjectOfType<HealthBar>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(playerHealth.currentHealth < playerHealth.startingHealth)
        {
            Destroy(gameObject);
            playerHealth.currentHealth = playerHealth.currentHealth + healthBonus;
        }
    }
}
