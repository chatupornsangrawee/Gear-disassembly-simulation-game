using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectToggle : MonoBehaviour
{
    public GameObject[] objectsA;
    public GameObject objectB;

    private bool allObjectsAActivated = false;

    void Update()
    {
        // Check if all objects A are fully activated
        bool allActivated = true;
        foreach (GameObject objA in objectsA)
        {
            if (!objA.activeSelf)
            {
                allActivated = false;
                break;
            }
        }

        if (allActivated && !allObjectsAActivated)
        {
            allObjectsAActivated = true;
        }

        // Activate object B if all objects A are fully activated
        if (allObjectsAActivated && !objectB.activeSelf)
        {
            objectB.SetActive(true);
        }
    }
}