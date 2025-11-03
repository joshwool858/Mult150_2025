using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    void OnTriggerEnter (Collider other)
    {
        Debug.Log(other.gameObject.name + " has entered the cube");
    }
    void OnTriggerStay (Collider other)
    {
        Debug.Log(other.gameObject.name + " is still in the cube");
    }
    void OnTriggerExit (Collider other)
    {
        Debug.Log(other.gameObject.name + " has left the cube");
    }
}
/*
    Working with Triggers 7.

It is a trigger reaction between a Static Trigger Collider and a Rigidbody Collider.
The Cube has a Box Collider with an active trigger but no Rigidbody or Kinematic setting to go with it,
making it the Static Trigger Collider.
The Sphere has no active trigger, but it does have a Rigidbody that is not Kinematic,
making it a Rigidbody Collider.
The interaction of these two objects makes them slide into each other, as shown in the chart,
activating the trigger but causing no collisions- as shown in the chart.

*/