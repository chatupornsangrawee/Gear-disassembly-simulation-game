using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToActivateAndDes : MonoBehaviour
{
    public GameObject objectToActivate;

    void OnMouseDown()
    {
        Debug.Log("Object clicked: " + gameObject.name);

        if (objectToActivate != null)
        {
            objectToActivate.SetActive(true);
        }

        Destroy(gameObject);
    }
}