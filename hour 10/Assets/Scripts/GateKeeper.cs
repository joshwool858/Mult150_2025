using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateKeeper : MonoBehaviour
{
    MeshRenderer meshRendererComponent;
    BoxCollider boxColliderComponent;
    void Start()
    {
        meshRendererComponent = GetComponent<MeshRenderer>();
        boxColliderComponent = GetComponent<BoxCollider>();
    }
    void Update()
    {
        Gate();
    }
    void Gate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && boxColliderComponent.enabled == true)
        {
            boxColliderComponent.enabled = false;
            meshRendererComponent.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && boxColliderComponent.enabled == false) 
        {
            boxColliderComponent.enabled = true;
            meshRendererComponent.enabled = true; 
        }
    }
}
