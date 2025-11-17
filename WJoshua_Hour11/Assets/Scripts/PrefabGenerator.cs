using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        int count = 10;          // number of lamps to spawn
        float spacing = 5f;      // distance between each lamp

        for (int i = 0; i < count; i++)
        {
            Vector3 pos = transform.position + new Vector3(i * spacing, 0f, 0f);
            Instantiate(prefab, pos, transform.rotation);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
