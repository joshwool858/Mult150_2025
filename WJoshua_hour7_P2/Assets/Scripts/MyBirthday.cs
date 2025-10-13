using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int birthdayDay = 14;   // Your birthday day
        int daysInMonth = 31;   // July has 31 days

        for (int day = 1; day <= daysInMonth; day++)
        {
            if (day == birthdayDay)
            {
                Debug.Log("It's my birthday!");
            }
            else
            {
                Debug.Log(day);
            }
        }
    }    
    // Update is called once per frame
    void Update()
    {
        
    }
}
