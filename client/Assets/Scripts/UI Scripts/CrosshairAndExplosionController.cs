using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairAndExplosionController : MonoBehaviour
{
    public GameObject explosionPrefab;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get the current mouse position
        Vector3 mousePos = Input.mousePosition;

        // Convert the mouse position from screen space to world space
        mousePos.z = 1f; // Set the z-coordinate to a value that will put the object in front of the camera
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        // Move the object to the mouse position
        transform.position = mousePos;

        // Check for mouse button down (left click)
        if (Input.GetMouseButtonDown(0))
        {
            // Play audio
            if (audioSource.isPlaying)
            {
                audioSource.PlayOneShot(audioSource.clip);
            }
            else
            {
                audioSource.Play();
            }

            // Create an explosion at the mouse position
            GameObject explosion = Instantiate(explosionPrefab, mousePos, Quaternion.identity);

            // Destroy the explosion after 1 second
            Destroy(explosion, 1f);
        }
    }
}