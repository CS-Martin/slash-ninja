using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public GameObject overlayPanel;
    public AudioSource audioSource;
    
    public int maxHealth = 5;
    public int currentHealth;
    
    public HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        HideOverlay();
        currentHealth = 5;
        healthBar.setMaxHealth(maxHealth);
        audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void takePlayerDamage(int amount){
        currentHealth -= amount;
        healthBar.setHealth(currentHealth);
        if(currentHealth == 0){
            //game over
            ShowOverlay();
            Time.timeScale = 0f;
            audioSource.Play();
        }

    }

    public void ShowOverlay()
    {
        // Show the overlay panel
        overlayPanel.SetActive(true);
    }

    public void HideOverlay()
    {
        // Hide the overlay panel
        overlayPanel.SetActive(false);
    }
}
