using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlayController : MonoBehaviour
{
     public GameObject overlayPanel;

    void Start()
    {
        // Hide the overlay panel at the start
        HideOverlay();
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
