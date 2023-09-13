using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject explosionPrefab;
    public AudioSource audioSource;

    void Start(){
        audioSource = GetComponent<AudioSource>();
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (audioSource.isPlaying)
            {
            
                audioSource.PlayOneShot(audioSource.clip);
            }
            else
            {
                // Play the sound when the object is clicked
                audioSource.Play();
            }
        
            // Get the mouse position
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = 10f; // Set an appropriate distance from the camera

            // Create an explosion at the mouse position
            GameObject explosion = Instantiate(explosionPrefab, Camera.main.ScreenToWorldPoint(mousePosition), Quaternion.identity);

            // Destroy the explosion after 1 second
            Destroy(explosion, 1f);
        }
    }
}
