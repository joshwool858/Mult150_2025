using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    /* Mouse Sensitivity")] */
    public float sensitivity = 0.1f;

    /* Movement Limits */
    public bool clampMovement = false;
    public Vector2 xLimits = new Vector2(-10f, 10f);
    public Vector2 yLimits = new Vector2(-5f, 5f);

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Get mouse input
        float moveX = Input.GetAxis("Mouse X") * sensitivity;
        float moveY = Input.GetAxis("Mouse Y") * sensitivity;

        // Apply translation
        Vector3 newPosition = transform.position + new Vector3(moveX, moveY, 0f);

        // Clamp if enabled
        if (clampMovement)
        {
            newPosition.x = Mathf.Clamp(newPosition.x, startPosition.x + xLimits.x, startPosition.x + xLimits.y);
            newPosition.y = Mathf.Clamp(newPosition.y, startPosition.y + yLimits.x, startPosition.y + yLimits.y);
        }

        transform.position = newPosition;
    }
}