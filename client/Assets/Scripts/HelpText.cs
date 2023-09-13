using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpText : MonoBehaviour
{
public GameObject helpTextPrefab;

    // The offset to position the help text on top of the civilian
    public Vector3 helpTextOffset = new Vector3(0, 75, 0);

    void Start()
    {
        // Instantiate the help text prefab and set its parent to this object
        GameObject helpTextObject = Instantiate(helpTextPrefab, transform.position, Quaternion.identity, transform);
        // Set the position of the help text object to be on top of the civilian
        helpTextObject.transform.position = transform.position + helpTextOffset;
        // Get the text mesh component attached to the help text object
        TextMesh textMesh = helpTextObject.GetComponentInChildren<TextMesh>();
        // Set the text to display on the help text object
        textMesh.text = "Help";
    }
}
