using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAndActivate : MonoBehaviour
{
    // Drag the GameObject A in the Unity Inspector
    public GameObject objectA;
    
    // Drag the GameObject B in the Unity Inspector
    public GameObject objectB;

    void Update()
    {
        // Check if objectA is destroyed
        if (objectA == null && objectB != null)
        {
            objectB.SetActive(true);
            // Optionally, you can set objectB to null after activating it to avoid activating it multiple times
            objectB = null;
        }
    }
}