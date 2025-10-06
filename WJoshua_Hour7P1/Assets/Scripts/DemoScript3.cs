using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoScript3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int damage = 30;
        float speed = 10.0f;
        double rocketSpeed = 1004.4234243;
        bool gameOver = false;
        char someCharacter = 'A';
        string manyCharacters = "The night is dark and full of terrors";
        // multiple characters enclosed in double quotes

        Debug.Log("damage value is " + damage);
        Debug.Log("speed: " + speed);
        Debug.Log("rocketSpeed: " + rocketSpeed);
        Debug.Log("is the game over? " + gameOver);
        Debug.Log("someCharacter: " + someCharacter);
        Debug.Log("manyCharacters: " + manyCharacters);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
