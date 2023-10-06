using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    public Slider healthSlider;
    public float startingHealth = 100.0f;
    public float decreaseRate = 0.5f;
    //public float maxHealth = 100.0f;

    public float currentHealth;

    private void Start()
    {
        currentHealth = startingHealth;
        UpdateHealthBar();
        InvokeRepeating("DecreaseHealth", 1.0f, 1.0f);
    }

    private void UpdateHealthBar()
    {
        healthSlider.value = currentHealth / startingHealth;
        Debug.Log("Health bar updated.");
    }

    private void DecreaseHealth()
    {
        if (currentHealth > 0)
        {
            currentHealth -= decreaseRate;
            UpdateHealthBar();
        }
        else
        {
            // Health is depleted, you can handle this situation here
            SceneManager.LoadSceneAsync(4);
        }
    }
}
