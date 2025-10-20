using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideQuest : MonoBehaviour
{
    int TakeDamage(int damageAmount) /*Method Name, Single Parameter Type */
    {
        int health = 100; /* return type is int */
        return health - damageAmount;
    } /* Everything above this is in the method block code */
}
