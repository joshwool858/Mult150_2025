using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    private Light myLight;

    void Start()
    {
        // Get the Light component attached to this GameObject
        myLight = GetComponent<Light>();
    }

    void Update()
    {
        // Check if the 'L' key was pressed this frame
        if (Input.GetKeyDown(KeyCode.L))
        {
            // Toggle the light's enabled state
            myLight.enabled = !myLight.enabled;
        }
    }
}
