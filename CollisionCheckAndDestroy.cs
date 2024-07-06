using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheckAndDestroy : MonoBehaviour
{
    // Reference to the object S
    public GameObject objectS;

    // Function to handle the trigger event
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collided object has the tag "OB"
        if (other.CompareTag("OB"))
        {
            // Check if objectS is already destroyed
            if (objectS == null)
            {
                // Destroy the collided object
                Destroy(other.gameObject);
            }
        }
    }
}