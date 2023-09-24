using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public Animator myanimator;
    public int maxHealth = 2;
    public int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void takeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Debug.Log("Enemy died!");
            PlayerScript.AddScore(10);
            Destroy(gameObject);
        }
    }
}