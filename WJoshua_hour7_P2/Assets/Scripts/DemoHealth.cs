using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int health = 100;

        if (health == 0)
        {
            Debug.Log("player has been unalived");
        }
        else if (health < 30)
        {
            Debug.Log("DANGER! Low Health");
        }
        else if (health == 100)
        {
            Debug.Log("player is chilling");
        }
        else
        {
            Debug.Log("player is alive");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
