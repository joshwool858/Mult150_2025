using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExerciseTriggerScript : MonoBehaviour
{
    void OnTriggerEnter (Collider other)
    {
        Debug.Log(other.gameObject.name + " has entered the " + gameObject.name);
    }
    void OnTriggerStay (Collider other)
    {
        Debug.Log(other.gameObject.name + " is still in the " + gameObject.name);
    }
    void OnTriggerExit (Collider other)
    {
        Debug.Log(other.gameObject.name + " has left the " + gameObject.name);
    }
}
