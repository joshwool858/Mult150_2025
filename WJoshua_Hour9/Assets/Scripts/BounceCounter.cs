using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    int Count = 1;
    void OnCollisionEnter (Collision other)
    {
        Debug.Log(Count);
        Count += 1;
    }
}