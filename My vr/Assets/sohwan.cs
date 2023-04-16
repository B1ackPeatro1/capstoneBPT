using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateOnClick : MonoBehaviour
{
    private bool isActive = false;

    void Start()
    {
        // Initially deactivate the game object
        gameObject.GetComponent<Behaviour>().enabled = isActive;
    }

    void Update()
    {
        // Check for left mouse button click
        if (Input.GetMouseButtonDown(0))
        {
            isActive = !isActive; // Toggle the active state

            // Activate or deactivate the game object based on the active state
            gameObject.GetComponent<Behaviour>().enabled = isActive;
        }
    }
}