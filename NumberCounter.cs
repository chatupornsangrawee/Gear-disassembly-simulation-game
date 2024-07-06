using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberCounter : MonoBehaviour
{
    public TextMesh textMesh; // Reference to the TextMesh component

    void Start()
    {
        if (textMesh == null)
        {
            textMesh = GetComponent<TextMesh>();
        }

        if (textMesh != null)
        {
            // สุ่มค่า stopNumber ในช่วง 0.10 ถึง 0.30 และแสดงทันที
            float randomNumber = Random.Range(0.10f, 0.30f);
            textMesh.text = randomNumber.ToString("F2"); // แสดงผลด้วยทศนิยม 2 ตำแหน่ง
            Debug.Log("Random number: " + randomNumber);
        }
        else
        {
            Debug.LogError("TextMesh component not found.");
        }
    }
}