using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int sum = 0;
        int count = 1;
        while (count <= 10)
        {
            Debug.Log("sum:" + sum + " count:" + count);
            sum = sum + count;
            count++;
        }
        Debug.Log("final sum: " + sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
