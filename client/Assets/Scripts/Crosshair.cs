using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible=false;
    }

    // Update is called once per frame
    void Update()
    {
         // Get the current mouse position
        Vector3 mousePos = Input.mousePosition;

        // Convert the mouse position from screen space to world space
        mousePos.z = 10f; // Set the z-coordinate to a value that will put the object in front of the camera
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        // Move the object to the mouse position
        transform.position = mousePos;
    }
}
