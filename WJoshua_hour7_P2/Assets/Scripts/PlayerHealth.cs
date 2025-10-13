using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float health;
        health = 1004f;
        float poisonDamage;
        poisonDamage = 125.5f;

        while (health >= 1004)
        {
            Debug.Log(health);

            health -= poisonDamage;

            Debug.Log(health);

            health -= poisonDamage;

            Debug.Log(health);

            health -= poisonDamage;

            Debug.Log(health);

            health -= poisonDamage;

            Debug.Log(health);

            health -= poisonDamage;

            Debug.Log(health);

            health -= poisonDamage;

            Debug.Log(health);

            health -= poisonDamage;

            Debug.Log(health);

            health -= poisonDamage;

            Debug.Log(health);

            health -= poisonDamage;
        }
        if (health <= 0)
        {
            Debug.Log("player has been unalived");
        }
    }
        // Update is called once per frame
        void Update()
    {

    }
}
