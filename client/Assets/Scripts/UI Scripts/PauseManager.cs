using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public GameObject settingsPanel;  // Drag your settings panel here

    private bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        // Hide settings panel initially
        settingsPanel.SetActive(false);
    }

    // Called when the Settings button is clicked
    public void OnSettingsClick()
    {
        if (isPaused)
        {
            ResumeGame();
        }
        else
        {
            PauseGame();
        }
    }

    void PauseGame()
    {
        // Show settings panel
        settingsPanel.SetActive(true);

        // Pause time
        Time.timeScale = 0;

        isPaused = true;
    }

    void ResumeGame()
    {
        // Hide settings panel
        settingsPanel.SetActive(false);

        // Resume time
        Time.timeScale = 1;

        isPaused = false;
    }
}
