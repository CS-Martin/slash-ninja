using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public Animator myanimator;
    public int maxHealth = 2;
    public int currentHealth;
    
    void Start()
    {
        currentHealth = maxHealth;
    }

    
    public void takeDamage(int amount){
        //hurt animation
        currentHealth -= amount;
        if(currentHealth <= 0){
            //death animation
            Destroy(gameObject);
        }

    }
}
