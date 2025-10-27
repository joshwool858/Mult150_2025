using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Create the variable above Start()
    int healthpoints = 3992;

    void Start()
    {
        // Let's use a potion!
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);

        // Log the final value
        Debug.Log(healthpoints);
    }

    void Update()
    {
        // Called once per frame
    }

    // Function defined below Update()
    int UsePotion(int health)
    {
        health += 400;
        return health;
    }
}